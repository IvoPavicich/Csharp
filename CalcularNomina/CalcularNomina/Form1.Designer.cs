namespace CalcularNomina
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
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtAsignacionDia = new System.Windows.Forms.TextBox();
            this.txtDiasTrabajados = new System.Windows.Forms.TextBox();
            this.btnGuardarRegistroEmpleado = new System.Windows.Forms.Button();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtSueldoTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(38, 91);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignacion de Salario del Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dias Trabajados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(184, 88);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 6;
            // 
            // txtAsignacionDia
            // 
            this.txtAsignacionDia.Location = new System.Drawing.Point(185, 132);
            this.txtAsignacionDia.Name = "txtAsignacionDia";
            this.txtAsignacionDia.Size = new System.Drawing.Size(100, 20);
            this.txtAsignacionDia.TabIndex = 7;
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Location = new System.Drawing.Point(188, 171);
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(100, 20);
            this.txtDiasTrabajados.TabIndex = 8;
            // 
            // btnGuardarRegistroEmpleado
            // 
            this.btnGuardarRegistroEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarRegistroEmpleado.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.btnGuardarRegistroEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarRegistroEmpleado.Location = new System.Drawing.Point(151, 207);
            this.btnGuardarRegistroEmpleado.Name = "btnGuardarRegistroEmpleado";
            this.btnGuardarRegistroEmpleado.Size = new System.Drawing.Size(167, 41);
            this.btnGuardarRegistroEmpleado.TabIndex = 9;
            this.btnGuardarRegistroEmpleado.Text = "Guardar  Registro de Empleado";
            this.btnGuardarRegistroEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarRegistroEmpleado.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(277, 289);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(107, 39);
            this.btnCalcularSueldo.TabIndex = 10;
            this.btnCalcularSueldo.Text = "Calcular Sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(377, 148);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 39);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtSueldoTotal
            // 
            this.txtSueldoTotal.Location = new System.Drawing.Point(151, 297);
            this.txtSueldoTotal.Name = "txtSueldoTotal";
            this.txtSueldoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoTotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Calculo de nomina del trabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(377, 80);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 35);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 348);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSueldoTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.btnGuardarRegistroEmpleado);
            this.Controls.Add(this.txtDiasTrabajados);
            this.Controls.Add(this.txtAsignacionDia);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtAsignacionDia;
        private System.Windows.Forms.TextBox txtDiasTrabajados;
        private System.Windows.Forms.Button btnGuardarRegistroEmpleado;
        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtSueldoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider error;
    }
}

