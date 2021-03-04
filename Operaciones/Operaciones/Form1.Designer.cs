namespace Operaciones
{
    partial class Frmoperaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btnCalular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.txtresta = new System.Windows.Forms.TextBox();
            this.txtmultiplicacion = new System.Windows.Forms.TextBox();
            this.txtdivision = new System.Windows.Forms.TextBox();
            this.txtpotencia = new System.Windows.Forms.TextBox();
            this.txtraiz = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero2";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(131, 28);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 2;
            this.txtnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(131, 62);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 3;
            // 
            // btnCalular
            // 
            this.btnCalular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalular.Location = new System.Drawing.Point(554, 47);
            this.btnCalular.Name = "btnCalular";
            this.btnCalular.Size = new System.Drawing.Size(97, 52);
            this.btnCalular.TabIndex = 4;
            this.btnCalular.Text = "Calcular";
            this.btnCalular.UseVisualStyleBackColor = true;
            this.btnCalular.Click += new System.EventHandler(this.btnCalular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Multiplicacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Division";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Potencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Raiz";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(131, 152);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(100, 20);
            this.txtsuma.TabIndex = 11;
            this.txtsuma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtresta
            // 
            this.txtresta.Location = new System.Drawing.Point(379, 152);
            this.txtresta.Name = "txtresta";
            this.txtresta.Size = new System.Drawing.Size(100, 20);
            this.txtresta.TabIndex = 12;
            // 
            // txtmultiplicacion
            // 
            this.txtmultiplicacion.Location = new System.Drawing.Point(379, 214);
            this.txtmultiplicacion.Name = "txtmultiplicacion";
            this.txtmultiplicacion.Size = new System.Drawing.Size(100, 20);
            this.txtmultiplicacion.TabIndex = 13;
            // 
            // txtdivision
            // 
            this.txtdivision.Location = new System.Drawing.Point(131, 207);
            this.txtdivision.Name = "txtdivision";
            this.txtdivision.Size = new System.Drawing.Size(100, 20);
            this.txtdivision.TabIndex = 14;
            // 
            // txtpotencia
            // 
            this.txtpotencia.Location = new System.Drawing.Point(347, 28);
            this.txtpotencia.Name = "txtpotencia";
            this.txtpotencia.Size = new System.Drawing.Size(108, 20);
            this.txtpotencia.TabIndex = 15;
            // 
            // txtraiz
            // 
            this.txtraiz.Location = new System.Drawing.Point(347, 65);
            this.txtraiz.Name = "txtraiz";
            this.txtraiz.Size = new System.Drawing.Size(108, 20);
            this.txtraiz.TabIndex = 16;
            this.txtraiz.TextChanged += new System.EventHandler(this.txtraiz_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtraiz);
            this.groupBox1.Controls.Add(this.txtpotencia);
            this.groupBox1.Controls.Add(this.txtdivision);
            this.groupBox1.Controls.Add(this.txtmultiplicacion);
            this.groupBox1.Controls.Add(this.txtresta);
            this.groupBox1.Controls.Add(this.txtsuma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCalular);
            this.groupBox1.Controls.Add(this.txtnumero2);
            this.groupBox1.Controls.Add(this.txtnumero1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 400);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(554, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 52);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(454, 315);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(97, 52);
            this.btnsalir.TabIndex = 18;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 416);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Operaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button btnCalular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.TextBox txtresta;
        private System.Windows.Forms.TextBox txtmultiplicacion;
        private System.Windows.Forms.TextBox txtdivision;
        private System.Windows.Forms.TextBox txtpotencia;
        private System.Windows.Forms.TextBox txtraiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

