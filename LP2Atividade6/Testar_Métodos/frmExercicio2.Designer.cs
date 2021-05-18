namespace Testar_Métodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnTestaIguais = new System.Windows.Forms.Button();
            this.btnInserirPrimeiroNoSegundo = new System.Windows.Forms.Button();
            this.btnInserirDoisAsteriscos = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra1.Location = new System.Drawing.Point(210, 130);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(5);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(180, 39);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra2.Location = new System.Drawing.Point(566, 130);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(5);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(180, 39);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnTestaIguais
            // 
            this.btnTestaIguais.Location = new System.Drawing.Point(78, 280);
            this.btnTestaIguais.Margin = new System.Windows.Forms.Padding(5);
            this.btnTestaIguais.Name = "btnTestaIguais";
            this.btnTestaIguais.Size = new System.Drawing.Size(186, 105);
            this.btnTestaIguais.TabIndex = 2;
            this.btnTestaIguais.Text = "Testar Iguais";
            this.btnTestaIguais.UseVisualStyleBackColor = true;
            this.btnTestaIguais.Click += new System.EventHandler(this.btnTestaIguais_Click);
            // 
            // btnInserirPrimeiroNoSegundo
            // 
            this.btnInserirPrimeiroNoSegundo.Location = new System.Drawing.Point(326, 280);
            this.btnInserirPrimeiroNoSegundo.Margin = new System.Windows.Forms.Padding(5);
            this.btnInserirPrimeiroNoSegundo.Name = "btnInserirPrimeiroNoSegundo";
            this.btnInserirPrimeiroNoSegundo.Size = new System.Drawing.Size(186, 105);
            this.btnInserirPrimeiroNoSegundo.TabIndex = 3;
            this.btnInserirPrimeiroNoSegundo.Text = "Inserir Primeiro no Segundo";
            this.btnInserirPrimeiroNoSegundo.UseVisualStyleBackColor = true;
            this.btnInserirPrimeiroNoSegundo.Click += new System.EventHandler(this.btnInserirPrimeiroNoSegundo_Click);
            // 
            // btnInserirDoisAsteriscos
            // 
            this.btnInserirDoisAsteriscos.Location = new System.Drawing.Point(560, 280);
            this.btnInserirDoisAsteriscos.Margin = new System.Windows.Forms.Padding(5);
            this.btnInserirDoisAsteriscos.Name = "btnInserirDoisAsteriscos";
            this.btnInserirDoisAsteriscos.Size = new System.Drawing.Size(186, 105);
            this.btnInserirDoisAsteriscos.TabIndex = 4;
            this.btnInserirDoisAsteriscos.Text = "Inserir 2 asteriscos";
            this.btnInserirDoisAsteriscos.UseVisualStyleBackColor = true;
            this.btnInserirDoisAsteriscos.Click += new System.EventHandler(this.btnInserirDoisAsteriscos_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(72, 137);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(128, 32);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(428, 133);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(128, 32);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(819, 466);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInserirDoisAsteriscos);
            this.Controls.Add(this.btnInserirPrimeiroNoSegundo);
            this.Controls.Add(this.btnTestaIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnTestaIguais;
        private System.Windows.Forms.Button btnInserirPrimeiroNoSegundo;
        private System.Windows.Forms.Button btnInserirDoisAsteriscos;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}