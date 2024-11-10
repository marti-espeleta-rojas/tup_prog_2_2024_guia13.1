namespace Parcial_2_Solución
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
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNro = new System.Windows.Forms.CheckBox();
            this.txtCtacte = new System.Windows.Forms.TextBox();
            this.Turnos = new System.Windows.Forms.Label();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbCompras = new System.Windows.Forms.RadioButton();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExportarTickets = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(63, 18);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(220, 20);
            this.tbDNI.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txtCtacte);
            this.panel1.Controls.Add(this.cbNro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pagos:";
            // 
            // cbNro
            // 
            this.cbNro.AutoSize = true;
            this.cbNro.Location = new System.Drawing.Point(4, 51);
            this.cbNro.Name = "cbNro";
            this.cbNro.Size = new System.Drawing.Size(81, 17);
            this.cbNro.TabIndex = 1;
            this.cbNro.Text = "Nro Cta Cte";
            this.cbNro.UseVisualStyleBackColor = true;
            // 
            // txtCtacte
            // 
            this.txtCtacte.Location = new System.Drawing.Point(119, 48);
            this.txtCtacte.Name = "txtCtacte";
            this.txtCtacte.Size = new System.Drawing.Size(100, 20);
            this.txtCtacte.TabIndex = 2;
            // 
            // Turnos
            // 
            this.Turnos.AutoSize = true;
            this.Turnos.Location = new System.Drawing.Point(22, 172);
            this.Turnos.Name = "Turnos";
            this.Turnos.Size = new System.Drawing.Size(40, 13);
            this.Turnos.TabIndex = 3;
            this.Turnos.Text = "Turnos";
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.Location = new System.Drawing.Point(26, 188);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(257, 108);
            this.lbxTurnos.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.rbPagos);
            this.panel2.Controls.Add(this.rbCompras);
            this.panel2.Location = new System.Drawing.Point(22, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 51);
            this.panel2.TabIndex = 5;
            // 
            // rbCompras
            // 
            this.rbCompras.AutoSize = true;
            this.rbCompras.Location = new System.Drawing.Point(4, 4);
            this.rbCompras.Name = "rbCompras";
            this.rbCompras.Size = new System.Drawing.Size(66, 17);
            this.rbCompras.TabIndex = 0;
            this.rbCompras.TabStop = true;
            this.rbCompras.Text = "Compras";
            this.rbCompras.UseVisualStyleBackColor = true;
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Location = new System.Drawing.Point(4, 28);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(55, 17);
            this.rbPagos.TabIndex = 1;
            this.rbPagos.TabStop = true;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Location = new System.Drawing.Point(185, 303);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(98, 51);
            this.btnAtenderCliente.TabIndex = 6;
            this.btnAtenderCliente.Text = "Atender Cliente";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(317, 65);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(85, 68);
            this.btnTicket.TabIndex = 7;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnExportarTickets
            // 
            this.btnExportarTickets.Location = new System.Drawing.Point(317, 188);
            this.btnExportarTickets.Name = "btnExportarTickets";
            this.btnExportarTickets.Size = new System.Drawing.Size(85, 49);
            this.btnExportarTickets.TabIndex = 8;
            this.btnExportarTickets.Text = "Exportar Tickets";
            this.btnExportarTickets.UseVisualStyleBackColor = true;
            this.btnExportarTickets.Click += new System.EventHandler(this.btnExportarTickets_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(317, 243);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(85, 53);
            this.btnImportar.TabIndex = 9;
            this.btnImportar.Text = "Importar Cuentas Corrientes";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 365);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportarTickets);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnAtenderCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.Turnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCtacte;
        private System.Windows.Forms.CheckBox cbNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Turnos;
        private System.Windows.Forms.ListBox lbxTurnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.RadioButton rbCompras;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExportarTickets;
        private System.Windows.Forms.Button btnImportar;
    }
}

