
namespace FormularioEventos
{
    partial class Catalogo
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBorrarPlato = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlatillo = new System.Windows.Forms.TextBox();
            this.Guarniciones = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBorrarGuar = new System.Windows.Forms.Button();
            this.btnAgregarGuar = new System.Windows.Forms.Button();
            this.txtGuarnicion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Postres = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBorrarPostre = new System.Windows.Forms.Button();
            this.btnAgregarPostre = new System.Windows.Forms.Button();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Guarniciones.SuspendLayout();
            this.Postres.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrarPlato);
            this.groupBox1.Controls.Add(this.btnAgregarPlato);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlatillo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platillos";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(688, 8);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(116, 31);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBorrarPlato
            // 
            this.btnBorrarPlato.Location = new System.Drawing.Point(187, 88);
            this.btnBorrarPlato.Name = "btnBorrarPlato";
            this.btnBorrarPlato.Size = new System.Drawing.Size(102, 28);
            this.btnBorrarPlato.TabIndex = 4;
            this.btnBorrarPlato.Text = "Borrar";
            this.btnBorrarPlato.UseVisualStyleBackColor = true;
            this.btnBorrarPlato.Click += new System.EventHandler(this.btnBorrarPlato_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Location = new System.Drawing.Point(187, 26);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(102, 28);
            this.btnAgregarPlato.TabIndex = 3;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(327, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 129);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 210;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Platillo";
            // 
            // txtPlatillo
            // 
            this.txtPlatillo.Location = new System.Drawing.Point(32, 68);
            this.txtPlatillo.Name = "txtPlatillo";
            this.txtPlatillo.Size = new System.Drawing.Size(120, 26);
            this.txtPlatillo.TabIndex = 0;
            // 
            // Guarniciones
            // 
            this.Guarniciones.Controls.Add(this.listView2);
            this.Guarniciones.Controls.Add(this.btnBorrarGuar);
            this.Guarniciones.Controls.Add(this.btnAgregarGuar);
            this.Guarniciones.Controls.Add(this.txtGuarnicion);
            this.Guarniciones.Controls.Add(this.label2);
            this.Guarniciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guarniciones.Location = new System.Drawing.Point(72, 207);
            this.Guarniciones.Name = "Guarniciones";
            this.Guarniciones.Size = new System.Drawing.Size(635, 144);
            this.Guarniciones.TabIndex = 5;
            this.Guarniciones.TabStop = false;
            this.Guarniciones.Text = "Guarniciones";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(327, 20);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(294, 118);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 210;
            // 
            // btnBorrarGuar
            // 
            this.btnBorrarGuar.Location = new System.Drawing.Point(187, 83);
            this.btnBorrarGuar.Name = "btnBorrarGuar";
            this.btnBorrarGuar.Size = new System.Drawing.Size(102, 28);
            this.btnBorrarGuar.TabIndex = 6;
            this.btnBorrarGuar.Text = "Borrar";
            this.btnBorrarGuar.UseVisualStyleBackColor = true;
            this.btnBorrarGuar.Click += new System.EventHandler(this.btnBorrarGuar_Click);
            // 
            // btnAgregarGuar
            // 
            this.btnAgregarGuar.Location = new System.Drawing.Point(187, 21);
            this.btnAgregarGuar.Name = "btnAgregarGuar";
            this.btnAgregarGuar.Size = new System.Drawing.Size(102, 28);
            this.btnAgregarGuar.TabIndex = 5;
            this.btnAgregarGuar.Text = "Agregar";
            this.btnAgregarGuar.UseVisualStyleBackColor = true;
            this.btnAgregarGuar.Click += new System.EventHandler(this.btnAgregarGuar_Click);
            // 
            // txtGuarnicion
            // 
            this.txtGuarnicion.Location = new System.Drawing.Point(32, 79);
            this.txtGuarnicion.Name = "txtGuarnicion";
            this.txtGuarnicion.Size = new System.Drawing.Size(120, 26);
            this.txtGuarnicion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Guarnicion";
            // 
            // Postres
            // 
            this.Postres.Controls.Add(this.listView3);
            this.Postres.Controls.Add(this.btnBorrarPostre);
            this.Postres.Controls.Add(this.btnAgregarPostre);
            this.Postres.Controls.Add(this.txtPostre);
            this.Postres.Controls.Add(this.label3);
            this.Postres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postres.Location = new System.Drawing.Point(72, 357);
            this.Postres.Name = "Postres";
            this.Postres.Size = new System.Drawing.Size(635, 150);
            this.Postres.TabIndex = 6;
            this.Postres.TabStop = false;
            this.Postres.Text = "Postres";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(327, 21);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(294, 112);
            this.listView3.TabIndex = 7;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 210;
            // 
            // btnBorrarPostre
            // 
            this.btnBorrarPostre.Location = new System.Drawing.Point(187, 90);
            this.btnBorrarPostre.Name = "btnBorrarPostre";
            this.btnBorrarPostre.Size = new System.Drawing.Size(102, 28);
            this.btnBorrarPostre.TabIndex = 8;
            this.btnBorrarPostre.Text = "Borrar";
            this.btnBorrarPostre.UseVisualStyleBackColor = true;
            this.btnBorrarPostre.Click += new System.EventHandler(this.btnBorrarPostre_Click);
            // 
            // btnAgregarPostre
            // 
            this.btnAgregarPostre.Location = new System.Drawing.Point(187, 28);
            this.btnAgregarPostre.Name = "btnAgregarPostre";
            this.btnAgregarPostre.Size = new System.Drawing.Size(102, 28);
            this.btnAgregarPostre.TabIndex = 7;
            this.btnAgregarPostre.Text = "Agregar";
            this.btnAgregarPostre.UseVisualStyleBackColor = true;
            this.btnAgregarPostre.Click += new System.EventHandler(this.btnAgregarPostre_Click);
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(32, 81);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.Size = new System.Drawing.Size(120, 26);
            this.txtPostre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nuevo Postre";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 519);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.Postres);
            this.Controls.Add(this.Guarniciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Guarniciones.ResumeLayout(false);
            this.Guarniciones.PerformLayout();
            this.Postres.ResumeLayout(false);
            this.Postres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlatillo;
        private System.Windows.Forms.GroupBox Guarniciones;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnBorrarGuar;
        private System.Windows.Forms.Button btnAgregarGuar;
        private System.Windows.Forms.TextBox txtGuarnicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Postres;
        private System.Windows.Forms.Button btnBorrarPostre;
        private System.Windows.Forms.Button btnAgregarPostre;
        private System.Windows.Forms.TextBox txtPostre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReport;
    }
}