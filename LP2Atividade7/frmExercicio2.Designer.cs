
namespace PAtividade7
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
            this.txtNumN = new System.Windows.Forms.TextBox();
            this.btnGerarH = new System.Windows.Forms.Button();
            this.lblNumN = new System.Windows.Forms.Label();
            this.txtNumH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumN
            // 
            this.txtNumN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumN.Location = new System.Drawing.Point(236, 168);
            this.txtNumN.Name = "txtNumN";
            this.txtNumN.Size = new System.Drawing.Size(332, 26);
            this.txtNumN.TabIndex = 0;
            this.txtNumN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNumN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnGerarH
            // 
            this.btnGerarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarH.Location = new System.Drawing.Point(303, 234);
            this.btnGerarH.Name = "btnGerarH";
            this.btnGerarH.Size = new System.Drawing.Size(200, 44);
            this.btnGerarH.TabIndex = 1;
            this.btnGerarH.Text = "Gerar Número H";
            this.btnGerarH.UseVisualStyleBackColor = true;
            this.btnGerarH.Click += new System.EventHandler(this.btnGerarH_Click);
            // 
            // lblNumN
            // 
            this.lblNumN.AutoSize = true;
            this.lblNumN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumN.Location = new System.Drawing.Point(360, 111);
            this.lblNumN.Name = "lblNumN";
            this.lblNumN.Size = new System.Drawing.Size(84, 20);
            this.lblNumN.TabIndex = 2;
            this.lblNumN.Text = "Número N:";
            // 
            // txtNumH
            // 
            this.txtNumH.Enabled = false;
            this.txtNumH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumH.Location = new System.Drawing.Point(236, 328);
            this.txtNumH.Name = "txtNumH";
            this.txtNumH.Size = new System.Drawing.Size(332, 26);
            this.txtNumH.TabIndex = 3;
            this.txtNumH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.txtNumH);
            this.Controls.Add(this.lblNumN);
            this.Controls.Add(this.btnGerarH);
            this.Controls.Add(this.txtNumN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumN;
        private System.Windows.Forms.Button btnGerarH;
        private System.Windows.Forms.Label lblNumN;
        private System.Windows.Forms.TextBox txtNumH;
    }
}