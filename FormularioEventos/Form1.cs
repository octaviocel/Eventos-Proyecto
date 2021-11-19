using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(Object Formhijo)
        {
            if (this.pnlCentro.Controls.Count > 0)
                this.pnlCentro.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlCentro.Controls.Add(fh);
            fh.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MainMenu());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarEvento());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MostrarEventos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarEmpleados());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ImportarForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Catalogo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void pnlCentro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
