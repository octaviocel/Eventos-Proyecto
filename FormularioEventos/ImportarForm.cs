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
using SpreadsheetLight;
using System.Data.SqlClient;

namespace FormularioEventos
{
    public partial class ImportarForm : Form
    {
        String cadena = Properties.Settings.Default.BD_EVENTOSConnectionString;
        public ImportarForm()
        {
            InitializeComponent();
        }

        private void ImportarForm_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;


                SLDocument sl = new SLDocument(openFileDialog1.FileName);
                int indiceRow = 2;

                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {

                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(indiceRow, 2)))
                    {
                        /*int principal, int guarnicion1, int guarnicion2, int postre,
                             String nevento, int invitados, int tipoEvent;*/
                        int platillo = sl.GetCellValueAsInt32(indiceRow, 1);
                        int guarni1 = sl.GetCellValueAsInt32(indiceRow, 2);
                        int postre = sl.GetCellValueAsInt32(indiceRow, 3);
                        String nevento = sl.GetCellValueAsString(indiceRow, 4);
                        int inivitados = sl.GetCellValueAsInt32(indiceRow, 5);
                        String tipoEvent = sl.GetCellValueAsString(indiceRow, 6);
                        String bebidas = sl.GetCellValueAsString(indiceRow, 7);

                        SqlCommand comando = new SqlCommand("INSERT INTO EVENTO (NOEVENTO, INVITADOS, COSTOEVENTO, TIPOEVENTO,IDPLATILLO" +
                        ",IDGUARNICION,IDPOSTRE,BEBIDAS)" +
                        "values (@p1, @p2, @p3, @p4, @p5, @p6,@p7, @p8)", conexion);
                        CraerEvent even = new CraerEvent(platillo, guarni1, 0, postre, nevento, inivitados, tipoEvent);
                        comando.Parameters.Add("@p1", SqlDbType.VarChar).Value = even.NoEvento;
                        comando.Parameters.Add("@p2", SqlDbType.Int).Value = even.Invitados;
                        comando.Parameters.Add("@p3", SqlDbType.Decimal).Value = even.Precio;
                        comando.Parameters.Add("@p4", SqlDbType.VarChar).Value = even.TipoEvent;
                        comando.Parameters.Add("@p5", SqlDbType.Int).Value = even.getPrincipal();
                        comando.Parameters.Add("@p6", SqlDbType.Int).Value = even.getGuarnicion1();
                        comando.Parameters.Add("@p7", SqlDbType.Int).Value = even.getPostre();
                        comando.Parameters.Add("@p8", SqlDbType.VarChar).Value = bebidas;

                        comando.Transaction = transaccion;
                        comando.ExecuteNonQuery();

                        indiceRow++;
                    }
                    transaccion.Commit();                
                }catch(Exception e2)
                {
                    //transaccion.Rollback();
                    MessageBox.Show(e2.Message);
                }
                conexion.Close();
                MessageBox.Show("Se cargo correctamente", "Archivo con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "C:\\";
            openFileDialog2.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;

                SLDocument sl = new SLDocument(openFileDialog2.FileName);
                int indiceRow = 2;

                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(indiceRow, 2)))
                    {
                        int id = sl.GetCellValueAsInt32(indiceRow, 1);
                        String nombre = sl.GetCellValueAsString(indiceRow, 2);
                        String apellido = sl.GetCellValueAsString(indiceRow, 3);
                        String puesto = sl.GetCellValueAsString(indiceRow, 4);

                        puesto.Trim();
                        if (puesto.Equals("mesero"))
                        {
                            Waitstaff me = new Waitstaff(id, apellido, nombre);
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
                        else if (puesto.Equals("bartender"))
                        {
                            Bartender ba = new Bartender(id, apellido, nombre);
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
                        else if (puesto.Equals("coordinador"))
                        {
                            Coordinator co = new Coordinator(id, apellido, nombre);
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

                        indiceRow++;
                    }
                    transaccion.Commit();
                    conexion.Close();
                }
                catch(Exception e2)
                {
                    transaccion.Rollback();
                    MessageBox.Show(e2.Message);
                }
                MessageBox.Show("Se cargo correctamente", "Archivo con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
