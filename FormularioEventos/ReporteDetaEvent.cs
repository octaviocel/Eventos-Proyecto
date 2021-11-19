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
    public partial class ReporteDetaEvent : Form
    {
        public ReporteDetaEvent()
        {
            InitializeComponent();
        }

        private void ReporteDetaEvent_Load(object sender, EventArgs e)
        {
            this.dsdetalle.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'dsdetalle.DataFucionDatalle' Puede moverla o quitarla según sea necesario.
            this.DataFucionDatalleTableAdapter.Fill(this.dsdetalle.DataFucionDatalle);

            this.reportViewer1.RefreshReport();
        }
    }
}
