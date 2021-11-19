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
    public partial class AgregarEmpleados : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;

        public AgregarEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {            
            AbrirFormEnPanel(new Empleados());
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

        private void AgregarEmpleados_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("getEmpleados", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ListViewItem filita = new ListViewItem(lector["ID"].ToString());
                    filita.SubItems.Add(lector["NOMBRE"].ToString());
                    filita.SubItems.Add(lector["APELLIDO"].ToString());
                    filita.SubItems.Add(lector["PUESTO"].ToString());
                    filita.SubItems.Add(lector["TARIFA"].ToString());
                    listView1.Items.Add(filita);
                }
                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                String id = lv.Text;
                if (MessageBox.Show("Seguro borrará " + id, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conexion = new SqlConnection(cadena);
                    conexion.Open();
                    SqlCommand comando1 = new SqlCommand("DELETE FROM EMPLEADOSXEVENTO WHERE IDENTIFICADOR=" + id, conexion);
                    comando1.ExecuteNonQuery();
                    SqlCommand comando = new SqlCommand("DELETE FROM EMPLEADOS WHERE ID= @p1", conexion);
                    comando.Parameters.Add("@p1", SqlDbType.Int).Value = Convert.ToInt32(id);

                    comando.ExecuteNonQuery();
                    lv.Remove();
                    conexion.Close();
                    MessageBox.Show("Borrado exitoso");
                }

            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
           // toolTip1.SetToolTip(this.listView1, "Cerrar");
        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.listView1, "Doblle click para Borrar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteEmpleados re = new ReporteEmpleados();
            re.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                int id = Convert.ToInt32(lv.Text);
                ActualizarEmplooye emp = new ActualizarEmplooye(id);
                emp.ShowDialog();
            }
            foreach (ListViewItem lv in listView1.Items)
            {
                lv.Remove();
            }
            cargar();
        }
    }
}
