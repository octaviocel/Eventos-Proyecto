using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEventos
{
    public partial class Catalogo : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;
        public Catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            if(txtPlatillo.Text != "")
            {
                SqlConnection conexion = new SqlConnection(cadena);

                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO PLATILLOS (NOMBREP) VALUES ('"+txtPlatillo.Text+"')", conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Insercion de nuevo platillo completado");
                    txtPlatillo.Text = "";
                    cargarPlatillo();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Platillo para agregar");
            }
        }

        private void cargarPlatillo()
        {
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT ID, NOMBREP FROM PLATILLOS", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ListViewItem filita = new ListViewItem(lector["ID"].ToString());
                    filita.SubItems.Add(lector["NOMBREP"].ToString());
                    listView1.Items.Add(filita);
                }
                conexion.Close();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet datset = new DataSet();
                adaptador.Fill(datset);

                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void cargarGuarnicion()
        {
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT ID, NOMBREG FROM GUARNICIONES", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ListViewItem filita = new ListViewItem(lector["ID"].ToString());
                    filita.SubItems.Add(lector["NOMBREG"].ToString());
                    listView2.Items.Add(filita);
                }
                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void cargarPostre()
        {
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT ID, NOMBREPO FROM POSTRES", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ListViewItem filita = new ListViewItem(lector["ID"].ToString());
                    filita.SubItems.Add(lector["NOMBREPO"].ToString());
                    listView3.Items.Add(filita);
                }
                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            cargarPlatillo();
            cargarGuarnicion();
            cargarPostre();
        }

        private void btnAgregarGuar_Click(object sender, EventArgs e)
        {
            if (txtGuarnicion.Text != "")
            {
                SqlConnection conexion = new SqlConnection(cadena);

                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO GUARNICIONES (NOMBREG) VALUES ('" + txtGuarnicion.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Insercion de nueva Guarnicion completada");
                    txtGuarnicion.Text = "";
                    cargarGuarnicion();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Guarnicion para agregar");
            }
        }

        private void btnAgregarPostre_Click(object sender, EventArgs e)
        {
            if (txtPostre.Text != "")
            {
                SqlConnection conexion = new SqlConnection(cadena);

                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO POSTRES (NOMBREPO) VALUES ('" + txtPostre.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Insercion de nuevo Postre completado");
                    txtPostre.Text = "";
                    cargarPostre();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Postre para agregar");
            }
        }

        private void btnBorrarPlato_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lv in listView1.SelectedItems)
                {
                    String id = lv.Text;
                    if (MessageBox.Show("Seguro borrará " + id, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlConnection conexion = new SqlConnection(cadena);
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("DELETE FROM PLATILLOS WHERE ID=" + id, conexion);
                        comando.ExecuteNonQuery();

                        lv.Remove();
                        conexion.Close();
                        MessageBox.Show("Borrado exitoso");
                    }

                }
            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado");
            }
        }

        private void btnBorrarGuar_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lv in listView2.SelectedItems)
                {
                    String id = lv.Text;
                    if (MessageBox.Show("Seguro borrará " + id, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlConnection conexion = new SqlConnection(cadena);
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("DELETE FROM GUARNICIONES WHERE ID=" + id, conexion);
                        comando.ExecuteNonQuery();

                        lv.Remove();
                        conexion.Close();
                        MessageBox.Show("Borrado exitoso");
                    }

                }
            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado");
            }
        }

        private void btnBorrarPostre_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lv in listView3.SelectedItems)
                {
                    String id = lv.Text;
                    if (MessageBox.Show("Seguro borrará " + id, "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlConnection conexion = new SqlConnection(cadena);
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("DELETE FROM POSTRES WHERE ID=" + id, conexion);
                        comando.ExecuteNonQuery();

                        lv.Remove();
                        conexion.Close();
                        MessageBox.Show("Borrado exitoso");
                    }

                }
            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReporteCat rep = new ReporteCat();
            rep.ShowDialog();
        }

    }
}
