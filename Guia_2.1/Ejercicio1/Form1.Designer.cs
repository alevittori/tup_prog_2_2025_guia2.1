namespace Ejercicio1
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
            this.lBoxDatosRegistro = new System.Windows.Forms.ListBox();
            this.lBoxListado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCargarPersona = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListarRegistros = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxDatosRegistro
            // 
            this.lBoxDatosRegistro.FormattingEnabled = true;
            this.lBoxDatosRegistro.ItemHeight = 16;
            this.lBoxDatosRegistro.Location = new System.Drawing.Point(16, 34);
            this.lBoxDatosRegistro.Name = "lBoxDatosRegistro";
            this.lBoxDatosRegistro.Size = new System.Drawing.Size(479, 164);
            this.lBoxDatosRegistro.TabIndex = 0;
            // 
            // lBoxListado
            // 
            this.lBoxListado.FormattingEnabled = true;
            this.lBoxListado.ItemHeight = 16;
            this.lBoxListado.Location = new System.Drawing.Point(16, 30);
            this.lBoxListado.Name = "lBoxListado";
            this.lBoxListado.Size = new System.Drawing.Size(479, 164);
            this.lBoxListado.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnCargarPersona);
            this.groupBox1.Controls.Add(this.lBoxDatosRegistro);
            this.groupBox1.Location = new System.Drawing.Point(26, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Registro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarRegistros);
            this.groupBox2.Controls.Add(this.lBoxListado);
            this.groupBox2.Location = new System.Drawing.Point(26, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 233);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Registros";
            // 
            // btnCargarPersona
            // 
            this.btnCargarPersona.Location = new System.Drawing.Point(528, 34);
            this.btnCargarPersona.Name = "btnCargarPersona";
            this.btnCargarPersona.Size = new System.Drawing.Size(195, 62);
            this.btnCargarPersona.TabIndex = 1;
            this.btnCargarPersona.Text = "Cargar Persona";
            this.btnCargarPersona.UseVisualStyleBackColor = true;
            this.btnCargarPersona.Click += new System.EventHandler(this.btnCargarPersona_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(528, 136);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(195, 62);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListarRegistros
            // 
            this.btnListarRegistros.Location = new System.Drawing.Point(528, 30);
            this.btnListarRegistros.Name = "btnListarRegistros";
            this.btnListarRegistros.Size = new System.Drawing.Size(195, 62);
            this.btnListarRegistros.TabIndex = 3;
            this.btnListarRegistros.Text = "Listar Registros";
            this.btnListarRegistros.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(560, 518);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(195, 62);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 592);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Automotor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxDatosRegistro;
        private System.Windows.Forms.ListBox lBoxListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCargarPersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListarRegistros;
        private System.Windows.Forms.Button btnSalir;
    }
}

