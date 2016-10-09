namespace RegistroUsuario
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IdUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.NombretextBox10 = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox12 = new System.Windows.Forms.TextBox();
            this.ConfirmarContrasenatextBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Modificarbutton14 = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContrasenaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmarContrasenaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasenaerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarContrasenaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdUsuariotextBox
            // 
            this.IdUsuariotextBox.Location = new System.Drawing.Point(28, 54);
            this.IdUsuariotextBox.Name = "IdUsuariotextBox";
            this.IdUsuariotextBox.Size = new System.Drawing.Size(100, 24);
            this.IdUsuariotextBox.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Id";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(200, 28);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 48);
            this.button10.TabIndex = 2;
            this.button10.Text = "Buscar";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nombre";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // NombretextBox10
            // 
            this.NombretextBox10.Location = new System.Drawing.Point(29, 119);
            this.NombretextBox10.Name = "NombretextBox10";
            this.NombretextBox10.Size = new System.Drawing.Size(199, 24);
            this.NombretextBox10.TabIndex = 4;
            // 
            // ContrasenatextBox12
            // 
            this.ContrasenatextBox12.Location = new System.Drawing.Point(28, 180);
            this.ContrasenatextBox12.Name = "ContrasenatextBox12";
            this.ContrasenatextBox12.Size = new System.Drawing.Size(199, 24);
            this.ContrasenatextBox12.TabIndex = 5;
            // 
            // ConfirmarContrasenatextBox13
            // 
            this.ConfirmarContrasenatextBox13.Location = new System.Drawing.Point(28, 250);
            this.ConfirmarContrasenatextBox13.Name = "ConfirmarContrasenatextBox13";
            this.ConfirmarContrasenatextBox13.Size = new System.Drawing.Size(199, 24);
            this.ConfirmarContrasenatextBox13.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Contraseña";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(203, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Confirmar Contraseña";
            // 
            // Modificarbutton14
            // 
            this.Modificarbutton14.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificarbutton14.Image = ((System.Drawing.Image)(resources.GetObject("Modificarbutton14.Image")));
            this.Modificarbutton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificarbutton14.Location = new System.Drawing.Point(212, 318);
            this.Modificarbutton14.Name = "Modificarbutton14";
            this.Modificarbutton14.Size = new System.Drawing.Size(141, 44);
            this.Modificarbutton14.TabIndex = 9;
            this.Modificarbutton14.Text = "Modificar ";
            this.Modificarbutton14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modificarbutton14.UseVisualStyleBackColor = true;
            this.Modificarbutton14.Click += new System.EventHandler(this.Nuevobutton14_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Image = ((System.Drawing.Image)(resources.GetObject("Savebutton.Image")));
            this.Savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebutton.Location = new System.Drawing.Point(400, 318);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(131, 44);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Guardar";
            this.Savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.button15_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebutton.Location = new System.Drawing.Point(563, 318);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(131, 44);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // ContrasenaerrorProvider
            // 
            this.ContrasenaerrorProvider.ContainerControl = this;
            // 
            // ConfirmarContrasenaerrorProvider
            // 
            this.ConfirmarContrasenaerrorProvider.ContainerControl = this;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(40, 318);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(135, 44);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(756, 395);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Modificarbutton14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ConfirmarContrasenatextBox13);
            this.Controls.Add(this.ContrasenatextBox12);
            this.Controls.Add(this.NombretextBox10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.IdUsuariotextBox);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Registro Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasenaerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarContrasenaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox ContrasenatextBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IdUsuariotextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ConfirmarContrasenatextBox13;
        private System.Windows.Forms.TextBox ContrasenatextBox12;
        private System.Windows.Forms.TextBox NombretextBox10;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Modificarbutton14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider ContrasenaerrorProvider;
        private System.Windows.Forms.ErrorProvider ConfirmarContrasenaerrorProvider;
        private System.Windows.Forms.Button Nuevobutton;
    }
}

