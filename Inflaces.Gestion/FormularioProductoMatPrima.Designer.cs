namespace Inflaces.Gestion
{
    partial class FormularioProductoMatPrima
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
            this.cmboProducto = new System.Windows.Forms.ComboBox();
            this.txtCantNecesaria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductoMatPrima = new System.Windows.Forms.DataGridView();
            this.btnProduMatDelete = new System.Windows.Forms.Button();
            this.btnProduMatAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoMatPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboMatPrima
            // 
            this.cmboMatPrima.FormattingEnabled = true;
            this.cmboMatPrima.Location = new System.Drawing.Point(377, 60);
            this.cmboMatPrima.Name = "cmboMatPrima";
            this.cmboMatPrima.Size = new System.Drawing.Size(238, 28);
            this.cmboMatPrima.TabIndex = 14;
            this.cmboMatPrima.SelectedIndexChanged += new System.EventHandler(this.cmboMatPrima_SelectedIndexChanged);
            // 
            // cmboProducto
            // 
            this.cmboProducto.FormattingEnabled = true;
            this.cmboProducto.Location = new System.Drawing.Point(40, 58);
            this.cmboProducto.Name = "cmboProducto";
            this.cmboProducto.Size = new System.Drawing.Size(237, 28);
            this.cmboProducto.TabIndex = 15;
            // 
            // txtCantNecesaria
            // 
            this.txtCantNecesaria.Location = new System.Drawing.Point(693, 60);
            this.txtCantNecesaria.Name = "txtCantNecesaria";
            this.txtCantNecesaria.Size = new System.Drawing.Size(199, 26);
            this.txtCantNecesaria.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Materia Prima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad necesaria";
            // 
            // dgvProductoMatPrima
            // 
            this.dgvProductoMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoMatPrima.Location = new System.Drawing.Point(39, 232);
            this.dgvProductoMatPrima.Name = "dgvProductoMatPrima";
            this.dgvProductoMatPrima.RowHeadersWidth = 62;
            this.dgvProductoMatPrima.RowTemplate.Height = 28;
            this.dgvProductoMatPrima.Size = new System.Drawing.Size(853, 256);
            this.dgvProductoMatPrima.TabIndex = 22;
            // 
            // btnProduMatDelete
            // 
            this.btnProduMatDelete.Location = new System.Drawing.Point(556, 133);
            this.btnProduMatDelete.Name = "btnProduMatDelete";
            this.btnProduMatDelete.Size = new System.Drawing.Size(128, 64);
            this.btnProduMatDelete.TabIndex = 26;
            this.btnProduMatDelete.Text = "Eliminar";
            this.btnProduMatDelete.UseVisualStyleBackColor = true;
            this.btnProduMatDelete.Click += new System.EventHandler(this.btnProduMatDelete_Click_1);
            // 
            // btnProduMatAdd
            // 
            this.btnProduMatAdd.Location = new System.Drawing.Point(267, 133);
            this.btnProduMatAdd.Name = "btnProduMatAdd";
            this.btnProduMatAdd.Size = new System.Drawing.Size(127, 64);
            this.btnProduMatAdd.TabIndex = 25;
            this.btnProduMatAdd.Text = "Agregar";
            this.btnProduMatAdd.UseVisualStyleBackColor = true;
            this.btnProduMatAdd.Click += new System.EventHandler(this.btnProduMatAdd_Click_1);
            // 
            // FormularioProductoMatPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.btnProduMatDelete);
            this.Controls.Add(this.btnProduMatAdd);
            this.Controls.Add(this.dgvProductoMatPrima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantNecesaria);
            this.Controls.Add(this.cmboProducto);
            this.Controls.Add(this.cmboMatPrima);
            this.Name = "FormularioProductoMatPrima";
            this.Text = "FormularioProductoMatPrima";
            this.Load += new System.EventHandler(this.FormularioProductoMatPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoMatPrima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboMatPrima;
        private System.Windows.Forms.ComboBox cmboProducto;
        private System.Windows.Forms.TextBox txtCantNecesaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductoMatPrima;
        private System.Windows.Forms.Button btnProduMatDelete;
        private System.Windows.Forms.Button btnProduMatAdd;
    }
}