namespace UnicoEjercicio
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
            this.btnAtenderDenuncias = new System.Windows.Forms.Button();
            this.btnImportarVehiculos = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tbDenuncia = new System.Windows.Forms.TextBox();
            this.rbNuevoCliente = new System.Windows.Forms.RadioButton();
            this.rbDenuncia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.btnAtenderClientes = new System.Windows.Forms.Button();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // btnAtenderDenuncias
            // 
            this.btnAtenderDenuncias.Location = new System.Drawing.Point(19, 332);
            this.btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            this.btnAtenderDenuncias.Size = new System.Drawing.Size(118, 27);
            this.btnAtenderDenuncias.TabIndex = 1;
            this.btnAtenderDenuncias.Text = "Atender Denuncias";
            this.btnAtenderDenuncias.UseVisualStyleBackColor = true;
            this.btnAtenderDenuncias.Click += new System.EventHandler(this.btnAtenderDenuncias_Click);
            // 
            // btnImportarVehiculos
            // 
            this.btnImportarVehiculos.Location = new System.Drawing.Point(269, 259);
            this.btnImportarVehiculos.Name = "btnImportarVehiculos";
            this.btnImportarVehiculos.Size = new System.Drawing.Size(75, 59);
            this.btnImportarVehiculos.TabIndex = 2;
            this.btnImportarVehiculos.Text = "Importar Vehículos";
            this.btnImportarVehiculos.UseVisualStyleBackColor = true;
            this.btnImportarVehiculos.Click += new System.EventHandler(this.btnImportarVehiculos_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(269, 64);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 101);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(269, 197);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 56);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(54, 21);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(209, 20);
            this.tbDNI.TabIndex = 5;
            // 
            // gbxDatos
            // 
            this.gbxDatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxDatos.Controls.Add(this.cbxTipo);
            this.gbxDatos.Controls.Add(this.tbDenuncia);
            this.gbxDatos.Controls.Add(this.rbNuevoCliente);
            this.gbxDatos.Controls.Add(this.rbDenuncia);
            this.gbxDatos.Location = new System.Drawing.Point(16, 64);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(247, 101);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Cliente";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(125, 70);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(116, 21);
            this.cbxTipo.TabIndex = 3;
            // 
            // tbDenuncia
            // 
            this.tbDenuncia.Location = new System.Drawing.Point(125, 29);
            this.tbDenuncia.Name = "tbDenuncia";
            this.tbDenuncia.Size = new System.Drawing.Size(116, 20);
            this.tbDenuncia.TabIndex = 2;
            // 
            // rbNuevoCliente
            // 
            this.rbNuevoCliente.AutoSize = true;
            this.rbNuevoCliente.Location = new System.Drawing.Point(7, 70);
            this.rbNuevoCliente.Name = "rbNuevoCliente";
            this.rbNuevoCliente.Size = new System.Drawing.Size(92, 17);
            this.rbNuevoCliente.TabIndex = 1;
            this.rbNuevoCliente.TabStop = true;
            this.rbNuevoCliente.Text = "Nuevo Cliente";
            this.rbNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // rbDenuncia
            // 
            this.rbDenuncia.AutoSize = true;
            this.rbDenuncia.Location = new System.Drawing.Point(7, 29);
            this.rbDenuncia.Name = "rbDenuncia";
            this.rbDenuncia.Size = new System.Drawing.Size(71, 17);
            this.rbDenuncia.TabIndex = 0;
            this.rbDenuncia.TabStop = true;
            this.rbDenuncia.Text = "Denuncia";
            this.rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Turnos";
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.Location = new System.Drawing.Point(19, 197);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(244, 121);
            this.lbxTurnos.TabIndex = 9;
            // 
            // btnAtenderClientes
            // 
            this.btnAtenderClientes.Location = new System.Drawing.Point(143, 332);
            this.btnAtenderClientes.Name = "btnAtenderClientes";
            this.btnAtenderClientes.Size = new System.Drawing.Size(120, 27);
            this.btnAtenderClientes.TabIndex = 10;
            this.btnAtenderClientes.Text = "Atender Clientes";
            this.btnAtenderClientes.UseVisualStyleBackColor = true;
            this.btnAtenderClientes.Click += new System.EventHandler(this.btnAtenderClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 371);
            this.Controls.Add(this.btnAtenderClientes);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnImportarVehiculos);
            this.Controls.Add(this.btnAtenderDenuncias);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtenderDenuncias;
        private System.Windows.Forms.Button btnImportarVehiculos;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.RadioButton rbNuevoCliente;
        private System.Windows.Forms.RadioButton rbDenuncia;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox tbDenuncia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxTurnos;
        private System.Windows.Forms.Button btnAtenderClientes;
    }
}

