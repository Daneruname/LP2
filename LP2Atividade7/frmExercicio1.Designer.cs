
namespace PAtividade7
{
    partial class frmExercicio1
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
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnLetrasPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtTexto.Location = new System.Drawing.Point(208, 100);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(396, 185);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnWhite
            // 
            this.btnWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.Location = new System.Drawing.Point(88, 327);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(176, 63);
            this.btnWhite.TabIndex = 1;
            this.btnWhite.Text = "Espaços em Branco";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(305, 327);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(176, 63);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Letras R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnLetrasPares
            // 
            this.btnLetrasPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetrasPares.Location = new System.Drawing.Point(523, 327);
            this.btnLetrasPares.Name = "btnLetrasPares";
            this.btnLetrasPares.Size = new System.Drawing.Size(176, 63);
            this.btnLetrasPares.TabIndex = 3;
            this.btnLetrasPares.Text = "Pares de Letras";
            this.btnLetrasPares.UseVisualStyleBackColor = true;
            this.btnLetrasPares.Click += new System.EventHandler(this.btnLetrasPares_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btnLetrasPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnLetrasPares;
    }
}