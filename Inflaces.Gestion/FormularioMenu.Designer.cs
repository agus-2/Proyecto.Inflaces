namespace Inflaces.Gestion
{
    partial class FormularioMenu
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
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMateriaPrima = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFabric = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnComprobanteCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(475, 49);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(133, 68);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(46, 46);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(133, 74);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(256, 46);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(125, 74);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnMateriaPrima
            // 
            this.btnMateriaPrima.Location = new System.Drawing.Point(248, 315);
            this.btnMateriaPrima.Name = "btnMateriaPrima";
            this.btnMateriaPrima.Size = new System.Drawing.Size(133, 76);
            this.btnMateriaPrima.TabIndex = 3;
            this.btnMateriaPrima.Text = "Materia Prima";
            this.btnMateriaPrima.UseVisualStyleBackColor = true;
            this.btnMateriaPrima.Click += new System.EventHandler(this.btnMateriaPrima_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(46, 315);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(135, 76);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFabric
            // 
            this.btnFabric.Location = new System.Drawing.Point(256, 179);
            this.btnFabric.Name = "btnFabric";
            this.btnFabric.Size = new System.Drawing.Size(125, 76);
            this.btnFabric.TabIndex = 6;
            this.btnFabric.Text = "Fabricacion";
            this.btnFabric.UseVisualStyleBackColor = true;
            this.btnFabric.Click += new System.EventHandler(this.btnFabric_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(46, 179);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(133, 76);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnComprobanteCompras
            // 
            this.btnComprobanteCompras.Location = new System.Drawing.Point(475, 179);
            this.btnComprobanteCompras.Name = "btnComprobanteCompras";
            this.btnComprobanteCompras.Size = new System.Drawing.Size(133, 76);
            this.btnComprobanteCompras.TabIndex = 10;
            this.btnComprobanteCompras.Text = "Comprobante Compras";
            this.btnComprobanteCompras.UseVisualStyleBackColor = true;
            this.btnComprobanteCompras.Click += new System.EventHandler(this.btnComprobanteCompras_Click);
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.btnComprobanteCompras);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnFabric);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnMateriaPrima);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProveedores);
            this.Name = "FormularioMenu";
            this.Text = "FormularioMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMateriaPrima;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFabric;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnComprobanteCompras;
    }
}