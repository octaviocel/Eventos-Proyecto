
namespace FormularioEventos
{
    partial class ActualizarEvent
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxEvent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInivtados = new System.Windows.Forms.TextBox();
            this.comoTipo = new System.Windows.Forms.ComboBox();
            this.comboplatillo = new System.Windows.Forms.ComboBox();
            this.pLATILLOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_EVENTOSDataSet = new FormularioEventos.BD_EVENTOSDataSet();
            this.comboGuarni = new System.Windows.Forms.ComboBox();
            this.gUARNICIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboPostre = new System.Windows.Forms.ComboBox();
            this.pOSTRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDEVENTOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLATILLOSTableAdapter = new FormularioEventos.BD_EVENTOSDataSetTableAdapters.PLATILLOSTableAdapter();
            this.gUARNICIONESTableAdapter = new FormularioEventos.BD_EVENTOSDataSetTableAdapters.GUARNICIONESTableAdapter();
            this.pOSTRESTableAdapter = new FormularioEventos.BD_EVENTOSDataSetTableAdapters.POSTRESTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pLATILLOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_EVENTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARNICIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTRESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEVENTOSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Indivisa Text Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Indivisa Text Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Evento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Indivisa Text Sans Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Invitados:";
            // 
            // txtxEvent
            // 
            this.txtxEvent.AutoSize = true;
            this.txtxEvent.Font = new System.Drawing.Font("Indivisa Text Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxEvent.Location = new System.Drawing.Point(277, 26);
            this.txtxEvent.Name = "txtxEvent";
            this.txtxEvent.Size = new System.Drawing.Size(0, 29);
            this.txtxEvent.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Indivisa Text Sans Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Platillo del Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Indivisa Text Sans Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guarnición del Evento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Indivisa Text Sans Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Postre del Evento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Indivisa Text Sans Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de Evento:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Indivisa Text Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(263, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInivtados
            // 
            this.txtInivtados.Location = new System.Drawing.Point(234, 76);
            this.txtInivtados.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtInivtados.Name = "txtInivtados";
            this.txtInivtados.Size = new System.Drawing.Size(100, 20);
            this.txtInivtados.TabIndex = 10;
            this.txtInivtados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInivtados_KeyPress);
            // 
            // comoTipo
            // 
            this.comoTipo.FormattingEnabled = true;
            this.comoTipo.Items.AddRange(new object[] {
            "BODA",
            "BAUTIZO",
            "CUMPLEAÑOS",
            "XV AÑOS",
            "REUNION ",
            "OTROS"});
            this.comoTipo.Location = new System.Drawing.Point(222, 123);
            this.comoTipo.Name = "comoTipo";
            this.comoTipo.Size = new System.Drawing.Size(215, 21);
            this.comoTipo.TabIndex = 11;
            // 
            // comboplatillo
            // 
            this.comboplatillo.DataSource = this.pLATILLOSBindingSource;
            this.comboplatillo.DisplayMember = "NOMBREP";
            this.comboplatillo.FormattingEnabled = true;
            this.comboplatillo.Location = new System.Drawing.Point(222, 169);
            this.comboplatillo.Name = "comboplatillo";
            this.comboplatillo.Size = new System.Drawing.Size(215, 21);
            this.comboplatillo.TabIndex = 12;
            this.comboplatillo.ValueMember = "ID";
            // 
            // pLATILLOSBindingSource
            // 
            this.pLATILLOSBindingSource.DataMember = "PLATILLOS";
            this.pLATILLOSBindingSource.DataSource = this.bD_EVENTOSDataSet;
            // 
            // bD_EVENTOSDataSet
            // 
            this.bD_EVENTOSDataSet.DataSetName = "BD_EVENTOSDataSet";
            this.bD_EVENTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboGuarni
            // 
            this.comboGuarni.DataSource = this.gUARNICIONESBindingSource;
            this.comboGuarni.DisplayMember = "NOMBREG";
            this.comboGuarni.FormattingEnabled = true;
            this.comboGuarni.Location = new System.Drawing.Point(222, 216);
            this.comboGuarni.Name = "comboGuarni";
            this.comboGuarni.Size = new System.Drawing.Size(215, 21);
            this.comboGuarni.TabIndex = 13;
            this.comboGuarni.ValueMember = "ID";
            // 
            // gUARNICIONESBindingSource
            // 
            this.gUARNICIONESBindingSource.DataMember = "GUARNICIONES";
            this.gUARNICIONESBindingSource.DataSource = this.bD_EVENTOSDataSet;
            // 
            // comboPostre
            // 
            this.comboPostre.DataSource = this.pOSTRESBindingSource;
            this.comboPostre.DisplayMember = "NOMBREPO";
            this.comboPostre.FormattingEnabled = true;
            this.comboPostre.Location = new System.Drawing.Point(222, 270);
            this.comboPostre.Name = "comboPostre";
            this.comboPostre.Size = new System.Drawing.Size(215, 21);
            this.comboPostre.TabIndex = 14;
            this.comboPostre.ValueMember = "ID";
            // 
            // pOSTRESBindingSource
            // 
            this.pOSTRESBindingSource.DataMember = "POSTRES";
            this.pOSTRESBindingSource.DataSource = this.bDEVENTOSDataSetBindingSource;
            // 
            // bDEVENTOSDataSetBindingSource
            // 
            this.bDEVENTOSDataSetBindingSource.DataSource = this.bD_EVENTOSDataSet;
            this.bDEVENTOSDataSetBindingSource.Position = 0;
            // 
            // pLATILLOSTableAdapter
            // 
            this.pLATILLOSTableAdapter.ClearBeforeFill = true;
            // 
            // gUARNICIONESTableAdapter
            // 
            this.gUARNICIONESTableAdapter.ClearBeforeFill = true;
            // 
            // pOSTRESTableAdapter
            // 
            this.pOSTRESTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Indivisa Text Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Costo de Evento:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.AutoSize = true;
            this.txtCosto.Font = new System.Drawing.Font("Indivisa Text Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(245, 305);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(0, 26);
            this.txtCosto.TabIndex = 16;
            // 
            // ActualizarEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboPostre);
            this.Controls.Add(this.comboGuarni);
            this.Controls.Add(this.comboplatillo);
            this.Controls.Add(this.comoTipo);
            this.Controls.Add(this.txtInivtados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtxEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ActualizarEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActualizarEvent";
            this.Load += new System.EventHandler(this.ActualizarEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLATILLOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_EVENTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARNICIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTRESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEVENTOSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtxEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInivtados;
        private System.Windows.Forms.ComboBox comoTipo;
        private System.Windows.Forms.ComboBox comboplatillo;
        private System.Windows.Forms.ComboBox comboGuarni;
        private System.Windows.Forms.ComboBox comboPostre;
        private BD_EVENTOSDataSet bD_EVENTOSDataSet;
        private System.Windows.Forms.BindingSource pLATILLOSBindingSource;
        private BD_EVENTOSDataSetTableAdapters.PLATILLOSTableAdapter pLATILLOSTableAdapter;
        private System.Windows.Forms.BindingSource gUARNICIONESBindingSource;
        private BD_EVENTOSDataSetTableAdapters.GUARNICIONESTableAdapter gUARNICIONESTableAdapter;
        private System.Windows.Forms.BindingSource bDEVENTOSDataSetBindingSource;
        private System.Windows.Forms.BindingSource pOSTRESBindingSource;
        private BD_EVENTOSDataSetTableAdapters.POSTRESTableAdapter pOSTRESTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtCosto;
    }
}