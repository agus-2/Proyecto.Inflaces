namespace Inflaces.Gestion
{
    partial class FormularioComprobanteCompraDetalle
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
            this.cmboMatPrima = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetalleModi = new System.Windows.Forms.Button();
            this.btnDetalleADD = new System.Windows.Forms.Button();
            this.txtCantidadCompro = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.dgvComprobanteDetalle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboMatPrima
            // 
            this.cmboMatPrima.FormattingEnabled = true;
            this.cmboMatPrima.Location = new System.Drawing.Point(32, 460);
            this.cmboMatPrima.Name = "cmboMatPrima";
            this.cmboMatPrima.Size = new System.Drawing.Size(228, 28);
            this.cmboMatPrima.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad";
            // 
            // btnDetalleModi
            // 
            this.btnDetalleModi.Location = new System.Drawing.Point(665, 336);
            this.btnDetalleModi.Name = "btnDetalleModi";
            this.btnDetalleModi.Size = new System.Drawing.Size(159, 64);
            this.btnDetalleModi.TabIndex = 16;
            this.btnDetalleModi.Text = "Modificar Item";
            this.btnDetalleModi.UseVisualStyleBackColor = true;
            this.btnDetalleModi.Click += new System.EventHandler(this.btnDetalleModi_Click);
            // 
            // btnDetalleADD
            // 
            this.btnDetalleADD.Location = new System.Drawing.Point(407, 336);
            this.btnDetalleADD.Name = "btnDetalleADD";
            this.btnDetalleADD.Size = new System.Drawing.Size(159, 64);
            this.btnDetalleADD.TabIndex = 15;
            this.btnDetalleADD.Text = "Agregar Item";
            this.btnDetalleADD.UseVisualStyleBackColor = true;
            this.btnDetalleADD.Click += new System.EventHandler(this.btnDetalleADD_Click);
            // 
            // txtCantidadCompro
            // 
            this.txtCantidadCompro.Location = new System.Drawing.Point(325, 462);
            this.txtCantidadCompro.Name = "txtCantidadCompro";
            this.txtCantidadCompro.Size = new System.Drawing.Size(190, 26);
            this.txtCantidadCompro.TabIndex = 14;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(564, 462);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(227, 26);
            this.txtPrecioUnitario.TabIndex = 13;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(839, 462);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(207, 26);
            this.txtSubtotal.TabIndex = 12;
            // 
            // dgvComprobanteDetalle
            // 
            this.dgvComprobanteDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobanteDetalle.Location = new System.Drawing.Point(12, 25);
            this.dgvComprobanteDetalle.Name = "dgvComprobanteDetalle";
            this.dgvComprobanteDetalle.RowHeadersWidth = 62;
            this.dgvComprobanteDetalle.RowTemplate.Height = 28;
            this.dgvComprobanteDetalle.Size = new System.Drawing.Size(1011, 267);
            this.dgvComprobanteDetalle.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Materia Prima";
            // 
            // FormularioComprobanteCompraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComprobanteDetalle);
            this.Controls.Add(this.cmboMatPrima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetalleModi);
            this.Controls.Add(this.btnDetalleADD);
            this.Controls.Add(this.txtCantidadCompro);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtSubtotal);
            this.Name = "FormularioComprobanteCompraDetalle";
            this.Text = "FormularioComprobanteCompraDetalle";
            this.Load += new System.EventHandler(this.FormularioComprobanteCompraDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboMatPrima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetalleModi;
        private System.Windows.Forms.Button btnDetalleADD;
        private System.Windows.Forms.TextBox txtCantidadCompro;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.DataGridView dgvComprobanteDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}