namespace Inflaces.Gestion
{
    partial class FormularioFabricacion
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
            this.btnCrearCiclo = new System.Windows.Forms.Button();
            this.btnVerCiclos = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadCiclo = new System.Windows.Forms.TextBox();
            this.txtEstadoCiclo = new System.Windows.Forms.TextBox();
            this.cmboEmpleado = new System.Windows.Forms.ComboBox();
            this.cmboProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearCiclo
            // 
            this.btnCrearCiclo.Location = new System.Drawing.Point(186, 334);
            this.btnCrearCiclo.Name = "btnCrearCiclo";
            this.btnCrearCiclo.Size = new System.Drawing.Size(172, 81);
            this.btnCrearCiclo.TabIndex = 5;
            this.btnCrearCiclo.Text = "Crear Ciclo de Fabricacion";
            this.btnCrearCiclo.UseVisualStyleBackColor = true;
            this.btnCrearCiclo.Click += new System.EventHandler(this.btnCrearCiclo_Click);
            // 
            // btnVerCiclos
            // 
            this.btnVerCiclos.Location = new System.Drawing.Point(452, 334);
            this.btnVerCiclos.Name = "btnVerCiclos";
            this.btnVerCiclos.Size = new System.Drawing.Size(167, 81);
            this.btnVerCiclos.TabIndex = 6;
            this.btnVerCiclos.Text = "Ver Ciclos de Fabricacion";
            this.btnVerCiclos.UseVisualStyleBackColor = true;
            this.btnVerCiclos.Click += new System.EventHandler(this.btnVerCiclos_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(62, 147);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpInicio.TabIndex = 8;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(62, 228);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 9;
            // 
            // txtCantidadCiclo
            // 
            this.txtCantidadCiclo.Location = new System.Drawing.Point(450, 147);
            this.txtCantidadCiclo.Name = "txtCantidadCiclo";
            this.txtCantidadCiclo.Size = new System.Drawing.Size(236, 26);
            this.txtCantidadCiclo.TabIndex = 10;
            // 
            // txtEstadoCiclo
            // 
            this.txtEstadoCiclo.Location = new System.Drawing.Point(450, 244);
            this.txtEstadoCiclo.Name = "txtEstadoCiclo";
            this.txtEstadoCiclo.Size = new System.Drawing.Size(236, 26);
            this.txtEstadoCiclo.TabIndex = 11;
            // 
            // cmboEmpleado
            // 
            this.cmboEmpleado.FormattingEnabled = true;
            this.cmboEmpleado.Location = new System.Drawing.Point(450, 51);
            this.cmboEmpleado.Name = "cmboEmpleado";
            this.cmboEmpleado.Size = new System.Drawing.Size(247, 28);
            this.cmboEmpleado.TabIndex = 12;
            // 
            // cmboProducto
            // 
            this.cmboProducto.FormattingEnabled = true;
            this.cmboProducto.Location = new System.Drawing.Point(76, 51);
            this.cmboProducto.Name = "cmboProducto";
            this.cmboProducto.Size = new System.Drawing.Size(247, 28);
            this.cmboProducto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fecha Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha Fin";
            // 
            // FormularioFabricacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboProducto);
            this.Controls.Add(this.cmboEmpleado);
            this.Controls.Add(this.txtEstadoCiclo);
            this.Controls.Add(this.txtCantidadCiclo);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnVerCiclos);
            this.Controls.Add(this.btnCrearCiclo);
            this.Name = "FormularioFabricacion";
            this.Text = "Fabricacion";
            this.Load += new System.EventHandler(this.FormularioFabricacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCiclo;
        private System.Windows.Forms.Button btnVerCiclos;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtCantidadCiclo;
        private System.Windows.Forms.TextBox txtEstadoCiclo;
        private System.Windows.Forms.ComboBox cmboEmpleado;
        private System.Windows.Forms.ComboBox cmboProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}