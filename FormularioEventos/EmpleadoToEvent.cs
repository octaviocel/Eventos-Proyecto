using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FormularioEventos
{
    public partial class EmpleadoToEvent : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;
        private String eventoNum;
        private CheckedListBox lista;
        public EmpleadoToEvent(String id)
        {
            InitializeComponent();
            eventoNum = id;
        }

        private void EmpleadoToEvent_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            int empleados=0;
            try
            {
                SqlCommand comando = new SqlCommand("SELECT COUNT(ID) FROM EMPLEADOS", conexion);
                empleados = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

            if (empleados>0)
            {
                
                String[] empleados1 = new string[empleados];
                String[] ides = new string[empleados];
                int i = 0;
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT ID, NOMBRE, APELLIDO, PUESTO, TARIFA FROM EMPLEADOS", conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        ides[i] = lector["ID"].ToString();
                        string temp = lector["ID"].ToString() + "\t" + lector["NOMBRE"].ToString() + "\t" + lector["APELLIDO"].ToString() + "\t\t" +
                            lector["PUESTO"].ToString() + "\t$" + lector["TARIFA"].ToString();
                        empleados1[i] = temp;
                        i++;
                    }
                    lista = new CheckedListBox();
                    lista.Items.AddRange(empleados1);
                    lista.Size = new Size(500, 350);
                    lista.Location = new Point(200, 20);

                    Label lbl = new Label();
                    lbl.Text = "Agrega tus Empleados del evento";
                    lbl.Size = new Size(200, 200);
                    lbl.Font = new Font("Arial", 20);



                    this.Controls.Add(lbl);
                    this.Controls.Add(lista);
                    conexion.Close();
                }catch(Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
            }
            else
            {
                Panel temp = new Panel();
                temp.Location = new Point(400, 200);
                temp.Size = new Size(264, 200);
                Label lbl = new Label();
                lbl.Text="No existen Usuarios disponibles";
                lbl.Size = new Size(100, 200);
                temp.Controls.Add(lbl);
                this.Controls.Add(temp);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lista.CheckedItems.Count != 0)
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                for (int x = 0; x < lista.CheckedItems.Count; x++)
                {
                    string usuario=lista.CheckedItems[x].ToString();
                    string[] words = usuario.Split('\t');                    
                    SqlTransaction transaccion = conexion.BeginTransaction();
                    try
                    {
                        SqlCommand comando = new SqlCommand("INSERT INTO EMPLEADOSXEVENTO (NOEVENTO, IDENTIFICADOR)" +
                            "values (@p1, @p2)", conexion);
                        comando.Parameters.Add("@p1", SqlDbType.VarChar).Value = eventoNum;
                        comando.Parameters.Add("@p2", SqlDbType.Int).Value = Convert.ToInt32(words[0].Trim());

                        comando.Transaction = transaccion;
                        comando.ExecuteNonQuery();
                        transaccion.Commit();            
                    }
                    catch(Exception e2)
                    {
                        transaccion.Rollback();
                        MessageBox.Show(e2.Message);
                    }
                }
                conexion.Close();
                MessageBox.Show("Se han registrados correctamente los empleados");
                AbrirFormEnPanel(new MostrarEventos());
            }
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MostrarEventos());
            //this.Close();            
            
        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            this.Controls.Clear();
            Form fh = Formhijo as Form;

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            fh.Show();
        }
    }
}
