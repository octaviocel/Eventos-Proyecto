
namespace FormularioEventos
{
    partial class ReporteEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsdetalle = new FormularioEventos.dsdetalle();
            this.EMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMPLEADOSTableAdapter = new FormularioEventos.dsdetalleTableAdapters.EMPLEADOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EMPLEADOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioEventos.RepEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsdetalle
            // 
            this.dsdetalle.DataSetName = "dsdetalle";
            this.dsdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EMPLEADOSBindingSource
            // 
            this.EMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.EMPLEADOSBindingSource.DataSource = this.dsdetalle;
            // 
            // EMPLEADOSTableAdapter
            // 
            this.EMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEmpleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EMPLEADOSBindingSource;
        private dsdetalle dsdetalle;
        private dsdetalleTableAdapters.EMPLEADOSTableAdapter EMPLEADOSTableAdapter;
    }
}