namespace tp1
{
    partial class Ejercicio32
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
            this.button2 = new System.Windows.Forms.Button();
            this.salidapromedio = new System.Windows.Forms.Label();
            this.lluviamenor = new System.Windows.Forms.Label();
            this.lluviamayor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.entradafecha = new System.Windows.Forms.DateTimePicker();
            this.entradagua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "REFRESCA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salidapromedio
            // 
            this.salidapromedio.AutoSize = true;
            this.salidapromedio.Location = new System.Drawing.Point(192, 222);
            this.salidapromedio.Name = "salidapromedio";
            this.salidapromedio.Size = new System.Drawing.Size(0, 13);
            this.salidapromedio.TabIndex = 23;
            // 
            // lluviamenor
            // 
            this.lluviamenor.AutoSize = true;
            this.lluviamenor.Location = new System.Drawing.Point(192, 185);
            this.lluviamenor.Name = "lluviamenor";
            this.lluviamenor.Size = new System.Drawing.Size(0, 13);
            this.lluviamenor.TabIndex = 22;
            // 
            // lluviamayor
            // 
            this.lluviamayor.AutoSize = true;
            this.lluviamayor.Location = new System.Drawing.Point(192, 156);
            this.lluviamayor.Name = "lluviamayor";
            this.lluviamayor.Size = new System.Drawing.Size(0, 13);
            this.lluviamayor.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "PROMEDIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DIA QUE MENOS LLOVIO:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entradafecha
            // 
            this.entradafecha.Location = new System.Drawing.Point(90, 61);
            this.entradafecha.Name = "entradafecha";
            this.entradafecha.Size = new System.Drawing.Size(235, 20);
            this.entradafecha.TabIndex = 17;
            // 
            // entradagua
            // 
            this.entradagua.Location = new System.Drawing.Point(274, 30);
            this.entradagua.Name = "entradagua";
            this.entradagua.Size = new System.Drawing.Size(100, 20);
            this.entradagua.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "DIA QUE MAS LLOVIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "FECHA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CANTIDAD DE AGUA CAIDA EN MILIMETROS:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ejercicio32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 302);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salidapromedio);
            this.Controls.Add(this.lluviamenor);
            this.Controls.Add(this.lluviamayor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entradafecha);
            this.Controls.Add(this.entradagua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio32";
            this.Text = "Ejercicio32";
            this.Load += new System.EventHandler(this.Ejercicio32_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label salidapromedio;
        private System.Windows.Forms.Label lluviamenor;
        private System.Windows.Forms.Label lluviamayor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker entradafecha;
        private System.Windows.Forms.TextBox entradagua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}