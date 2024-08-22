namespace Taller2TrabajosPracticos
{
    partial class Pequeño_Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pequeño_Formulario));
            this.LDni = new System.Windows.Forms.Label();
            this.Lapellido = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.lmodificar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tdni = new System.Windows.Forms.TextBox();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckMastercard = new System.Windows.Forms.CheckBox();
            this.CheckVisa = new System.Windows.Forms.CheckBox();
            this.CheckNaranja = new System.Windows.Forms.CheckBox();
            this.LtarjetasCredito = new System.Windows.Forms.Label();
            this.Ttelefono = new System.Windows.Forms.TextBox();
            this.Ltelefono = new System.Windows.Forms.Label();
            this.Varon = new System.Windows.Forms.RadioButton();
            this.Mujer = new System.Windows.Forms.RadioButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TGuardar = new System.Windows.Forms.Button();
            this.TEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(33, 57);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "* DNI";
            this.LDni.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lapellido
            // 
            this.Lapellido.AutoSize = true;
            this.Lapellido.Location = new System.Drawing.Point(33, 93);
            this.Lapellido.Name = "Lapellido";
            this.Lapellido.Size = new System.Drawing.Size(51, 13);
            this.Lapellido.TabIndex = 1;
            this.Lapellido.Text = "* Apellido";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(33, 131);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(51, 13);
            this.Lnombre.TabIndex = 2;
            this.Lnombre.Text = "* Nombre";
            // 
            // lmodificar
            // 
            this.lmodificar.AutoSize = true;
            this.lmodificar.ForeColor = System.Drawing.Color.Red;
            this.lmodificar.Location = new System.Drawing.Point(159, 20);
            this.lmodificar.Name = "lmodificar";
            this.lmodificar.Size = new System.Drawing.Size(49, 13);
            this.lmodificar.TabIndex = 3;
            this.lmodificar.Text = "modificar";
            this.lmodificar.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre y Apellido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tdni
            // 
            this.Tdni.Location = new System.Drawing.Point(118, 54);
            this.Tdni.Name = "Tdni";
            this.Tdni.Size = new System.Drawing.Size(122, 20);
            this.Tdni.TabIndex = 5;
            this.Tdni.TextChanged += new System.EventHandler(this.Tdni_TextChanged);
            this.Tdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tdni_KeyPress);
            // 
            // Tapellido
            // 
            this.Tapellido.Location = new System.Drawing.Point(118, 90);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(122, 20);
            this.Tapellido.TabIndex = 6;
            this.Tapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tapellido_KeyPress);
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(118, 128);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(122, 20);
            this.Tnombre.TabIndex = 7;
            this.Tnombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Tnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tnombre_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.CheckMastercard);
            this.panel1.Controls.Add(this.CheckVisa);
            this.panel1.Controls.Add(this.CheckNaranja);
            this.panel1.Controls.Add(this.LtarjetasCredito);
            this.panel1.Controls.Add(this.Ttelefono);
            this.panel1.Controls.Add(this.Ltelefono);
            this.panel1.Controls.Add(this.Tdni);
            this.panel1.Controls.Add(this.Tapellido);
            this.panel1.Controls.Add(this.Tnombre);
            this.panel1.Controls.Add(this.Lnombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lapellido);
            this.panel1.Controls.Add(this.lmodificar);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Location = new System.Drawing.Point(39, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 272);
            this.panel1.TabIndex = 10;
            // 
            // CheckMastercard
            // 
            this.CheckMastercard.AutoSize = true;
            this.CheckMastercard.Location = new System.Drawing.Point(138, 245);
            this.CheckMastercard.Name = "CheckMastercard";
            this.CheckMastercard.Size = new System.Drawing.Size(79, 17);
            this.CheckMastercard.TabIndex = 15;
            this.CheckMastercard.Text = "Mastercard";
            this.CheckMastercard.UseVisualStyleBackColor = true;
            // 
            // CheckVisa
            // 
            this.CheckVisa.AutoSize = true;
            this.CheckVisa.Location = new System.Drawing.Point(138, 225);
            this.CheckVisa.Name = "CheckVisa";
            this.CheckVisa.Size = new System.Drawing.Size(46, 17);
            this.CheckVisa.TabIndex = 14;
            this.CheckVisa.Text = "Visa";
            this.CheckVisa.UseMnemonic = false;
            this.CheckVisa.UseVisualStyleBackColor = false;
            this.CheckVisa.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CheckNaranja
            // 
            this.CheckNaranja.AutoSize = true;
            this.CheckNaranja.Location = new System.Drawing.Point(138, 202);
            this.CheckNaranja.Name = "CheckNaranja";
            this.CheckNaranja.Size = new System.Drawing.Size(63, 17);
            this.CheckNaranja.TabIndex = 13;
            this.CheckNaranja.Text = "Naranja";
            this.CheckNaranja.UseVisualStyleBackColor = true;
            this.CheckNaranja.CheckedChanged += new System.EventHandler(this.CheckNaranja_CheckedChanged);
            // 
            // LtarjetasCredito
            // 
            this.LtarjetasCredito.AutoSize = true;
            this.LtarjetasCredito.Location = new System.Drawing.Point(33, 203);
            this.LtarjetasCredito.Name = "LtarjetasCredito";
            this.LtarjetasCredito.Size = new System.Drawing.Size(98, 13);
            this.LtarjetasCredito.TabIndex = 12;
            this.LtarjetasCredito.Text = "Tarjeta de creditos:";
            // 
            // Ttelefono
            // 
            this.Ttelefono.Location = new System.Drawing.Point(118, 166);
            this.Ttelefono.Name = "Ttelefono";
            this.Ttelefono.Size = new System.Drawing.Size(122, 20);
            this.Ttelefono.TabIndex = 11;
            this.Ttelefono.TextChanged += new System.EventHandler(this.Ttelefono_TextChanged);
            this.Ttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ttelefono_KeyPress);
            // 
            // Ltelefono
            // 
            this.Ltelefono.AutoSize = true;
            this.Ltelefono.Location = new System.Drawing.Point(33, 169);
            this.Ltelefono.Name = "Ltelefono";
            this.Ltelefono.Size = new System.Drawing.Size(49, 13);
            this.Ltelefono.TabIndex = 10;
            this.Ltelefono.Text = "Telefono";
            // 
            // Varon
            // 
            this.Varon.AutoSize = true;
            this.Varon.Location = new System.Drawing.Point(416, 191);
            this.Varon.Name = "Varon";
            this.Varon.Size = new System.Drawing.Size(53, 17);
            this.Varon.TabIndex = 12;
            this.Varon.TabStop = true;
            this.Varon.Text = "Varon";
            this.Varon.UseVisualStyleBackColor = true;
            this.Varon.CheckedChanged += new System.EventHandler(this.Varon_CheckedChanged);
            // 
            // Mujer
            // 
            this.Mujer.AutoSize = true;
            this.Mujer.Location = new System.Drawing.Point(498, 191);
            this.Mujer.Name = "Mujer";
            this.Mujer.Size = new System.Drawing.Size(51, 17);
            this.Mujer.TabIndex = 13;
            this.Mujer.TabStop = true;
            this.Mujer.Text = "Mujer";
            this.Mujer.UseVisualStyleBackColor = true;
            this.Mujer.CheckedChanged += new System.EventHandler(this.Mujer_CheckedChanged);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Titulo.Location = new System.Drawing.Point(219, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(178, 29);
            this.Titulo.TabIndex = 14;
            this.Titulo.Text = "Nuevo Cliente";
            this.Titulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::Taller2TrabajosPracticos.Properties.Resources.salir_nuevo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(440, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TGuardar
            // 
            this.TGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TGuardar.Image")));
            this.TGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TGuardar.Location = new System.Drawing.Point(91, 402);
            this.TGuardar.Name = "TGuardar";
            this.TGuardar.Size = new System.Drawing.Size(132, 57);
            this.TGuardar.TabIndex = 8;
            this.TGuardar.Text = "Guardar";
            this.TGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TGuardar.UseVisualStyleBackColor = true;
            this.TGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEliminar
            // 
            this.TEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TEliminar.Image")));
            this.TEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TEliminar.Location = new System.Drawing.Point(265, 402);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(132, 57);
            this.TEliminar.TabIndex = 9;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // Pequeño_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Mujer);
            this.Controls.Add(this.Varon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TEliminar);
            this.Name = "Pequeño_Formulario";
            this.Text = "Pequeño_Formulario";
            this.Load += new System.EventHandler(this.Pequeño_Formulario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label Lapellido;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Label lmodificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tdni;
        private System.Windows.Forms.TextBox Tapellido;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.Button TGuardar;
        private System.Windows.Forms.Button TEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Varon;
        private System.Windows.Forms.RadioButton Mujer;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox Ttelefono;
        private System.Windows.Forms.Label Ltelefono;
        private System.Windows.Forms.CheckBox CheckMastercard;
        private System.Windows.Forms.CheckBox CheckVisa;
        private System.Windows.Forms.CheckBox CheckNaranja;
        private System.Windows.Forms.Label LtarjetasCredito;
        private System.Windows.Forms.Button button1;
    }
}