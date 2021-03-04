namespace tp1
{
    partial class Ejercicio11
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
            this.rdlunes = new System.Windows.Forms.RadioButton();
            this.rdmartes = new System.Windows.Forms.RadioButton();
            this.rdmiércoles = new System.Windows.Forms.RadioButton();
            this.rdjueves = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdlunes
            // 
            this.rdlunes.AutoSize = true;
            this.rdlunes.Location = new System.Drawing.Point(207, 63);
            this.rdlunes.Name = "rdlunes";
            this.rdlunes.Size = new System.Drawing.Size(50, 17);
            this.rdlunes.TabIndex = 7;
            this.rdlunes.TabStop = true;
            this.rdlunes.Text = "lunes";
            this.rdlunes.UseVisualStyleBackColor = true;
            // 
            // rdmartes
            // 
            this.rdmartes.AutoSize = true;
            this.rdmartes.Location = new System.Drawing.Point(207, 93);
            this.rdmartes.Name = "rdmartes";
            this.rdmartes.Size = new System.Drawing.Size(56, 17);
            this.rdmartes.TabIndex = 8;
            this.rdmartes.TabStop = true;
            this.rdmartes.Text = "martes";
            this.rdmartes.UseVisualStyleBackColor = true;
            // 
            // rdmiércoles
            // 
            this.rdmiércoles.AutoSize = true;
            this.rdmiércoles.Location = new System.Drawing.Point(207, 119);
            this.rdmiércoles.Name = "rdmiércoles";
            this.rdmiércoles.Size = new System.Drawing.Size(69, 17);
            this.rdmiércoles.TabIndex = 9;
            this.rdmiércoles.TabStop = true;
            this.rdmiércoles.Text = "miércoles";
            this.rdmiércoles.UseVisualStyleBackColor = true;
            // 
            // rdjueves
            // 
            this.rdjueves.AutoSize = true;
            this.rdjueves.Location = new System.Drawing.Point(207, 148);
            this.rdjueves.Name = "rdjueves";
            this.rdjueves.Size = new System.Drawing.Size(31, 17);
            this.rdjueves.TabIndex = 10;
            this.rdjueves.TabStop = true;
            this.rdjueves.Text = "v";
            this.rdjueves.UseVisualStyleBackColor = true;
            // 
            // Ejercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 334);
            this.Controls.Add(this.rdjueves);
            this.Controls.Add(this.rdmiércoles);
            this.Controls.Add(this.rdmartes);
            this.Controls.Add(this.rdlunes);
            this.Name = "Ejercicio11";
            this.Text = "Ejercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdlunes;
        private System.Windows.Forms.RadioButton rdmartes;
        private System.Windows.Forms.RadioButton rdmiércoles;
        private System.Windows.Forms.RadioButton rdjueves;
    }
}