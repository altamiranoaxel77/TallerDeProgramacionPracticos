namespace Taller2TrabajosPracticos
{
    partial class Practico1
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.TxtventanaResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(159, 105);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(131, 20);
            this.TxtApellido.TabIndex = 0;
            this.TxtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(159, 157);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(131, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(112, 207);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(215, 207);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // TxtventanaResultado
            // 
            this.TxtventanaResultado.Location = new System.Drawing.Point(423, 68);
            this.TxtventanaResultado.Multiline = true;
            this.TxtventanaResultado.Name = "TxtventanaResultado";
            this.TxtventanaResultado.Size = new System.Drawing.Size(286, 222);
            this.TxtventanaResultado.TabIndex = 6;
            // 
            // Practico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.TxtventanaResultado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido);
            this.Name = "Practico1";
            this.Text = "Practico1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox TxtventanaResultado;
    }
}