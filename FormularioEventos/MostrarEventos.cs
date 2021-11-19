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
    public partial class MostrarEventos : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;

        List<CraerEvent> levento = new List<CraerEvent>();
        public MostrarEventos()
        {
            InitializeComponent();
        }

        private void MostrarEventos_Load(object sender, EventArgs e)
        {
            cargarCosas();
        }
        private void cargarCosas()
        {
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("getEvent", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ListViewItem filita = new ListViewItem(lector["NOEVENTO"].ToString());
                    filita.SubItems.Add(lector["TIPOEVENTO"].ToString());
                    filita.SubItems.Add(lector["INVITADOS"].ToString());
                    filita.SubItems.Add(lector["NOMBREP"].ToString());
                    filita.SubItems.Add(lector["NOMBREG"].ToString());
                    filita.SubItems.Add(lector["NOMBREPO"].ToString());
                    filita.SubItems.Add(lector["BEBIDAS"].ToString());
                    filita.SubItems.Add("$" + lector["COSTOEVENTO"].ToString());

                    listView1.Items.Add(filita);
                }
                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.listView1, "Doble click para Borrar");
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                String id =lv.Text;
                if (MessageBox.Show("Seguro borrará el evento No." + id, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conexion = new SqlConnection(cadena);
                    conexion.Open();
                    try
                    {
                        SqlCommand comando1 = new SqlCommand("DELETE FROM EMPLEADOSXEVENTO WHERE NOEVENTO='" + id + "'", conexion);
                        comando1.ExecuteNonQuery();

                        SqlCommand comando = new SqlCommand("DELETE FROM EVENTO WHERE NOEVENTO = '"+id+"'", conexion);
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
        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            toolTip1.SetToolTip(this.listView1, "Doble click para Borrar \n Click derecho para agregar empleados");
        }

        private void eliminar()
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(this, new Point(e.X, e.Y));
                }                
            }
        }

        private void agregarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                String id = lv.Text;         

                AbrirFormEnPanel(new EmpleadoToEvent(id));
            }
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Mostrar");
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                String id = lv.Text;
                AbrirFormEnPanel(new MostrarEmpleadosEvento(id));
                

            }
            
        }

        private void eliminarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                String id = lv.Text;
                if (MessageBox.Show("Seguro borrará " + id, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conexion = new SqlConnection(cadena);
                    conexion.Open();
                    try
                    {
                        SqlCommand comando = new SqlCommand("DELETE FROM EVENTO WHERE NOEVENTO = '" + id + "'", conexion);
                        //comando.Parameters.Add("@p1", SqlDbType.VarChar).Value = id;

                        comando.ExecuteNonQuery();
                        lv.Remove();
                        conexion.Close();
                        MessageBox.Show("Borrado exitoso");
                    }catch(Exception e2)
                    {
                        MessageBox.Show(e2.Message);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteEventos rep = new ReporteEventos();
            rep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReporteDetaEvent re = new ReporteDetaEvent();
            re.ShowDialog();
        }

        private void editarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                String id = lv.Text;
                ActualizarEvent actu = new ActualizarEvent(id);
                actu.ShowDialog();
                
            }
            foreach (ListViewItem lv in listView1.Items)
            {
                lv.Remove();
            }
            cargarCosas();
        }
    }
}
