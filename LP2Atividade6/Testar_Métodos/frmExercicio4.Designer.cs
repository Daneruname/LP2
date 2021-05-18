namespace Testar_Métodos
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContarNumeros = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnContarLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtTexto.Location = new System.Drawing.Point(158, 82);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(585, 158);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnContarNumeros
            // 
            this.btnContarNumeros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarNumeros.Location = new System.Drawing.Point(115, 290);
            this.btnContarNumeros.Name = "btnContarNumeros";
            this.btnContarNumeros.Size = new System.Drawing.Size(182, 88);
            this.btnContarNumeros.TabIndex = 1;
            this.btnContarNumeros.Text = "Contar Numeros";
            this.btnContarNumeros.UseVisualStyleBackColor = true;
            this.btnContarNumeros.Click += new System.EventHandler(this.btnContarNumeros_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicao.Location = new System.Drawing.Point(359, 290);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(182, 88);
            this.btnPosicao.TabIndex = 2;
            this.btnPosicao.Text = "Posição Primeiro Branco";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnContarLetras
            // 
            this.btnContarLetras.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarLetras.Location = new System.Drawing.Point(603, 290);
            this.btnContarLetras.Name = "btnContarLetras";
            this.btnContarLetras.Size = new System.Drawing.Size(182, 88);
            this.btnContarLetras.TabIndex = 3;
            this.btnContarLetras.Text = "Contar Letras";
            this.btnContarLetras.UseVisualStyleBackColor = true;
            this.btnContarLetras.Click += new System.EventHandler(this.btnContarLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(900, 469);
            this.Controls.Add(this.btnContarLetras);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnContarNumeros);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnContarNumeros;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnContarLetras;
    }
}