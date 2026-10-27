namespace Inflaces.Gestion
{
    partial class FormularioComprobanteCompra
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
            this.txtNComprobante = new System.Windows.Forms.TextBox();
            this.txtTotalCompro = new System.Windows.Forms.TextBox();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnDetaComprobante = new System.Windows.Forms.Button();
            this.btnAgregarComprobante = new System.Windows.Forms.Button();
            this.btnModiComprobante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvComprobantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNComprobante
            // 
            this.txtNComprobante.Location = new System.Drawing.Point(633, 36);
            this.txtNComprobante.Name = "txtNComprobante";
            this.txtNComprobante.Size = new System.Drawing.Size(224, 26);
            this.txtNComprobante.TabIndex = 0;
            // 
            // txtTotalCompro
            // 
            this.txtTotalCompro.Location = new System.Drawing.Point(538, 112);
            this.txtTotalCompro.Name = "txtTotalCompro";
            this.txtTotalCompro.Size = new System.Drawing.Size(190, 26);
            this.txtTotalCompro.TabIndex = 1;
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.Location = new System.Drawing.Point(207, 112);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(190, 26);
            this.txtTipoComprobante.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowCheckBox = true;
            this.dtpFecha.Size = new System.Drawing.Size(277, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnDetaComprobante
            // 
            this.btnDetaComprobante.Location = new System.Drawing.Point(732, 457);
            this.btnDetaComprobante.Name = "btnDetaComprobante";
            this.btnDetaComprobante.Size = new System.Drawing.Size(159, 64);
            this.btnDetaComprobante.TabIndex = 4;
            this.btnDetaComprobante.Text = "Detalle Comprobantes";
            this.btnDetaComprobante.UseVisualStyleBackColor = true;
            this.btnDetaComprobante.Click += new System.EventHandler(this.btnDetaComprobante_Click);
            // 
            // btnAgregarComprobante
            // 
            this.btnAgregarComprobante.Location = new System.Drawing.Point(130, 457);
            this.btnAgregarComprobante.Name = "btnAgregarComprobante";
            this.btnAgregarComprobante.Size = new System.Drawing.Size(159, 64);
            this.btnAgregarComprobante.TabIndex = 5;
            this.btnAgregarComprobante.Text = "Agregar Comprobante";
            this.btnAgregarComprobante.UseVisualStyleBackColor = true;
            this.btnAgregarComprobante.Click += new System.EventHandler(this.btnAgregarComprobante_Click);
            // 
            // btnModiComprobante
            // 
            this.btnModiComprobante.Location = new System.Drawing.Point(438, 457);
            this.btnModiComprobante.Name = "btnModiComprobante";
            this.btnModiComprobante.Size = new System.Drawing.Size(159, 64);
            this.btnModiComprobante.TabIndex = 6;
            this.btnModiComprobante.Text = "Modificar Comprobante";
            this.btnModiComprobante.UseVisualStyleBackColor = true;
            this.btnModiComprobante.Click += new System.EventHandler(this.btnModiComprobante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de Comprobante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de Comprobante";
            // 
            // cmboProveedor
            // 
            this.cmboProveedor.FormattingEnabled = true;
            this.cmboProveedor.Location = new System.Drawing.Point(345, 34);
            this.cmboProveedor.Name = "cmboProveedor";
            this.cmboProveedor.Size = new System.Drawing.Size(228, 28);
            this.cmboProveedor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Proveedor";
            // 
            // dgvComprobantes
            // 
            this.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobantes.Location = new System.Drawing.Point(12, 153);
            this.dgvComprobantes.Name = "dgvComprobantes";
            this.dgvComprobantes.RowHeadersWidth = 62;
            this.dgvComprobantes.RowTemplate.Height = 28;
            this.dgvComprobantes.Size = new System.Drawing.Size(978, 267);
            this.dgvComprobantes.TabIndex = 13;
            // 
            // FormularioComprobanteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 550);
            this.Controls.Add(this.dgvComprobantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModiComprobante);
            this.Controls.Add(this.btnAgregarComprobante);
            this.Controls.Add(this.btnDetaComprobante);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTipoComprobante);
            this.Controls.Add(this.txtTotalCompro);
            this.Controls.Add(this.txtNComprobante);
            this.Name = "FormularioComprobanteCompra";
            this.Text = "ComprobanteCompra";
            this.Load += new System.EventHandler(this.FormularioComprobanteCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNComprobante;
        private System.Windows.Forms.TextBox txtTotalCompro;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnDetaComprobante;
        private System.Windows.Forms.Button btnAgregarComprobante;
        private System.Windows.Forms.Button btnModiComprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvComprobantes;
    }
}