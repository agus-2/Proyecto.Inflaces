namespace Inflaces.Gestion
{
    partial class FormularioCliente
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
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.txtnombre_completo = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMinorista = new System.Windows.Forms.RadioButton();
            this.rbMayorista = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(448, 351);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(204, 52);
            this.btnAddCliente.TabIndex = 0;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // txtnombre_completo
            // 
            this.txtnombre_completo.Location = new System.Drawing.Point(327, 66);
            this.txtnombre_completo.Name = "txtnombre_completo";
            this.txtnombre_completo.Size = new System.Drawing.Size(210, 26);
            this.txtnombre_completo.TabIndex = 1;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(448, 236);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(210, 26);
            this.txtdireccion.TabIndex = 2;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(569, 141);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(210, 26);
            this.txttelefono.TabIndex = 3;
            // 
            // txtcuit
            // 
            this.txtcuit.Location = new System.Drawing.Point(569, 66);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(210, 26);
            this.txtcuit.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(327, 139);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(210, 26);
            this.txtemail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "CUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Direccion";
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Location = new System.Drawing.Point(57, 351);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(204, 52);
            this.btnListaClientes.TabIndex = 16;
            this.btnListaClientes.Text = "Ver Clientes";
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMayorista);
            this.groupBox1.Controls.Add(this.rbMinorista);
            this.groupBox1.Location = new System.Drawing.Point(57, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 107);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // rbMinorista
            // 
            this.rbMinorista.AutoSize = true;
            this.rbMinorista.Checked = true;
            this.rbMinorista.Location = new System.Drawing.Point(88, 35);
            this.rbMinorista.Name = "rbMinorista";
            this.rbMinorista.Size = new System.Drawing.Size(98, 24);
            this.rbMinorista.TabIndex = 18;
            this.rbMinorista.TabStop = true;
            this.rbMinorista.Text = "Minorista";
            this.rbMinorista.UseVisualStyleBackColor = true;
            // 
            // rbMayorista
            // 
            this.rbMayorista.AutoSize = true;
            this.rbMayorista.Location = new System.Drawing.Point(88, 74);
            this.rbMayorista.Name = "rbMayorista";
            this.rbMayorista.Size = new System.Drawing.Size(102, 24);
            this.rbMayorista.TabIndex = 19;
            this.rbMayorista.Text = "Mayorista";
            this.rbMayorista.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcuit);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre_completo);
            this.Controls.Add(this.btnAddCliente);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.TextBox txtnombre_completo;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMayorista;
        private System.Windows.Forms.RadioButton rbMinorista;
    }
}