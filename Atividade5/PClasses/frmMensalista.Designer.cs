namespace PClasses
{
    partial class frmMensalista
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
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDataEntEmpr = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntrEmpr = new System.Windows.Forms.TextBox();
            this.btnInstMensal = new System.Windows.Forms.Button();
            this.btnInst2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(123, 42);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(75, 19);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(148, 102);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(89, 158);
            this.lblSalarioMensal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(109, 19);
            this.lblSalarioMensal.TabIndex = 2;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // lblDataEntEmpr
            // 
            this.lblDataEntEmpr.AutoSize = true;
            this.lblDataEntEmpr.Location = new System.Drawing.Point(18, 219);
            this.lblDataEntEmpr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntEmpr.Name = "lblDataEntEmpr";
            this.lblDataEntEmpr.Size = new System.Drawing.Size(180, 19);
            this.lblDataEntEmpr.TabIndex = 3;
            this.lblDataEntEmpr.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(206, 42);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(210, 27);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(206, 99);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 27);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(206, 158);
            this.txtSalarioMensal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(210, 27);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEntrEmpr
            // 
            this.txtDataEntrEmpr.Location = new System.Drawing.Point(206, 216);
            this.txtDataEntrEmpr.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrEmpr.Name = "txtDataEntrEmpr";
            this.txtDataEntrEmpr.Size = new System.Drawing.Size(210, 27);
            this.txtDataEntrEmpr.TabIndex = 7;
            // 
            // btnInstMensal
            // 
            this.btnInstMensal.Location = new System.Drawing.Point(517, 42);
            this.btnInstMensal.Name = "btnInstMensal";
            this.btnInstMensal.Size = new System.Drawing.Size(143, 87);
            this.btnInstMensal.TabIndex = 8;
            this.btnInstMensal.Text = "Instanciar Mensalista";
            this.btnInstMensal.UseVisualStyleBackColor = true;
            this.btnInstMensal.Click += new System.EventHandler(this.btnInstMensal_Click);
            // 
            // btnInst2
            // 
            this.btnInst2.Location = new System.Drawing.Point(517, 176);
            this.btnInst2.Name = "btnInst2";
            this.btnInst2.Size = new System.Drawing.Size(143, 85);
            this.btnInst2.TabIndex = 9;
            this.btnInst2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInst2.UseVisualStyleBackColor = true;
            this.btnInst2.Click += new System.EventHandler(this.btnInst2_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(751, 333);
            this.Controls.Add(this.btnInst2);
            this.Controls.Add(this.btnInstMensal);
            this.Controls.Add(this.txtDataEntrEmpr);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntEmpr);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDataEntEmpr;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntrEmpr;
        private System.Windows.Forms.Button btnInstMensal;
        private System.Windows.Forms.Button btnInst2;
    }
}