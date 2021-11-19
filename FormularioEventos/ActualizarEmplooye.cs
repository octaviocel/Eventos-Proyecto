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
    public partial class ActualizarEmplooye : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;
        int miembro;
        public ActualizarEmplooye(int id)
        {
            InitializeComponent();
            miembro = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarEmplooye_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADOS WHERE ID=" + miembro , conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txtID.Text = lector["ID"].ToString();
                    txtNom.Text = lector["NOMBRE"].ToString();
                    txtApe.Text = lector["APELLIDO"].ToString();
                    comboTipo.SelectedItem = lector["PUESTO"].ToString();
                }
                conexion.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtApe.Text!="")
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    string nom = txtNom.Text;
                    string ape = txtApe.Text;
                    string puesto = comboTipo.SelectedItem.ToString();

                    SqlCommand comando = new SqlCommand("UPDATE EMPLEADOS SET NOMBRE='"+nom+"', APELLIDO" +
                        "='"+ape+"', PUESTO='"+puesto+ "' WHERE ID=" + miembro, conexion);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    this.Close();
                }
                catch (Exception e1)
                {
                    transaccion.Rollback();
                    MessageBox.Show(e1.Message);
                }
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
