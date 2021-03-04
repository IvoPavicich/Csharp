namespace GestionMuseo
{
    partial class Form1
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
            this.lblOBRA = new System.Windows.Forms.Label();
            this.lablTITULO = new System.Windows.Forms.Label();
            this.lblAUTOR = new System.Windows.Forms.Label();
            this.lblAÑO = new System.Windows.Forms.Label();
            this.lblTIPO = new System.Windows.Forms.Label();
            this.txtobra_arte = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpersona = new System.Windows.Forms.TextBox();
            this.txttarea = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.btnREGISTRAR = new System.Windows.Forms.Button();
            this.btnNUEVO = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOBRA
            // 
            this.lblOBRA.AutoSize = true;
            this.lblOBRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBRA.Location = new System.Drawing.Point(8, 66);
            this.lblOBRA.Name = "lblOBRA";
            this.lblOBRA.Size = new System.Drawing.Size(50, 18);
            this.lblOBRA.TabIndex = 0;
            this.lblOBRA.Text = "OBRA";
            // 
            // lablTITULO
            // 
            this.lablTITULO.AutoSize = true;
            this.lablTITULO.Location = new System.Drawing.Point(8, 132);
            this.lablTITULO.Name = "lablTITULO";
            this.lablTITULO.Size = new System.Drawing.Size(82, 24);
            this.lablTITULO.TabIndex = 1;
            this.lablTITULO.Text = "TITULO";
            // 
            // lblAUTOR
            // 
            this.lblAUTOR.AutoSize = true;
            this.lblAUTOR.Location = new System.Drawing.Point(8, 203);
            this.lblAUTOR.Name = "lblAUTOR";
            this.lblAUTOR.Size = new System.Drawing.Size(81, 24);
            this.lblAUTOR.TabIndex = 2;
            this.lblAUTOR.Text = "AUTOR";
            // 
            // lblAÑO
            // 
            this.lblAÑO.AutoSize = true;
            this.lblAÑO.Location = new System.Drawing.Point(8, 272);
            this.lblAÑO.Name = "lblAÑO";
            this.lblAÑO.Size = new System.Drawing.Size(55, 24);
            this.lblAÑO.TabIndex = 3;
            this.lblAÑO.Text = "AÑO";
            this.lblAÑO.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTIPO
            // 
            this.lblTIPO.AutoSize = true;
            this.lblTIPO.Location = new System.Drawing.Point(8, 333);
            this.lblTIPO.Name = "lblTIPO";
            this.lblTIPO.Size = new System.Drawing.Size(57, 24);
            this.lblTIPO.TabIndex = 4;
            this.lblTIPO.Text = "TIPO";
            // 
            // txtobra_arte
            // 
            this.txtobra_arte.Location = new System.Drawing.Point(79, 66);
            this.txtobra_arte.Name = "txtobra_arte";
            this.txtobra_arte.Size = new System.Drawing.Size(250, 29);
            this.txtobra_arte.TabIndex = 5;
            this.txtobra_arte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(96, 127);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(233, 29);
            this.txttitulo.TabIndex = 6;
            this.txttitulo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(96, 199);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(233, 29);
            this.txtautor.TabIndex = 7;
            this.txtautor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(96, 267);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(233, 29);
            this.txtaño.TabIndex = 8;
            this.txtaño.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(96, 330);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(233, 29);
            this.txttipo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "OBRAS DE ARTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "TAREAS DE MANTENIMIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "PERSONA QUE REALIZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "TAREA REALIZADA";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "FECHA DE inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "hora de inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "DURACION";
            // 
            // txtpersona
            // 
            this.txtpersona.Location = new System.Drawing.Point(559, 66);
            this.txtpersona.Name = "txtpersona";
            this.txtpersona.Size = new System.Drawing.Size(281, 29);
            this.txtpersona.TabIndex = 17;
            this.txtpersona.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txttarea
            // 
            this.txttarea.Location = new System.Drawing.Point(522, 136);
            this.txttarea.Name = "txttarea";
            this.txttarea.Size = new System.Drawing.Size(318, 29);
            this.txttarea.TabIndex = 18;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(516, 209);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(324, 29);
            this.txtfecha.TabIndex = 19;
            this.txtfecha.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(513, 267);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(327, 29);
            this.txthora.TabIndex = 20;
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(513, 333);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(327, 29);
            this.txtduracion.TabIndex = 21;
            this.txtduracion.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // btnREGISTRAR
            // 
            this.btnREGISTRAR.Location = new System.Drawing.Point(96, 420);
            this.btnREGISTRAR.Name = "btnREGISTRAR";
            this.btnREGISTRAR.Size = new System.Drawing.Size(144, 56);
            this.btnREGISTRAR.TabIndex = 22;
            this.btnREGISTRAR.Text = "REGISTRAR";
            this.btnREGISTRAR.UseVisualStyleBackColor = true;
            this.btnREGISTRAR.Click += new System.EventHandler(this.btnREGISTRAR_Click);
            // 
            // btnNUEVO
            // 
            this.btnNUEVO.Location = new System.Drawing.Point(367, 426);
            this.btnNUEVO.Name = "btnNUEVO";
            this.btnNUEVO.Size = new System.Drawing.Size(134, 50);
            this.btnNUEVO.TabIndex = 23;
            this.btnNUEVO.Text = "NUEVO";
            this.btnNUEVO.UseVisualStyleBackColor = true;
            this.btnNUEVO.Click += new System.EventHandler(this.btnNUEVO_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(597, 439);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(142, 50);
            this.btnSALIR.TabIndex = 24;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 741);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnNUEVO);
            this.Controls.Add(this.btnREGISTRAR);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txttarea);
            this.Controls.Add(this.txtpersona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txtobra_arte);
            this.Controls.Add(this.lblTIPO);
            this.Controls.Add(this.lblAÑO);
            this.Controls.Add(this.lblAUTOR);
            this.Controls.Add(this.lablTITULO);
            this.Controls.Add(this.lblOBRA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Gestion de Museo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOBRA;
        private System.Windows.Forms.Label lablTITULO;
        private System.Windows.Forms.Label lblAUTOR;
        private System.Windows.Forms.Label lblAÑO;
        private System.Windows.Forms.Label lblTIPO;
        private System.Windows.Forms.TextBox txtobra_arte;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpersona;
        private System.Windows.Forms.TextBox txttarea;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.Button btnREGISTRAR;
        private System.Windows.Forms.Button btnNUEVO;
        private System.Windows.Forms.Button btnSALIR;
    }
}

