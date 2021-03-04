namespace tp1
{
    partial class Ejercicio06
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
            this.calcular = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.textIngrese_numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(188, 190);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(505, 82);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese un numero aquí";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(368, 190);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // textIngrese_numero
            // 
            this.textIngrese_numero.Location = new System.Drawing.Point(175, 85);
            this.textIngrese_numero.Name = "textIngrese_numero";
            this.textIngrese_numero.Size = new System.Drawing.Size(324, 20);
            this.textIngrese_numero.TabIndex = 5;
            this.textIngrese_numero.VisibleChanged += new System.EventHandler(this.Ejercicio06_Load);
            // 
            // Ejercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 380);
            this.Controls.Add(this.textIngrese_numero);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.calcular);
            this.Name = "Ejercicio06";
            this.Text = "Ejercicio06";
            this.Load += new System.EventHandler(this.Ejercicio06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox textIngrese_numero;
    }
}