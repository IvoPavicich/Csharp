namespace tp1
{
    partial class Ejercicio10
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.acepta = new System.Windows.Forms.Button();
            this.limpia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una palabra";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(160, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            // 
            // acepta
            // 
            this.acepta.Location = new System.Drawing.Point(151, 117);
            this.acepta.Name = "acepta";
            this.acepta.Size = new System.Drawing.Size(75, 23);
            this.acepta.TabIndex = 2;
            this.acepta.Text = "aceptar";
            this.acepta.UseVisualStyleBackColor = true;
            
            this.acepta.Enter += new System.EventHandler(this.acepta_Click);
            // 
            // limpia
            // 
            this.limpia.Location = new System.Drawing.Point(370, 39);
            this.limpia.Name = "limpia";
            this.limpia.Size = new System.Drawing.Size(75, 23);
            this.limpia.TabIndex = 3;
            this.limpia.Text = "limpiar";
            this.limpia.UseVisualStyleBackColor = true;
            this.limpia.Click += new System.EventHandler(this.limpia_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vocales";
            // 
            // Ejercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.limpia);
            this.Controls.Add(this.acepta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio10";
            this.Text = "Ejercicio10";
            this.Enter += new System.EventHandler(this.acepta_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button acepta;
        private System.Windows.Forms.Button limpia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}