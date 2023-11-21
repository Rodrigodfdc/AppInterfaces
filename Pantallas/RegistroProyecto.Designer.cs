namespace WindowsFormsApp3
{
    partial class registroproyecto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textPresupuestoInicial = new System.Windows.Forms.TextBox();
            this.textPresupuestoActual = new System.Windows.Forms.TextBox();
            this.textCambios = new System.Windows.Forms.TextBox();
            this.textCodigoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AltaProyecto = new System.Windows.Forms.Button();
            this.textFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.textFechaFin = new System.Windows.Forms.DateTimePicker();
            this.textEstadoProyecto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 55);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 626);
            this.label3.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Añade tu proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registra tu proyecto";
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(192, 82);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(238, 20);
            this.textCodigo.TabIndex = 4;
            this.textCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(192, 112);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(227, 20);
            this.textDescripcion.TabIndex = 15;
            // 
            // textPresupuestoInicial
            // 
            this.textPresupuestoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPresupuestoInicial.Location = new System.Drawing.Point(192, 226);
            this.textPresupuestoInicial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textPresupuestoInicial.Name = "textPresupuestoInicial";
            this.textPresupuestoInicial.Size = new System.Drawing.Size(256, 20);
            this.textPresupuestoInicial.TabIndex = 19;
            // 
            // textPresupuestoActual
            // 
            this.textPresupuestoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPresupuestoActual.Location = new System.Drawing.Point(192, 261);
            this.textPresupuestoActual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textPresupuestoActual.Name = "textPresupuestoActual";
            this.textPresupuestoActual.Size = new System.Drawing.Size(256, 20);
            this.textPresupuestoActual.TabIndex = 20;
            // 
            // textCambios
            // 
            this.textCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCambios.Location = new System.Drawing.Point(192, 295);
            this.textCambios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textCambios.Name = "textCambios";
            this.textCambios.Size = new System.Drawing.Size(256, 20);
            this.textCambios.TabIndex = 21;
            // 
            // textCodigoCliente
            // 
            this.textCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoCliente.Location = new System.Drawing.Point(192, 323);
            this.textCodigoCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textCodigoCliente.Name = "textCodigoCliente";
            this.textCodigoCliente.Size = new System.Drawing.Size(256, 20);
            this.textCodigoCliente.TabIndex = 22;
            this.textCodigoCliente.TextChanged += new System.EventHandler(this.textCodigoCliente_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha inicio:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha fin:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 38);
            this.label9.TabIndex = 26;
            this.label9.Text = "Estado proyecto:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Presupuesto inicial:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Presupuesto actual:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(104, 295);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Cambios:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(60, 323);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "Codigo cliente:";
            // 
            // AltaProyecto
            // 
            this.AltaProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AltaProyecto.Location = new System.Drawing.Point(500, 301);
            this.AltaProyecto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AltaProyecto.Name = "AltaProyecto";
            this.AltaProyecto.Size = new System.Drawing.Size(81, 42);
            this.AltaProyecto.TabIndex = 31;
            this.AltaProyecto.Text = "Alta proyecto";
            this.AltaProyecto.UseVisualStyleBackColor = true;
            this.AltaProyecto.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFechaInicio
            // 
            this.textFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechaInicio.Location = new System.Drawing.Point(192, 140);
            this.textFechaInicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textFechaInicio.Name = "textFechaInicio";
            this.textFechaInicio.Size = new System.Drawing.Size(256, 20);
            this.textFechaInicio.TabIndex = 32;
            // 
            // textFechaFin
            // 
            this.textFechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechaFin.Location = new System.Drawing.Point(192, 168);
            this.textFechaFin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textFechaFin.Name = "textFechaFin";
            this.textFechaFin.Size = new System.Drawing.Size(256, 20);
            this.textFechaFin.TabIndex = 33;
            // 
            // textEstadoProyecto
            // 
            this.textEstadoProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstadoProyecto.FormattingEnabled = true;
            this.textEstadoProyecto.Items.AddRange(new object[] {
            "Nuevo",
            "Ejecutando",
            "Bloqueado",
            "Finalizado"});
            this.textEstadoProyecto.Location = new System.Drawing.Point(192, 195);
            this.textEstadoProyecto.Name = "textEstadoProyecto";
            this.textEstadoProyecto.Size = new System.Drawing.Size(256, 21);
            this.textEstadoProyecto.TabIndex = 34;
            this.textEstadoProyecto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // registroproyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(689, 408);
            this.Controls.Add(this.textEstadoProyecto);
            this.Controls.Add(this.textFechaFin);
            this.Controls.Add(this.textFechaInicio);
            this.Controls.Add(this.AltaProyecto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCodigoCliente);
            this.Controls.Add(this.textCambios);
            this.Controls.Add(this.textPresupuestoActual);
            this.Controls.Add(this.textPresupuestoInicial);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "registroproyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nuevo-proyecto";
            this.Load += new System.EventHandler(this.nuevoproyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textPresupuestoInicial;
        private System.Windows.Forms.TextBox textPresupuestoActual;
        private System.Windows.Forms.TextBox textCambios;
        private System.Windows.Forms.TextBox textCodigoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AltaProyecto;
        private System.Windows.Forms.DateTimePicker textFechaInicio;
        private System.Windows.Forms.DateTimePicker textFechaFin;
        private System.Windows.Forms.ComboBox textEstadoProyecto;
    }
}