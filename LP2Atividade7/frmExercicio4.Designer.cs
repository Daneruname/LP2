
namespace PAtividade7
{
    partial class frmExercicio4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(361, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(161, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(470, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(360, 85);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(56, 20);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricao.Location = new System.Drawing.Point(319, 150);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(159, 20);
            this.lblInscricao.TabIndex = 3;
            this.lblInscricao.Text = "Número de Inscrição:";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducao.Location = new System.Drawing.Point(354, 220);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(81, 20);
            this.lblProducao.TabIndex = 4;
            this.lblProducao.Text = "Produção:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(361, 283);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(62, 20);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário:";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratificacao.Location = new System.Drawing.Point(343, 342);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(99, 20);
            this.lblGratificacao.TabIndex = 6;
            this.lblGratificacao.Text = "Gratificação:";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(343, 406);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(105, 20);
            this.lblSalBruto.TabIndex = 7;
            this.lblSalBruto.Text = "Salário Bruto:";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricao.Location = new System.Drawing.Point(161, 180);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(470, 26);
            this.txtInscricao.TabIndex = 8;
            this.txtInscricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtProducao
            // 
            this.txtProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducao.Location = new System.Drawing.Point(161, 250);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(470, 26);
            this.txtProducao.TabIndex = 9;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(160, 113);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(470, 26);
            this.txtCargo.TabIndex = 10;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(161, 307);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(470, 26);
            this.txtSalario.TabIndex = 11;
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGratificacao.Location = new System.Drawing.Point(161, 370);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(470, 26);
            this.txtGratificacao.TabIndex = 12;
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Enabled = false;
            this.txtSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalBruto.Location = new System.Drawing.Point(161, 431);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(469, 26);
            this.txtSalBruto.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(259, 478);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(266, 39);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.Button btnCalcular;
    }
}