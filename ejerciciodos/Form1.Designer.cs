namespace ejerciciodos {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            cargarDatos = new Button();
            apellido = new TextBox();
            nombre = new TextBox();
            maskedTextBoxFechaIngreso = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cargarDatos
            // 
            cargarDatos.Location = new Point(317, 24);
            cargarDatos.Name = "cargarDatos";
            cargarDatos.Size = new Size(110, 23);
            cargarDatos.TabIndex = 0;
            cargarDatos.Text = "Cargar Datos";
            cargarDatos.UseVisualStyleBackColor = true;
            // 
            // apellido
            // 
            apellido.Location = new Point(197, 72);
            apellido.Name = "apellido";
            apellido.Size = new Size(348, 23);
            apellido.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.Location = new Point(197, 101);
            nombre.Name = "nombre";
            nombre.Size = new Size(348, 23);
            nombre.TabIndex = 2;
            // 
            // maskedTextBoxFechaIngreso
            // 
            maskedTextBoxFechaIngreso.Location = new Point(197, 130);
            maskedTextBoxFechaIngreso.Mask = "00/00/0000";
            maskedTextBoxFechaIngreso.Name = "maskedTextBoxFechaIngreso";
            maskedTextBoxFechaIngreso.Size = new Size(348, 23);
            maskedTextBoxFechaIngreso.TabIndex = 3;
            maskedTextBoxFechaIngreso.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(197, 159);
            maskedTextBox1.Mask = "99999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(348, 23);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(118, 70);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(116, 99);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(89, 128);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 7;
            label3.Text = "Año Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(130, 157);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 8;
            label4.Text = "Legajo";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(104, 240);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 9;
            label5.Text = "Carrera";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(104, 300);
            label6.Name = "label6";
            label6.Size = new Size(204, 21);
            label6.TabIndex = 10;
            label6.Text = "Tecnologias que Conozco";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(maskedTextBoxFechaIngreso);
            Controls.Add(nombre);
            Controls.Add(apellido);
            Controls.Add(cargarDatos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cargarDatos;
        private TextBox apellido;
        private TextBox nombre;
        private MaskedTextBox maskedTextBoxFechaIngreso;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
