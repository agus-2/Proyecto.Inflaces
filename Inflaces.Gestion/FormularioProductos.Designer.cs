namespace Inflaces.Gestion
{
    partial class FormularioProducto
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
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textTalle = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Location = new System.Drawing.Point(332, 81);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(42, 20);
            this.lblTalle.TabIndex = 0;
            this.lblTalle.Text = "Talle";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(88, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(195, 307);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(332, 182);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 20);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(97, 182);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(47, 130);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(152, 26);
            this.textNombre.TabIndex = 5;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(152, 376);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(179, 26);
            this.textDescripcion.TabIndex = 6;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(284, 220);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(152, 26);
            this.textStock.TabIndex = 7;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(47, 220);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(152, 26);
            this.textPrecio.TabIndex = 8;
            // 
            // textTalle
            // 
            this.textTalle.Location = new System.Drawing.Point(284, 130);
            this.textTalle.Name = "textTalle";
            this.textTalle.Size = new System.Drawing.Size(152, 26);
            this.textTalle.TabIndex = 9;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(513, 81);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(148, 77);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(513, 320);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(148, 83);
            this.btnVerProductos.TabIndex = 11;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // FormularioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.textTalle);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTalle);
            this.Name = "FormularioProducto";
            this.Text = "FormularioProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textTalle;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnVerProductos;
    }
}