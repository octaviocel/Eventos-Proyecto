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
    public partial class Empleados : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;

        public Empleados()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            AbrirFormEnPanel(new AgregarEmpleados());
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

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    if (comboEmpleado.SelectedIndex == 0)
                    {
                        Waitstaff me = new Waitstaff(Convert.ToInt32(txtIdEmpleado.Text), txtApellidoEmpleado.Text, txtNombreEmpleado.Text);
                        SqlCommand comando = new SqlCommand("INSERT INTO EMPLEADOS(ID, NOMBRE, APELLIDO, PUESTO, TARIFA) " +
                        "values (@p1,@p2,@p3,@p4,@p5);", conexion);
                        comando.Parameters.Add("@p1", SqlDbType.Int).Value = me.getIdentificador();
                        comando.Parameters.Add("@p2", SqlDbType.VarChar).Value = me.getNombre();
                        comando.Parameters.Add("@p3", SqlDbType.VarChar).Value = me.getApellido();
                        comando.Parameters.Add("@p4", SqlDbType.VarChar).Value = me.getPuesto();
                        comando.Parameters.Add("@p5", SqlDbType.VarChar).Value = me.getTarifa();

                        comando.Transaction = transaccion;
                        comando.ExecuteNonQuery();
                    }
                    if (comboEmpleado.SelectedIndex == 1)
                    {
                        Bartender ba = new Bartender(Convert.ToInt32(txtIdEmpleado.Text), txtApellidoEmpleado.Text, txtNombreEmpleado.Text);
                        SqlCommand comando = new SqlCommand("INSERT INTO EMPLEADOS(ID, NOMBRE, APELLIDO, PUESTO, TARIFA) " +
                        "values (@p1,@p2,@p3,@p4,@p5);", conexion);
                        comando.Parameters.Add("@p1", SqlDbType.Int).Value = ba.getIdentificador();
                        comando.Parameters.Add("@p2", SqlDbType.VarChar).Value = ba.getNombre();
                        comando.Parameters.Add("@p3", SqlDbType.VarChar).Value = ba.getApellido();
                        comando.Parameters.Add("@p4", SqlDbType.VarChar).Value = ba.getPuesto();
                        comando.Parameters.Add("@p5", SqlDbType.VarChar).Value = ba.getTarifa();

                        comando.Transaction = transaccion;
                        comando.ExecuteNonQuery();
                    }
                    if (comboEmpleado.SelectedIndex == 2)
                    {
                        Coordinator co = new Coordinator(Convert.ToInt32(txtIdEmpleado.Text), txtApellidoEmpleado.Text, txtNombreEmpleado.Text);
                        SqlCommand comando = new SqlCommand("INSERT INTO EMPLEADOS(ID, NOMBRE, APELLIDO, PUESTO, TARIFA) " +
                        "values (@p1,@p2,@p3,@p4,@p5);", conexion);
                        comando.Parameters.Add("@p1", SqlDbType.Int).Value = co.getIdentificador();
                        comando.Parameters.Add("@p2", SqlDbType.VarChar).Value = co.getNombre();
                        comando.Parameters.Add("@p3", SqlDbType.VarChar).Value = co.getApellido();
                        comando.Parameters.Add("@p4", SqlDbType.VarChar).Value = co.getPuesto();
                        comando.Parameters.Add("@p5", SqlDbType.Decimal).Value = co.getTarifa();

                        comando.Transaction = transaccion;
                        comando.ExecuteNonQuery();
                    }                    

                    transaccion.Commit();
                    conexion.Close();
                    cleanControlEmpleado();
                    MessageBox.Show("Se ha registrado correctamente el Empleado");
                }
                catch (Exception e1)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error\n" + e1.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Por favor rellena los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                desvalidar();
            }
        }

        private bool validar()
        {
            bool bandera = true;
            if (txtIdEmpleado.Text == "")
            {
                errorProvider1.SetError(txtIdEmpleado, "Ingresa el numero de evento");
                bandera = false;
            }
            if (txtNombreEmpleado.Text == "")
            {
                errorProvider1.SetError(txtNombreEmpleado, "*");
                bandera = false;
            }
            if (txtApellidoEmpleado.Text == "")
            {
                errorProvider1.SetError(txtApellidoEmpleado, "*");
                bandera = false;
            }
            if (comboEmpleado.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboEmpleado, "*");
                bandera = false;
            }
           
            return bandera;
        }

        public void desvalidar()
        {
            //errorProvider1.SetError(txtEvento, "");
            errorProvider1.Clear();
        }

        private void cleanControlEmpleado()
        {
            txtNombreEmpleado.Clear();
            txtIdEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            comboEmpleado.SelectedIndex = -1;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
