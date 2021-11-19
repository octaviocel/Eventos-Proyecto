
namespace FormularioEventos
{
    partial class ReporteEventos
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
            this.BD_EVENTOSDataSet1 = new FormularioEventos.BD_EVENTOSDataSet1();
            this.getEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEventTableAdapter = new FormularioEventos.BD_EVENTOSDataSet1TableAdapters.getEventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_EVENTOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getEventBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioEventos.reporteEventos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(834, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_EVENTOSDataSet1
            // 
            this.BD_EVENTOSDataSet1.DataSetName = "BD_EVENTOSDataSet1";
            this.BD_EVENTOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEventBindingSource
            // 
            this.getEventBindingSource.DataMember = "getEvent";
            this.getEventBindingSource.DataSource = this.BD_EVENTOSDataSet1;
            // 
            // getEventTableAdapter
            // 
            this.getEventTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReporteEventos";
            this.Load += new System.EventHandler(this.ReporteEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_EVENTOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getEventBindingSource;
        private BD_EVENTOSDataSet1 BD_EVENTOSDataSet1;
        private BD_EVENTOSDataSet1TableAdapters.getEventTableAdapter getEventTableAdapter;
    }
}