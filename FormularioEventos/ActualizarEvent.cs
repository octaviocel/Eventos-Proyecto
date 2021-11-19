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
    public partial class ActualizarEvent : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;
        String miembro;
        public ActualizarEvent(String id)
        {
            InitializeComponent();
            miembro = id;
        }

        private void ActualizarEvent_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_EVENTOSDataSet.POSTRES' Puede moverla o quitarla según sea necesario.
            this.pOSTRESTableAdapter.Fill(this.bD_EVENTOSDataSet.POSTRES);
            // TODO: esta línea de código carga datos en la tabla 'bD_EVENTOSDataSet.GUARNICIONES' Puede moverla o quitarla según sea necesario.
            this.gUARNICIONESTableAdapter.Fill(this.bD_EVENTOSDataSet.GUARNICIONES);
            // TODO: esta línea de código carga datos en la tabla 'bD_EVENTOSDataSet.PLATILLOS' Puede moverla o quitarla según sea necesario.
            this.pLATILLOSTableAdapter.Fill(this.bD_EVENTOSDataSet.PLATILLOS);
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM EVENTO WHERE NOEVENTO='"+miembro+"' ", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txtxEvent.Text = lector["NOEVENTO"].ToString();
                    txtInivtados.Text = lector["INVITADOS"].ToString();
                    comoTipo.SelectedItem = lector["TIPOEVENTO"].ToString();
                    comboplatillo.SelectedValue = lector["IDPLATILLO"].ToString();
                    comboGuarni.SelectedValue = lector["IDGUARNICION"].ToString();
                    comboPostre.SelectedValue = lector["IDPOSTRE"].ToString();
                    txtCosto.Text = "$" + lector["COSTOEVENTO"].ToString();
                }
                conexion.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private Boolean isLargo(int i)
        {
            return i >= 50;
        }

        private Double setPrecio(int i)
        {
            if (isLargo(i))
            {
                return  50 * i;
            }
            else
            {
                return 25 * i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInivtados.Text!="")
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    int invi = Convert.ToInt32(txtInivtados.Text);
                    int pla = Convert.ToInt32(comboplatillo.SelectedValue.ToString());
                    int guar = Convert.ToInt32(comboGuarni.SelectedValue.ToString());
                    int pos = Convert.ToInt32(comboPostre.SelectedValue.ToString());
                    string eve = comoTipo.SelectedItem.ToString();
                    Decimal precio = (decimal)setPrecio(invi);

                    SqlCommand comando = new SqlCommand("UPDATE EVENTO SET INVITADOS=" + invi + ", TIPOEVENTO" +
                        "='" + eve + "', IDPLATILLO=" + pla + ",IDGUARNICION=" + guar + ", " +
                        "IDPOSTRE=" + pos + ", COSTOEVENTO=" + precio + " WHERE NOEVENTO='" + miembro + "'", conexion);
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

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInivtados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
