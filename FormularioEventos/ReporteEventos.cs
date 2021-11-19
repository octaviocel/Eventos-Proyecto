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
    public partial class ReporteEventos : Form
    {
        public ReporteEventos()
        {
            InitializeComponent();
        }

        private void ReporteEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_EVENTOSDataSet1.getEvent' Puede moverla o quitarla según sea necesario.
            this.getEventTableAdapter.Fill(this.BD_EVENTOSDataSet1.getEvent);

            this.reportViewer1.RefreshReport();
        }
    }
}
