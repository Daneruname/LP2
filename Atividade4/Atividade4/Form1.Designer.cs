namespace Atividade4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsalBruto = new System.Windows.Forms.Label();
            this.lblnumFilho = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIR = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.cbxNumFilhos = new System.Windows.Forms.ComboBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIR = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIR = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoIR = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(36, 36);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(145, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome do Funcionário";
            // 
            // lblsalBruto
            // 
            this.lblsalBruto.AutoSize = true;
            this.lblsalBruto.Location = new System.Drawing.Point(36, 76);
            this.lblsalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsalBruto.Name = "lblsalBruto";
            this.lblsalBruto.Size = new System.Drawing.Size(92, 16);
            this.lblsalBruto.TabIndex = 1;
            this.lblsalBruto.Text = "Salário Bruto";
            // 
            // lblnumFilho
            // 
            this.lblnumFilho.AutoSize = true;
            this.lblnumFilho.Location = new System.Drawing.Point(36, 121);
            this.lblnumFilho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumFilho.Name = "lblnumFilho";
            this.lblnumFilho.Size = new System.Drawing.Size(117, 16);
            this.lblnumFilho.TabIndex = 2;
            this.lblnumFilho.Text = "Número de filhos";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(185, 33);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(193, 23);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(152, 300);
            this.txtAliquotaINSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(193, 23);
            this.txtAliquotaINSS.TabIndex = 4;
            // 
            // txtAliquotaIR
            // 
            this.txtAliquotaIR.Enabled = false;
            this.txtAliquotaIR.Location = new System.Drawing.Point(152, 337);
            this.txtAliquotaIR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAliquotaIR.Name = "txtAliquotaIR";
            this.txtAliquotaIR.Size = new System.Drawing.Size(193, 23);
            this.txtAliquotaIR.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(151, 163);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(263, 91);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar Descontos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(185, 73);
            this.mskbxSalBruto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskbxSalBruto.Mask = "000000.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(186, 23);
            this.mskbxSalBruto.TabIndex = 7;
            // 
            // cbxNumFilhos
            // 
            this.cbxNumFilhos.FormattingEnabled = true;
            this.cbxNumFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNumFilhos.Location = new System.Drawing.Point(185, 113);
            this.cbxNumFilhos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNumFilhos.Name = "cbxNumFilhos";
            this.cbxNumFilhos.Size = new System.Drawing.Size(186, 24);
            this.cbxNumFilhos.TabIndex = 8;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(36, 270);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(41, 13);
            this.lblMensagem.TabIndex = 9;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.Visible = false;
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(36, 307);
            this.lblAliquotaINSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(98, 16);
            this.lblAliquotaINSS.TabIndex = 10;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotaIR
            // 
            this.lblAliquotaIR.AutoSize = true;
            this.lblAliquotaIR.Location = new System.Drawing.Point(36, 347);
            this.lblAliquotaIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAliquotaIR.Name = "lblAliquotaIR";
            this.lblAliquotaIR.Size = new System.Drawing.Size(79, 16);
            this.lblAliquotaIR.TabIndex = 11;
            this.lblAliquotaIR.Text = "Aliquota IR";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(36, 387);
            this.lblSalFamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(100, 16);
            this.lblSalFamilia.TabIndex = 12;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(398, 304);
            this.lblDescontoINSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(107, 16);
            this.lblDescontoINSS.TabIndex = 13;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIR
            // 
            this.lblDescontoIR.AutoSize = true;
            this.lblDescontoIR.Location = new System.Drawing.Point(398, 347);
            this.lblDescontoIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoIR.Name = "lblDescontoIR";
            this.lblDescontoIR.Size = new System.Drawing.Size(88, 16);
            this.lblDescontoIR.TabIndex = 14;
            this.lblDescontoIR.Text = "Desconto IR";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(36, 423);
            this.lblSalLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(102, 16);
            this.lblSalLiquido.TabIndex = 15;
            this.lblSalLiquido.Text = "Salario Líquido";
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(509, 297);
            this.txtDescontoINSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(170, 23);
            this.txtDescontoINSS.TabIndex = 16;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(151, 380);
            this.txtSalFamilia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(194, 23);
            this.txtSalFamilia.TabIndex = 17;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Location = new System.Drawing.Point(151, 420);
            this.txtSalLiquido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(194, 23);
            this.txtSalLiquido.TabIndex = 18;
            // 
            // txtDescontoIR
            // 
            this.txtDescontoIR.Enabled = false;
            this.txtDescontoIR.Location = new System.Drawing.Point(509, 344);
            this.txtDescontoIR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescontoIR.Name = "txtDescontoIR";
            this.txtDescontoIR.Size = new System.Drawing.Size(170, 23);
            this.txtDescontoIR.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFem);
            this.groupBox1.Controls.Add(this.rbtnMasc);
            this.groupBox1.Location = new System.Drawing.Point(558, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 88);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Checked = true;
            this.rbtnMasc.Location = new System.Drawing.Point(12, 30);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(90, 20);
            this.rbtnMasc.TabIndex = 0;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(12, 55);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(83, 20);
            this.rbtnFem.TabIndex = 1;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(570, 163);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(75, 20);
            this.ckbxCasado.TabIndex = 21;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(514, 424);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 24);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(663, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 25);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 460);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescontoIR);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblDescontoIR);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliquotaIR);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.cbxNumFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtAliquotaIR);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblnumFilho);
            this.Controls.Add(this.lblsalBruto);
            this.Controls.Add(this.lblnome);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsalBruto;
        private System.Windows.Forms.Label lblnumFilho;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIR;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.ComboBox cbxNumFilhos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIR;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIR;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtDescontoIR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

