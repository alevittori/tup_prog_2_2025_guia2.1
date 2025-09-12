namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbDetalle = new System.Windows.Forms.ListBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(140, 34);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 49);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Empleado";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(347, 34);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(127, 49);
            this.btnLiquidar.TabIndex = 1;
            this.btnLiquidar.Text = "Generar Liquidaciones";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(554, 34);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(127, 49);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Liquidaciones";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbDetalle
            // 
            this.lbDetalle.FormattingEnabled = true;
            this.lbDetalle.Location = new System.Drawing.Point(33, 103);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(1309, 329);
            this.lbDetalle.TabIndex = 3;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(44, 34);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 49);
            this.btnPrueba.TabIndex = 4;
            this.btnPrueba.Text = "button1";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 450);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lbDetalle;
        private System.Windows.Forms.Button btnPrueba;
    }
}

