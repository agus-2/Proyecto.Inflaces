namespace Inflaces.Gestion
{
    partial class FormularioMateriaPrima
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregarMateriaPrima = new System.Windows.Forms.Button();
            this.btnVerMateriasPrimas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(56, 122);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 25);
            this.textNombre.TabIndex = 3;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(56, 228);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(100, 25);
            this.textStock.TabIndex = 4;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(56, 355);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 25);
            this.textDescripcion.TabIndex = 5;
            // 
            // btnAgregarMateriaPrima
            // 
            this.btnAgregarMateriaPrima.Location = new System.Drawing.Point(645, 122);
            this.btnAgregarMateriaPrima.Name = "btnAgregarMateriaPrima";
            this.btnAgregarMateriaPrima.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMateriaPrima.TabIndex = 6;
            this.btnAgregarMateriaPrima.Text = "Agregar Materia Prima";
            this.btnAgregarMateriaPrima.UseVisualStyleBackColor = true;
            this.btnAgregarMateriaPrima.Click += new System.EventHandler(this.btnAgregarMateriaPrima_Click);
            // 
            // btnVerMateriasPrimas
            // 
            this.btnVerMateriasPrimas.Location = new System.Drawing.Point(645, 265);
            this.btnVerMateriasPrimas.Name = "btnVerMateriasPrimas";
            this.btnVerMateriasPrimas.Size = new System.Drawing.Size(75, 23);
            this.btnVerMateriasPrimas.TabIndex = 7;
            this.btnVerMateriasPrimas.Text = "Ver Materias Primas";
            this.btnVerMateriasPrimas.UseVisualStyleBackColor = true;
            this.btnVerMateriasPrimas.Click += new System.EventHandler(this.btnVerMateriasPrimas_Click);
            // 
            // FormularioMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerMateriasPrimas);
            this.Controls.Add(this.btnAgregarMateriaPrima);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioMateriaPrima";
            this.Text = "FormularioMateriaPrima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Button btnAgregarMateriaPrima;
        private System.Windows.Forms.Button btnVerMateriasPrimas;
    }
}