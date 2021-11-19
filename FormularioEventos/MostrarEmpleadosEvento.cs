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
    public partial class MostrarEmpleadosEvento : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;

        private string id;
        
        public MostrarEmpleadosEvento(string evento)
        {
            InitializeComponent();
            this.id = evento;
        }
        
        private void MostrarEmpleadosEvento_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                /*SqlCommand comando = new SqlCommand("SELECT E.IDENTIFICADOR, EM.NOMBRE, EM.APELLIDO, EM.PUESTO, EM.TARIFA "+
                            "FROM EMPLEADOSXEVENTO E "+ " INNER JOIN EMPLEADOS EM ON E.IDENTIFICADOR = EM.ID "+
                            "WHERE E.NOEVENTO = '"+id+"'", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ListViewItem filita = new ListViewItem(lector["IDENTIFICADOR"].ToString());
                    filita.SubItems.Add(lector["NOMBRE"].ToString());
                    filita.SubItems.Add(lector["APELLIDO"].ToString());
                    filita.SubItems.Add(lector["PUESTO"].ToString());
                    filita.SubItems.Add("$" + lector["TARIFA"].ToString());

                    listView1.Items.Add(filita);
                }
                
                conexion.Close();*/
                //SqlConnection conexion = conexionBD.ObtenerConexion();
                SqlCommand consulta = new SqlCommand("SELECT E.IDENTIFICADOR, EM.NOMBRE, EM.APELLIDO, EM.PUESTO, EM.TARIFA " +
                            "FROM EMPLEADOSXEVENTO E " + " INNER JOIN EMPLEADOS EM ON E.IDENTIFICADOR = EM.ID " +
                            "WHERE E.NOEVENTO = '" + id + "'", conexion);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;                
                conexion.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }           

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

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MostrarEventos());
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow c in dataGridView1.Rows)

            {
                if (c.Selected == true)
                {
                    if (MessageBox.Show("Seguro borrará de el evento al Empleado " , "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        i = Convert.ToInt32(c.Cells[0].Value.ToString());
                        dataGridView1.Rows.Remove(c);
                        
                    }

                }
            }
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand("DELETE FROM EMPLEADOSXEVENTO WHERE NOEVENTO = '" + id + "' AND IDENTIFICADOR = " + i, conexion);
                
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Borrado exitoso");
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }
        /*
private void listView1_DoubleClick(object sender, EventArgs e)
{
   foreach (ListViewItem lv in listView1.SelectedItems)
   {
       String id2 = lv.Text;
       if (MessageBox.Show("Seguro borrará de el evento al Empleado con identificador " + id2, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
       {
           SqlConnection conexion = new SqlConnection(cadena);
           conexion.Open();
           try
           {
               SqlCommand comando = new SqlCommand("DELETE FROM EMPLEADOSXEVENTO WHERE NOEVENTO = '"+id+"' AND IDENTIFICADOR = "+Convert.ToInt32(id2), conexion);
               //comando.Parameters.Add("@p1", SqlDbType.VarChar).Value = id;
               comando.ExecuteNonQuery();
               lv.Remove();
               conexion.Close();
               MessageBox.Show("Borrado exitoso");
           }
           catch (Exception e2)
           {
               MessageBox.Show(e2.Message);
           }
       }

   }
}*/
    }
}
