
namespace FormularioEventos
{
    partial class AgregarEvento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboPostre = new System.Windows.Forms.ComboBox();
            this.comboGuar1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckedListBox();
            this.comboPlatillo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvitados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEvento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnAgregarEvento);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtInvitados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboEvento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEvento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarEvento.FlatAppearance.BorderSize = 0;
            this.btnAgregarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEvento.Location = new System.Drawing.Point(290, 359);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(138, 39);
            this.btnAgregarEvento.TabIndex = 7;
            this.btnAgregarEvento.Text = "Registar Evento";
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboPostre);
            this.groupBox2.Controls.Add(this.comboGuar1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox);
            this.groupBox2.Controls.Add(this.comboPlatillo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(30, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Elija las bebidas a usar";
            // 
            // comboPostre
            // 
            this.comboPostre.FormattingEnabled = true;
            this.comboPostre.Items.AddRange(new object[] {
            "Helado",
            "Platanos fritos",
            "Duraznos en almibar"});
            this.comboPostre.Location = new System.Drawing.Point(137, 141);
            this.comboPostre.Name = "comboPostre";
            this.comboPostre.Size = new System.Drawing.Size(247, 32);
            this.comboPostre.TabIndex = 15;
            // 
            // comboGuar1
            // 
            this.comboGuar1.FormattingEnabled = true;
            this.comboGuar1.Items.AddRange(new object[] {
            "Ensalada",
            "Crema Elote",
            "Sopa fria"});
            this.comboGuar1.Location = new System.Drawing.Point(137, 85);
            this.comboGuar1.Name = "comboGuar1";
            this.comboGuar1.Size = new System.Drawing.Size(247, 32);
            this.comboGuar1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Postre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Guarnición 1:";
            // 
            // checkBox
            // 
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.FormattingEnabled = true;
            this.checkBox.Items.AddRange(new object[] {
            "Agua Sabores",
            "Refresco",
            "Vino Tinto",
            "Mezcal",
            "Tequila",
            "Cafe",
            "Sangrias y ponches"});
            this.checkBox.Location = new System.Drawing.Point(462, 46);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(174, 140);
            this.checkBox.TabIndex = 9;
            // 
            // comboPlatillo
            // 
            this.comboPlatillo.FormattingEnabled = true;
            this.comboPlatillo.Items.AddRange(new object[] {
            "Mole",
            "Estofado",
            "Cabrito"});
            this.comboPlatillo.Location = new System.Drawing.Point(137, 36);
            this.comboPlatillo.Name = "comboPlatillo";
            this.comboPlatillo.Size = new System.Drawing.Size(247, 32);
            this.comboPlatillo.TabIndex = 7;
            this.comboPlatillo.SelectedIndexChanged += new System.EventHandler(this.comboPlatillo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Platillo Principal:";
            // 
            // txtInvitados
            // 
            this.txtInvitados.Location = new System.Drawing.Point(606, 66);
            this.txtInvitados.Name = "txtInvitados";
            this.txtInvitados.Size = new System.Drawing.Size(78, 29);
            this.txtInvitados.TabIndex = 5;
            this.txtInvitados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvitados_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Invitados:";
            // 
            // comboEvento
            // 
            this.comboEvento.FormattingEnabled = true;
            this.comboEvento.Items.AddRange(new object[] {
            "BODA",
            "BAUTIZO",
            "CUMPLEAÑOS",
            "XV AÑOS",
            "REUNION ",
            "OTROS"});
            this.comboEvento.Location = new System.Drawing.Point(340, 63);
            this.comboEvento.Name = "comboEvento";
            this.comboEvento.Size = new System.Drawing.Size(156, 32);
            this.comboEvento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Evento:";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(119, 63);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(100, 29);
            this.txtEvento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Evento:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarEvento";
            this.Text = "AgregarEvento";
            this.Load += new System.EventHandler(this.AgregarEvento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvitados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPlatillo;
        private System.Windows.Forms.CheckedListBox checkBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboPostre;
        private System.Windows.Forms.ComboBox comboGuar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}