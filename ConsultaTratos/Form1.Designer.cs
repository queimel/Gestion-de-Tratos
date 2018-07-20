namespace ConsultaTratos
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rut = new System.Windows.Forms.TextBox();
            this.Número = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_montoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cb_tipoTrato = new System.Windows.Forms.ComboBox();
            this.btn_restablecer = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_rut
            // 
            this.tb_rut.Location = new System.Drawing.Point(171, 42);
            this.tb_rut.Name = "tb_rut";
            this.tb_rut.Size = new System.Drawing.Size(181, 20);
            this.tb_rut.TabIndex = 1;
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Número.Location = new System.Drawing.Point(31, 113);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(73, 19);
            this.Número.TabIndex = 2;
            this.Número.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto Trato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(171, 115);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(181, 20);
            this.tb_numero.TabIndex = 6;
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(171, 203);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(181, 20);
            this.tb_monto.TabIndex = 8;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "A",
            "P",
            "C"});
            this.cb_estado.Location = new System.Drawing.Point(171, 246);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(181, 21);
            this.cb_estado.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de trato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consulta";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(171, 383);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(181, 20);
            this.tb_cantidad.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
            // 
            // tb_montoTotal
            // 
            this.tb_montoTotal.Location = new System.Drawing.Point(171, 429);
            this.tb_montoTotal.Name = "tb_montoTotal";
            this.tb_montoTotal.Size = new System.Drawing.Size(181, 20);
            this.tb_montoTotal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Monto Total";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(389, 125);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(145, 42);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(389, 212);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(145, 42);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // cb_tipoTrato
            // 
            this.cb_tipoTrato.FormattingEnabled = true;
            this.cb_tipoTrato.Location = new System.Drawing.Point(171, 335);
            this.cb_tipoTrato.Name = "cb_tipoTrato";
            this.cb_tipoTrato.Size = new System.Drawing.Size(181, 21);
            this.cb_tipoTrato.TabIndex = 19;
            this.cb_tipoTrato.SelectedIndexChanged += new System.EventHandler(this.cb_tipoTrato_SelectedIndexChanged);
            // 
            // btn_restablecer
            // 
            this.btn_restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restablecer.Location = new System.Drawing.Point(35, 491);
            this.btn_restablecer.Name = "btn_restablecer";
            this.btn_restablecer.Size = new System.Drawing.Size(145, 42);
            this.btn_restablecer.TabIndex = 20;
            this.btn_restablecer.Text = "Reestablecer";
            this.btn_restablecer.UseVisualStyleBackColor = true;
            this.btn_restablecer.Click += new System.EventHandler(this.btn_restablecer_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(389, 491);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(145, 42);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Red;
            this.l_mensajes.Location = new System.Drawing.Point(31, 560);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(156, 19);
            this.l_mensajes.TabIndex = 22;
            this.l_mensajes.Text = "Zona de mensajes";
            // 
            // dt_fecha
            // 
            this.dt_fecha.CustomFormat = "dd/MM/yyyy";
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(171, 157);
            this.dt_fecha.MaxDate = new System.DateTime(2018, 7, 19, 0, 0, 0, 0);
            this.dt_fecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(181, 20);
            this.dt_fecha.TabIndex = 23;
            this.dt_fecha.Value = new System.DateTime(2018, 7, 19, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 637);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.l_mensajes);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_restablecer);
            this.Controls.Add(this.cb_tipoTrato);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.tb_montoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.tb_monto);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Número);
            this.Controls.Add(this.tb_rut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rut;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_montoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ComboBox cb_tipoTrato;
        private System.Windows.Forms.Button btn_restablecer;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label l_mensajes;
        private System.Windows.Forms.DateTimePicker dt_fecha;
    }
}

