using FormularioEventos.Clases;
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
    public partial class Login : Form
    {
        private bool banderita = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            //Encriptar encripta = new Encriptar();
            try
            {
                conexion.Open();
                String usuario = txtUser.Text;
                String passwordE = Encriptar.GetMD5(txtPass.Text);
                

                SqlCommand comando = new SqlCommand("SELECT ID, USERS FROM USUARIO" +
                    " WHERE USERS= @usuario and CLAVE = @password", conexion);
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordE;

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    //MessageBox.Show(lector["id"].ToString() + " " + lector["rol"].ToString());
                    MessageBox.Show("Bienvenido " +lector["USERS"].ToString(),"WELCOME",MessageBoxButtons.OK,MessageBoxIcon.None);
                    banderita = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error de User","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                //MessageBox.Show("Conexión Exitosa");
                conexion.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (banderita == false)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSummit;
        }
    }
}
