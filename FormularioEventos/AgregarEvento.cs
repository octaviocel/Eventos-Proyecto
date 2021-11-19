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
    public partial class AgregarEvento : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;

        List<CraerEvent> levento = new List<CraerEvent>();
        public AgregarEvento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    SqlCommand comando = new SqlCommand("INSERT INTO EVENTO (NOEVENTO, INVITADOS, COSTOEVENTO, TIPOEVENTO,IDPLATILLO" +
                        ",IDGUARNICION,IDPOSTRE,BEBIDAS)" +
                        "values (@p1, @p2, @p3, @p4, @p5, @p6,@p7, @p8)", conexion);
                    CraerEvent even = new CraerEvent(Convert.ToInt32(comboPlatillo.SelectedValue.ToString()), Convert.ToInt32(comboGuar1.SelectedValue.ToString()), 0, Convert.ToInt32(comboPostre.SelectedValue.ToString())
                                                , txtEvento.Text, Convert.ToInt32(txtInvitados.Text), comboEvento.SelectedItem.ToString());
                    string s = "";
                    if (checkBox.CheckedItems.Count != 0)
                    {
                        for (int x = 0; x < checkBox.CheckedItems.Count; x++)
                        {
                            s = s + checkBox.CheckedItems[x].ToString() + ", ";
                        }
                    }

                    comando.Parameters.Add("@p1", SqlDbType.VarChar).Value = even.NoEvento;
                    comando.Parameters.Add("@p2", SqlDbType.Int).Value = even.Invitados;
                    comando.Parameters.Add("@p3", SqlDbType.Decimal).Value = even.Precio;
                    comando.Parameters.Add("@p4", SqlDbType.VarChar).Value = even.TipoEvent;
                    comando.Parameters.Add("@p5", SqlDbType.Int).Value = even.getPrincipal();
                    comando.Parameters.Add("@p6", SqlDbType.Int).Value = even.getGuarnicion1();
                    comando.Parameters.Add("@p7", SqlDbType.Int).Value = even.getPostre();
                    comando.Parameters.Add("@p8", SqlDbType.VarChar).Value = s;

                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    cleanControlEventos();
                    MessageBox.Show("Se ha registrado correctamente el EVENTO");
                }
                catch (Exception e1)
                {
                    transaccion.Rollback();
                    MessageBox.Show(e1.Message);
                }
            }
            else
            {
                MessageBox.Show("Campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desvalidar();
            }
            
        }
        
        private void cleanControlEventos()
        {
            txtEvento.Clear();
            txtInvitados.Clear();
            comboEvento.SelectedIndex = -1;
            comboGuar1.SelectedIndex = -1;
            comboPlatillo.SelectedIndex = -1;
            comboPostre.SelectedIndex = -1;
            checkBox.ClearSelected();
        }

        private bool validar()
        {
            bool bandera = true;
            if (txtEvento.Text == "")
            {
                errorProvider1.SetError(txtEvento, "Ingresa el numero de evento");
                bandera = false;
            }
            if (txtInvitados.Text == "")
            {
                errorProvider1.SetError(txtInvitados, "*");
                bandera = false;
            }
            if (comboEvento.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboEvento, "*");
                bandera = false;
            }
            if (comboGuar1.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboGuar1, "*");
                bandera = false;
            }
            if (comboPlatillo.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboPlatillo, "*");
                bandera = false;
            }
            if (comboPostre.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboPostre, "*");
                bandera = false;
            }
            if (checkBox.SelectedItems.Count == 0)
            {
                errorProvider1.SetError(checkBox, "*");
                bandera = false;
            }

            return bandera;
        }

        public void desvalidar()
        {
            //errorProvider1.SetError(txtEvento, "");
            errorProvider1.Clear();
        }

        private void AgregarEvento_Load(object sender, EventArgs e)
        {
            agregarPlatillos();
            agregarGuarnicion();
            agregarPostres();
            this.AcceptButton = btnAgregarEvento;
        }

        private void agregarPlatillos()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT ID,NOMBREP FROM PLATILLOS", conexion);
                DataTable tablita = new DataTable("PLATILLOS");
                adaptador.Fill(tablita);

                comboPlatillo.DataSource = tablita;
                comboPlatillo.ValueMember = "ID";
                comboPlatillo.DisplayMember = "NOMBREP";

                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error " + e1.Message);
            }
        }

        private void agregarGuarnicion()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT ID,NOMBREG FROM GUARNICIONES", conexion);
                DataTable tablita = new DataTable("GURANICIONES");
                adaptador.Fill(tablita);

                comboGuar1.DataSource = tablita;
                comboGuar1.ValueMember = "ID";
                comboGuar1.DisplayMember = "NOMBREG";

                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error " + e1.Message);
            }
        }

        private void agregarPostres()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT ID,NOMBREPO FROM POSTRES", conexion);
                DataTable tablita = new DataTable("POSTRES");
                adaptador.Fill(tablita);

                comboPostre.DataSource = tablita;
                comboPostre.ValueMember = "ID";
                comboPostre.DisplayMember = "NOMBREPO";

                conexion.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error " + e1.Message);
            }
        }

        private void txtInvitados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void comboPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
