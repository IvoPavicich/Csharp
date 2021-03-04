namespace tp1
{
    partial class Ejercicio30
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
            this.salidapares = new System.Windows.Forms.Label();
            this.salidacantidad = new System.Windows.Forms.Label();
            this.cajasalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.caja2 = new System.Windows.Forms.TextBox();
            this.caja1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salidapares
            // 
            this.salidapares.AutoSize = true;
            this.salidapares.Location = new System.Drawing.Point(23, 230);
            this.salidapares.Name = "salidapares";
            this.salidapares.Size = new System.Drawing.Size(46, 13);
            this.salidapares.TabIndex = 17;
            this.salidapares.Text = "PARES:";
            // 
            // salidacantidad
            // 
            this.salidacantidad.AutoSize = true;
            this.salidacantidad.Location = new System.Drawing.Point(23, 203);
            this.salidacantidad.Name = "salidacantidad";
            this.salidacantidad.Size = new System.Drawing.Size(65, 13);
            this.salidacantidad.TabIndex = 16;
            this.salidacantidad.Text = "CANTIDAD:";
            // 
            // cajasalida
            // 
            this.cajasalida.Location = new System.Drawing.Point(147, 137);
            this.cajasalida.Multiline = true;
            this.cajasalida.Name = "cajasalida";
            this.cajasalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cajasalida.Size = new System.Drawing.Size(119, 42);
            this.cajasalida.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "INGRESE DOS VALORES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caja2
            // 
            this.caja2.Location = new System.Drawing.Point(156, 100);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(100, 20);
            this.caja2.TabIndex = 12;
            // 
            // caja1
            // 
            this.caja1.Location = new System.Drawing.Point(156, 59);
            this.caja1.Name = "caja1";
            this.caja1.Size = new System.Drawing.Size(100, 20);
            this.caja1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "VALOR 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "VALOR 1:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ejercicio30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 329);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salidapares);
            this.Controls.Add(this.salidacantidad);
            this.Controls.Add(this.cajasalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.caja2);
            this.Controls.Add(this.caja1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio30";
            this.Text = "Ejercicio30";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salidapares;
        private System.Windows.Forms.Label salidacantidad;
        private System.Windows.Forms.TextBox cajasalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox caja2;
        private System.Windows.Forms.TextBox caja1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}