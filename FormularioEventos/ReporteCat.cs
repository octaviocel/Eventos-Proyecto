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
    public partial class ReporteCat : Form
    {
        public ReporteCat()
        {
            InitializeComponent();
        }

        private void ReporteCat_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_EVENTOSDataSet.PLATILLOS' Puede moverla o quitarla según sea necesario.
            this.PLATILLOSTableAdapter.Fill(this.BD_EVENTOSDataSet.PLATILLOS);
            // TODO: esta línea de código carga datos en la tabla 'BD_EVENTOSDataSet.GUARNICIONES' Puede moverla o quitarla según sea necesario.
            this.GUARNICIONESTableAdapter.Fill(this.BD_EVENTOSDataSet.GUARNICIONES);
            // TODO: esta línea de código carga datos en la tabla 'BD_EVENTOSDataSet.POSTRES' Puede moverla o quitarla según sea necesario.
            this.POSTRESTableAdapter.Fill(this.BD_EVENTOSDataSet.POSTRES);

            this.reportViewer1.RefreshReport();
        }
    }
}
