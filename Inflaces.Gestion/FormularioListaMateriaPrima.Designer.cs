namespace Inflaces.Gestion
{
    partial class FormularioListaMateriaPrima
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarMateriaPrima = new System.Windows.Forms.Button();
            this.btnEliminarMateriaPrima = new System.Windows.Forms.Button();
            this.btnMatPrimaProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(698, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnModificarMateriaPrima
            // 
            this.btnModificarMateriaPrima.Location = new System.Drawing.Point(489, 383);
            this.btnModificarMateriaPrima.Name = "btnModificarMateriaPrima";
            this.btnModificarMateriaPrima.Size = new System.Drawing.Size(161, 86);
            this.btnModificarMateriaPrima.TabIndex = 0;
            this.btnModificarMateriaPrima.Text = "Modificar Materia Prima";
            this.btnModificarMateriaPrima.UseVisualStyleBackColor = true;
            this.btnModificarMateriaPrima.Click += new System.EventHandler(this.btnModificarMateriaPrima_Click);
            // 
            // btnEliminarMateriaPrima
            // 
            this.btnEliminarMateriaPrima.Location = new System.Drawing.Point(45, 383);
            this.btnEliminarMateriaPrima.Name = "btnEliminarMateriaPrima";
            this.btnEliminarMateriaPrima.Size = new System.Drawing.Size(145, 86);
            this.btnEliminarMateriaPrima.TabIndex = 1;
            this.btnEliminarMateriaPrima.Text = "Eliminar Materia Prima";
            this.btnEliminarMateriaPrima.UseVisualStyleBackColor = true;
            this.btnEliminarMateriaPrima.Click += new System.EventHandler(this.btnEliminarMateriaPrima_Click);
            // 
            // btnMatPrimaProductos
            // 
            this.btnMatPrimaProductos.Location = new System.Drawing.Point(272, 410);
            this.btnMatPrimaProductos.Name = "btnMatPrimaProductos";
            this.btnMatPrimaProductos.Size = new System.Drawing.Size(133, 78);
            this.btnMatPrimaProductos.TabIndex = 8;
            this.btnMatPrimaProductos.Text = "Agregar a Productos";
            this.btnMatPrimaProductos.UseVisualStyleBackColor = true;
            this.btnMatPrimaProductos.Click += new System.EventHandler(this.btnMatPrimaProductos_Click);
            // 
            // FormularioListaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.btnMatPrimaProductos);
            this.Controls.Add(this.btnEliminarMateriaPrima);
            this.Controls.Add(this.btnModificarMateriaPrima);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormularioListaMateriaPrima";
            this.Text = "FormularioListaMateriaPrima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarMateriaPrima;
        private System.Windows.Forms.Button btnEliminarMateriaPrima;
        private System.Windows.Forms.Button btnMatPrimaProductos;
    }
}