namespace tp1
{
    partial class Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "IR A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ejercicio 01",
            "Ejercicio 02",
            "Ejercicio 03",
            "Ejercicio 04",
            "Ejercicio 05",
            "Ejercicio 06",
            "Ejercicio 07",
            "Ejercicio 08",
            "Ejercicio 09",
            "Ejercicio 11",
            "Ejercicio 12",
            "Ejercicio 13",
            "Ejercicio 14",
            "Ejercicio 15",
            "Ejercicio 16",
            "Ejercicio 17",
            "Ejercicio 18",
            "Ejercicio 19",
            "Ejercicio 20",
            "Ejercicio 21",
            "Ejercicio 22",
            "Ejercicio 23",
            "Ejercicio 24",
            "Ejercicio 25",
            "Ejercicio 26",
            "Ejercicio 27",
            "Ejercicio 28",
            "Ejercicio 29",
            "Ejercicio 30\t",
            "Ejercicio 31",
            "Ejercicio 32",
            "Funcion1",
            "Funcion2",
            "Funcion3",
            "Funcion4",
            "Funcion5",
            "Funcion6",
            "Funcion7",
            "Funcion8",
            "Funcion9",
            "Funcion10"});
            this.comboBox1.Location = new System.Drawing.Point(587, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(432, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESPLIEGUE LA LISTA PARA SELECCIONAR UN EJERCICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(898, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "TRABAJO PARCTICO N°1:\"PARADIGMA IMPERATIVO\"";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tp1.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(996, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}