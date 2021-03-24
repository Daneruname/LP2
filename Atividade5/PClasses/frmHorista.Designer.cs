namespace PClasses
{
    partial class frmHorista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblNumHoras = new System.Windows.Forms.Label();
            this.lblDataEntrEmpres = new System.Windows.Forms.Label();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalHora = new System.Windows.Forms.TextBox();
            this.txtNumHora = new System.Windows.Forms.TextBox();
            this.txtDataEntrEmpresa = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(114, 45);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(75, 19);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(139, 93);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(70, 137);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(119, 19);
            this.lblSalarioHora.TabIndex = 2;
            this.lblSalarioHora.Text = "Salário por Hora";
            // 
            // lblNumHoras
            // 
            this.lblNumHoras.AutoSize = true;
            this.lblNumHoras.Location = new System.Drawing.Point(70, 186);
            this.lblNumHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumHoras.Name = "lblNumHoras";
            this.lblNumHoras.Size = new System.Drawing.Size(128, 19);
            this.lblNumHoras.TabIndex = 3;
            this.lblNumHoras.Text = "Número de Horas";
            // 
            // lblDataEntrEmpres
            // 
            this.lblDataEntrEmpres.AutoSize = true;
            this.lblDataEntrEmpres.Location = new System.Drawing.Point(38, 227);
            this.lblDataEntrEmpres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrEmpres.Name = "lblDataEntrEmpres";
            this.lblDataEntrEmpres.Size = new System.Drawing.Size(160, 19);
            this.lblDataEntrEmpres.TabIndex = 4;
            this.lblDataEntrEmpres.Text = "Data Entrada Empresa";
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Location = new System.Drawing.Point(103, 271);
            this.lblDiasFalta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(95, 19);
            this.lblDiasFalta.TabIndex = 5;
            this.lblDiasFalta.Text = "Dias de Falta";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(206, 42);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(210, 27);
            this.txtMatricula.TabIndex = 6;
            this.txtMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(206, 90);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 27);
            this.txtNome.TabIndex = 7;
            // 
            // txtSalHora
            // 
            this.txtSalHora.Location = new System.Drawing.Point(206, 134);
            this.txtSalHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalHora.Name = "txtSalHora";
            this.txtSalHora.Size = new System.Drawing.Size(210, 27);
            this.txtSalHora.TabIndex = 8;
            // 
            // txtNumHora
            // 
            this.txtNumHora.Location = new System.Drawing.Point(206, 183);
            this.txtNumHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumHora.Name = "txtNumHora";
            this.txtNumHora.Size = new System.Drawing.Size(210, 27);
            this.txtNumHora.TabIndex = 9;
            // 
            // txtDataEntrEmpresa
            // 
            this.txtDataEntrEmpresa.Location = new System.Drawing.Point(206, 224);
            this.txtDataEntrEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataEntrEmpresa.Name = "txtDataEntrEmpresa";
            this.txtDataEntrEmpresa.Size = new System.Drawing.Size(210, 27);
            this.txtDataEntrEmpresa.TabIndex = 10;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(206, 268);
            this.txtDiasFalta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(210, 27);
            this.txtDiasFalta.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 87);
            this.button1.TabIndex = 12;
            this.button1.Text = "Instanciar Horas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(751, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtDataEntrEmpresa);
            this.Controls.Add(this.txtNumHora);
            this.Controls.Add(this.txtSalHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.lblDataEntrEmpres);
            this.Controls.Add(this.lblNumHoras);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblNumHoras;
        private System.Windows.Forms.Label lblDataEntrEmpres;
        private System.Windows.Forms.Label lblDiasFalta;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalHora;
        private System.Windows.Forms.TextBox txtNumHora;
        private System.Windows.Forms.TextBox txtDataEntrEmpresa;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Button button1;
    }
}