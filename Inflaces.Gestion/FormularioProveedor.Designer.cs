namespace Inflaces.Gestion
{
    partial class FormularioProveedor
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
            this.btnAgregarEmpresa = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCUIT = new System.Windows.Forms.TextBox();
            this.textNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarEmpresa
            // 
            this.btnAgregarEmpresa.Location = new System.Drawing.Point(46, 368);
            this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
            this.btnAgregarEmpresa.Size = new System.Drawing.Size(210, 58);
            this.btnAgregarEmpresa.TabIndex = 0;
            this.btnAgregarEmpresa.Text = "Agregar Empresa";
            this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
            this.btnAgregarEmpresa.Click += new System.EventHandler(this.btnAgregarEmpresa_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(441, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(46, 253);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(210, 26);
            this.textTelefono.TabIndex = 3;
            // 
            // textCUIT
            // 
            this.textCUIT.Location = new System.Drawing.Point(46, 167);
            this.textCUIT.Name = "textCUIT";
            this.textCUIT.Size = new System.Drawing.Size(210, 26);
            this.textCUIT.TabIndex = 5;
            // 
            // textNombreEmpresa
            // 
            this.textNombreEmpresa.Location = new System.Drawing.Point(46, 78);
            this.textNombreEmpresa.Name = "textNombreEmpresa";
            this.textNombreEmpresa.Size = new System.Drawing.Size(210, 26);
            this.textNombreEmpresa.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(441, 222);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(210, 26);
            this.textDireccion.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "CUIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre Empresa";
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.Location = new System.Drawing.Point(441, 368);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(210, 58);
            this.btnVerProveedores.TabIndex = 21;
            this.btnVerProveedores.Text = "Ver Proveedores";
            this.btnVerProveedores.UseVisualStyleBackColor = true;
            this.btnVerProveedores.Click += new System.EventHandler(this.btnVerProveedores_Click);
            // 
            // FormularioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.btnVerProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNombreEmpresa);
            this.Controls.Add(this.textCUIT);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAgregarEmpresa);
            this.Name = "FormularioProveedor";
            this.Text = "FormularioPorveedor";
            this.Load += new System.EventHandler(this.FormularioProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEmpresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCUIT;
        private System.Windows.Forms.TextBox textNombreEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerProveedores;
    }
}