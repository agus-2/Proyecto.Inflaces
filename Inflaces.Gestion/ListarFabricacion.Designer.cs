namespace Inflaces.Gestion
{
    partial class ListarFabricacion
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
            this.btnDelCiclo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModiCiclo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelCiclo
            // 
            this.btnDelCiclo.Location = new System.Drawing.Point(500, 327);
            this.btnDelCiclo.Name = "btnDelCiclo";
            this.btnDelCiclo.Size = new System.Drawing.Size(177, 91);
            this.btnDelCiclo.TabIndex = 8;
            this.btnDelCiclo.Text = "Eliminar Ciclo de Fabricacion";
            this.btnDelCiclo.UseVisualStyleBackColor = true;
            this.btnDelCiclo.Click += new System.EventHandler(this.btnDelCiclo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 270);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnModiCiclo
            // 
            this.btnModiCiclo.Location = new System.Drawing.Point(133, 327);
            this.btnModiCiclo.Name = "btnModiCiclo";
            this.btnModiCiclo.Size = new System.Drawing.Size(177, 91);
            this.btnModiCiclo.TabIndex = 11;
            this.btnModiCiclo.Text = "Modificar Ciclo de Fabricacion";
            this.btnModiCiclo.UseVisualStyleBackColor = true;
            this.btnModiCiclo.Click += new System.EventHandler(this.btnModiCiclo_Click);
            // 
            // ListarFabricacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModiCiclo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelCiclo);
            this.Name = "ListarFabricacion";
            this.Text = "ListarFabricacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelCiclo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModiCiclo;
    }
}