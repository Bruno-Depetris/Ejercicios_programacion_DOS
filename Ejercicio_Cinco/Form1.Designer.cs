namespace Ejercicio_Cinco
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
            panel_TextBoxCargar = new Panel();
            groupBox1 = new GroupBox();
            button_Guardar = new Button();
            textBox_Nota = new TextBox();
            textBox_Nombre = new TextBox();
            Nota = new Label();
            label1 = new Label();
            panel_main = new Panel();
            button_Calcular = new Button();
            panel_TextBoxCargar.SuspendLayout();
            groupBox1.SuspendLayout();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_TextBoxCargar
            // 
            panel_TextBoxCargar.Controls.Add(groupBox1);
            panel_TextBoxCargar.Location = new Point(221, 90);
            panel_TextBoxCargar.Name = "panel_TextBoxCargar";
            panel_TextBoxCargar.Size = new Size(345, 215);
            panel_TextBoxCargar.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Guardar);
            groupBox1.Controls.Add(textBox_Nota);
            groupBox1.Controls.Add(textBox_Nombre);
            groupBox1.Controls.Add(Nota);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carga Calificaciones";
            // 
            // button_Guardar
            // 
            button_Guardar.Location = new Point(118, 131);
            button_Guardar.Name = "button_Guardar";
            button_Guardar.Size = new Size(75, 23);
            button_Guardar.TabIndex = 4;
            button_Guardar.Text = "Guardar";
            button_Guardar.UseVisualStyleBackColor = true;
            button_Guardar.Click += button_Guardar_Click;
            // 
            // textBox_Nota
            // 
            textBox_Nota.Location = new Point(84, 82);
            textBox_Nota.Name = "textBox_Nota";
            textBox_Nota.Size = new Size(211, 23);
            textBox_Nota.TabIndex = 3;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(84, 39);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(211, 23);
            textBox_Nombre.TabIndex = 2;
            // 
            // Nota
            // 
            Nota.AutoSize = true;
            Nota.Location = new Point(45, 85);
            Nota.Name = "Nota";
            Nota.Size = new Size(33, 15);
            Nota.TabIndex = 1;
            Nota.Text = "Nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel_main
            // 
            panel_main.Controls.Add(button_Calcular);
            panel_main.Controls.Add(panel_TextBoxCargar);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(800, 450);
            panel_main.TabIndex = 6;
            // 
            // button_Calcular
            // 
            button_Calcular.Location = new Point(326, 342);
            button_Calcular.Name = "button_Calcular";
            button_Calcular.Size = new Size(139, 37);
            button_Calcular.TabIndex = 7;
            button_Calcular.Text = "Calcular";
            button_Calcular.UseVisualStyleBackColor = true;
            button_Calcular.Click += button_Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_main);
            Name = "Form1";
            Text = "Form1";
            panel_TextBoxCargar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_TextBoxCargar;
        private GroupBox groupBox1;
        private Button button_Guardar;
        private TextBox textBox_Nota;
        private TextBox textBox_Nombre;
        private Label Nota;
        private Label label1;
        private Panel panel_main;
        private Button button_Calcular;
    }
}
