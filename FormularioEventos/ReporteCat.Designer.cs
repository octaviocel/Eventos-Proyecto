
namespace FormularioEventos
{
    partial class ReporteCat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_EVENTOSDataSet = new FormularioEventos.BD_EVENTOSDataSet();
            this.PLATILLOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PLATILLOSTableAdapter = new FormularioEventos.BD_EVENTOSDataSetTableAdapters.PLATILLOSTableAdapter();
            this.GUARNICIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GUARNICIONESTableAdapter = new FormularioEventos.BD_EVENTOSDataSetTableAdapters.GUARNICIONESTableAdapter();
            this.POSTRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POSTRESTableAdapter = new FormularioEventos.BD_EVENTOSDataSetTableAdapters.POSTRESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_EVENTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLATILLOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUARNICIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSTRESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.PLATILLOSBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.GUARNICIONESBindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.POSTRESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioEventos.reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_EVENTOSDataSet
            // 
            this.BD_EVENTOSDataSet.DataSetName = "BD_EVENTOSDataSet";
            this.BD_EVENTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PLATILLOSBindingSource
            // 
            this.PLATILLOSBindingSource.DataMember = "PLATILLOS";
            this.PLATILLOSBindingSource.DataSource = this.BD_EVENTOSDataSet;
            // 
            // PLATILLOSTableAdapter
            // 
            this.PLATILLOSTableAdapter.ClearBeforeFill = true;
            // 
            // GUARNICIONESBindingSource
            // 
            this.GUARNICIONESBindingSource.DataMember = "GUARNICIONES";
            this.GUARNICIONESBindingSource.DataSource = this.BD_EVENTOSDataSet;
            // 
            // GUARNICIONESTableAdapter
            // 
            this.GUARNICIONESTableAdapter.ClearBeforeFill = true;
            // 
            // POSTRESBindingSource
            // 
            this.POSTRESBindingSource.DataMember = "POSTRES";
            this.POSTRESBindingSource.DataSource = this.BD_EVENTOSDataSet;
            // 
            // POSTRESTableAdapter
            // 
            this.POSTRESTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReporteCat";
            this.Load += new System.EventHandler(this.ReporteCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_EVENTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLATILLOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GUARNICIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSTRESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PLATILLOSBindingSource;
        private BD_EVENTOSDataSet BD_EVENTOSDataSet;
        private System.Windows.Forms.BindingSource GUARNICIONESBindingSource;
        private System.Windows.Forms.BindingSource POSTRESBindingSource;
        private BD_EVENTOSDataSetTableAdapters.PLATILLOSTableAdapter PLATILLOSTableAdapter;
        private BD_EVENTOSDataSetTableAdapters.GUARNICIONESTableAdapter GUARNICIONESTableAdapter;
        private BD_EVENTOSDataSetTableAdapters.POSTRESTableAdapter POSTRESTableAdapter;
    }
}