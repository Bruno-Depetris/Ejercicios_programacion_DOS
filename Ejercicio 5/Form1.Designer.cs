namespace Ejercicio_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Nombre = new TextBox();
            textBox_Apellido = new TextBox();
            textBox_Edad = new TextBox();
            textBox_Correo = new TextBox();
            textBox_Direccion = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_Cargar = new Button();
            button_MostrarNombre = new Button();
            button_MostrarApellido = new Button();
            button_Saludar = new Button();
            panel_BotonesAcciones = new Panel();
            panel_textBox = new Panel();
            panel_BotonesAcciones.SuspendLayout();
            panel_textBox.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.BorderStyle = BorderStyle.FixedSingle;
            textBox_Nombre.Location = new Point(7, 19);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(237, 23);
            textBox_Nombre.TabIndex = 0;
            // 
            // textBox_Apellido
            // 
            textBox_Apellido.BorderStyle = BorderStyle.FixedSingle;
            textBox_Apellido.Location = new Point(7, 48);
            textBox_Apellido.Name = "textBox_Apellido";
            textBox_Apellido.Size = new Size(237, 23);
            textBox_Apellido.TabIndex = 1;
            // 
            // textBox_Edad
            // 
            textBox_Edad.BorderStyle = BorderStyle.FixedSingle;
            textBox_Edad.Location = new Point(7, 77);
            textBox_Edad.Name = "textBox_Edad";
            textBox_Edad.Size = new Size(237, 23);
            textBox_Edad.TabIndex = 2;
            // 
            // textBox_Correo
            // 
            textBox_Correo.BorderStyle = BorderStyle.FixedSingle;
            textBox_Correo.Location = new Point(7, 106);
            textBox_Correo.Name = "textBox_Correo";
            textBox_Correo.Size = new Size(237, 23);
            textBox_Correo.TabIndex = 3;
            // 
            // textBox_Direccion
            // 
            textBox_Direccion.BorderStyle = BorderStyle.FixedSingle;
            textBox_Direccion.Location = new Point(7, 135);
            textBox_Direccion.Name = "textBox_Direccion";
            textBox_Direccion.Size = new Size(237, 23);
            textBox_Direccion.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(197, 99);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 128);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 157);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 186);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 215);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Direccion";
            // 
            // button_Cargar
            // 
            button_Cargar.BackColor = SystemColors.ButtonHighlight;
            button_Cargar.FlatStyle = FlatStyle.Flat;
            button_Cargar.Location = new Point(360, 248);
            button_Cargar.Name = "button_Cargar";
            button_Cargar.Size = new Size(75, 23);
            button_Cargar.TabIndex = 10;
            button_Cargar.Text = "Cargar";
            button_Cargar.UseVisualStyleBackColor = false;
            button_Cargar.Click += button_Cargar_Click;
            // 
            // button_MostrarNombre
            // 
            button_MostrarNombre.BackColor = SystemColors.ButtonHighlight;
            button_MostrarNombre.FlatStyle = FlatStyle.Flat;
            button_MostrarNombre.Location = new Point(38, 13);
            button_MostrarNombre.Name = "button_MostrarNombre";
            button_MostrarNombre.Size = new Size(237, 23);
            button_MostrarNombre.TabIndex = 11;
            button_MostrarNombre.Text = "Mostrar Nombre";
            button_MostrarNombre.UseVisualStyleBackColor = false;
            button_MostrarNombre.Click += button_MostrarNombre_Click;
            // 
            // button_MostrarApellido
            // 
            button_MostrarApellido.BackColor = SystemColors.ButtonHighlight;
            button_MostrarApellido.FlatStyle = FlatStyle.Flat;
            button_MostrarApellido.Location = new Point(38, 42);
            button_MostrarApellido.Name = "button_MostrarApellido";
            button_MostrarApellido.Size = new Size(237, 23);
            button_MostrarApellido.TabIndex = 12;
            button_MostrarApellido.Text = "Mostrar Apellido";
            button_MostrarApellido.UseVisualStyleBackColor = false;
            button_MostrarApellido.Click += button_MostrarApellido_Click;
            // 
            // button_Saludar
            // 
            button_Saludar.BackColor = SystemColors.ButtonHighlight;
            button_Saludar.FlatStyle = FlatStyle.Flat;
            button_Saludar.Location = new Point(38, 71);
            button_Saludar.Name = "button_Saludar";
            button_Saludar.Size = new Size(237, 23);
            button_Saludar.TabIndex = 13;
            button_Saludar.Text = "Saludar";
            button_Saludar.UseVisualStyleBackColor = false;
            button_Saludar.Click += button_Saludar_Click;
            // 
            // panel_BotonesAcciones
            // 
            panel_BotonesAcciones.Controls.Add(button_Saludar);
            panel_BotonesAcciones.Controls.Add(button_MostrarApellido);
            panel_BotonesAcciones.Controls.Add(button_MostrarNombre);
            panel_BotonesAcciones.Location = new Point(240, 277);
            panel_BotonesAcciones.Name = "panel_BotonesAcciones";
            panel_BotonesAcciones.Size = new Size(312, 110);
            panel_BotonesAcciones.TabIndex = 14;
            // 
            // panel_textBox
            // 
            panel_textBox.Controls.Add(textBox_Direccion);
            panel_textBox.Controls.Add(textBox_Correo);
            panel_textBox.Controls.Add(textBox_Edad);
            panel_textBox.Controls.Add(textBox_Apellido);
            panel_textBox.Controls.Add(textBox_Nombre);
            panel_textBox.Location = new Point(271, 78);
            panel_textBox.Name = "panel_textBox";
            panel_textBox.Size = new Size(254, 167);
            panel_textBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_textBox);
            Controls.Add(panel_BotonesAcciones);
            Controls.Add(button_Cargar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Name = "Form1";
            Text = "Form1";
            panel_BotonesAcciones.ResumeLayout(false);
            panel_textBox.ResumeLayout(false);
            panel_textBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Nombre;
        private TextBox textBox_Apellido;
        private TextBox textBox_Edad;
        private TextBox textBox_Correo;
        private TextBox textBox_Direccion;
        private Label Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_Cargar;
        private Button button_MostrarNombre;
        private Button button_MostrarApellido;
        private Button button_Saludar;
        private Panel panel_BotonesAcciones;
        private Panel panel_textBox;
    }
}
