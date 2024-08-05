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
            maskedTextBox_LEGAJO = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            cSharp = new CheckBox();
            checkBox_HTML = new CheckBox();
            checkBox_Js = new CheckBox();
            button_finalizarCarga = new Button();
            button_showData = new Button();
            button_exit = new Button();
            label5 = new Label();
            radioButton_ingeniarias = new RadioButton();
            radioButton_tecn = new RadioButton();
            panel_formulario = new Panel();
            panel_formulario.SuspendLayout();
            SuspendLayout();
            // 
            // cargarDatos
            // 
            cargarDatos.FlatStyle = FlatStyle.Flat;
            cargarDatos.Location = new Point(317, 24);
            cargarDatos.Name = "cargarDatos";
            cargarDatos.Size = new Size(110, 23);
            cargarDatos.TabIndex = 0;
            cargarDatos.Text = "Cargar Datos";
            cargarDatos.UseVisualStyleBackColor = true;
            cargarDatos.Click += cargarDatos_Click;
            // 
            // apellido
            // 
            apellido.Location = new Point(138, 18);
            apellido.Name = "apellido";
            apellido.Size = new Size(348, 23);
            apellido.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.Location = new Point(138, 47);
            nombre.Name = "nombre";
            nombre.Size = new Size(348, 23);
            nombre.TabIndex = 2;
            // 
            // maskedTextBoxFechaIngreso
            // 
            maskedTextBoxFechaIngreso.Location = new Point(138, 76);
            maskedTextBoxFechaIngreso.Mask = "00/00/0000";
            maskedTextBoxFechaIngreso.Name = "maskedTextBoxFechaIngreso";
            maskedTextBoxFechaIngreso.Size = new Size(348, 23);
            maskedTextBoxFechaIngreso.TabIndex = 3;
            maskedTextBoxFechaIngreso.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox_LEGAJO
            // 
            maskedTextBox_LEGAJO.Location = new Point(138, 105);
            maskedTextBox_LEGAJO.Mask = "99999";
            maskedTextBox_LEGAJO.Name = "maskedTextBox_LEGAJO";
            maskedTextBox_LEGAJO.Size = new Size(348, 23);
            maskedTextBox_LEGAJO.TabIndex = 4;
            maskedTextBox_LEGAJO.ValidatingType = typeof(int);
            maskedTextBox_LEGAJO.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(59, 16);
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
            label2.Location = new Point(57, 45);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(30, 74);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 7;
            label3.Text = "Año Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(71, 103);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 8;
            label4.Text = "Legajo";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(45, 246);
            label6.Name = "label6";
            label6.Size = new Size(204, 21);
            label6.TabIndex = 10;
            label6.Text = "Tecnologias que Conozco";
            // 
            // cSharp
            // 
            cSharp.AutoSize = true;
            cSharp.Location = new Point(258, 250);
            cSharp.Name = "cSharp";
            cSharp.Size = new Size(41, 19);
            cSharp.TabIndex = 11;
            cSharp.Text = "C#";
            cSharp.UseVisualStyleBackColor = true;
            // 
            // checkBox_HTML
            // 
            checkBox_HTML.AutoSize = true;
            checkBox_HTML.Location = new Point(322, 250);
            checkBox_HTML.Name = "checkBox_HTML";
            checkBox_HTML.Size = new Size(58, 19);
            checkBox_HTML.TabIndex = 12;
            checkBox_HTML.Text = "HTML";
            checkBox_HTML.UseVisualStyleBackColor = true;
            // 
            // checkBox_Js
            // 
            checkBox_Js.AutoSize = true;
            checkBox_Js.Location = new Point(403, 250);
            checkBox_Js.Name = "checkBox_Js";
            checkBox_Js.Size = new Size(81, 19);
            checkBox_Js.TabIndex = 13;
            checkBox_Js.Text = "Java Script";
            checkBox_Js.UseVisualStyleBackColor = true;
            // 
            // button_finalizarCarga
            // 
            button_finalizarCarga.FlatStyle = FlatStyle.Flat;
            button_finalizarCarga.Location = new Point(217, 302);
            button_finalizarCarga.Name = "button_finalizarCarga";
            button_finalizarCarga.Size = new Size(142, 23);
            button_finalizarCarga.TabIndex = 16;
            button_finalizarCarga.Text = "Finalizar Carga";
            button_finalizarCarga.UseVisualStyleBackColor = true;
            button_finalizarCarga.Click += button1_Click;
            // 
            // button_showData
            // 
            button_showData.FlatStyle = FlatStyle.Flat;
            button_showData.Location = new Point(276, 403);
            button_showData.Name = "button_showData";
            button_showData.Size = new Size(142, 23);
            button_showData.TabIndex = 17;
            button_showData.Text = "Mostrar Datos";
            button_showData.UseVisualStyleBackColor = true;
            button_showData.Click += button_showData_Click;
            // 
            // button_exit
            // 
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Location = new Point(688, 418);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 18;
            button_exit.Text = "Salir";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(126, 180);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 9;
            label5.Text = "Carrera";
            label5.Click += label5_Click;
            // 
            // radioButton_ingeniarias
            // 
            radioButton_ingeniarias.AutoSize = true;
            radioButton_ingeniarias.Location = new Point(205, 183);
            radioButton_ingeniarias.Name = "radioButton_ingeniarias";
            radioButton_ingeniarias.Size = new Size(82, 19);
            radioButton_ingeniarias.TabIndex = 14;
            radioButton_ingeniarias.TabStop = true;
            radioButton_ingeniarias.Text = "Ingenierias";
            radioButton_ingeniarias.UseVisualStyleBackColor = true;
            // 
            // radioButton_tecn
            // 
            radioButton_tecn.AutoSize = true;
            radioButton_tecn.Location = new Point(322, 183);
            radioButton_tecn.Name = "radioButton_tecn";
            radioButton_tecn.Size = new Size(90, 19);
            radioButton_tecn.TabIndex = 15;
            radioButton_tecn.TabStop = true;
            radioButton_tecn.Text = "Tecnicaturas";
            radioButton_tecn.UseVisualStyleBackColor = true;
            // 
            // panel_formulario
            // 
            panel_formulario.Controls.Add(radioButton_tecn);
            panel_formulario.Controls.Add(radioButton_ingeniarias);
            panel_formulario.Controls.Add(label5);
            panel_formulario.Controls.Add(button_finalizarCarga);
            panel_formulario.Controls.Add(checkBox_Js);
            panel_formulario.Controls.Add(checkBox_HTML);
            panel_formulario.Controls.Add(cSharp);
            panel_formulario.Controls.Add(label6);
            panel_formulario.Controls.Add(label4);
            panel_formulario.Controls.Add(label3);
            panel_formulario.Controls.Add(label2);
            panel_formulario.Controls.Add(label1);
            panel_formulario.Controls.Add(maskedTextBox_LEGAJO);
            panel_formulario.Controls.Add(maskedTextBoxFechaIngreso);
            panel_formulario.Controls.Add(nombre);
            panel_formulario.Controls.Add(apellido);
            panel_formulario.Location = new Point(59, 54);
            panel_formulario.Name = "panel_formulario";
            panel_formulario.Size = new Size(564, 343);
            panel_formulario.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_formulario);
            Controls.Add(button_exit);
            Controls.Add(cargarDatos);
            Controls.Add(button_showData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel_formulario.ResumeLayout(false);
            panel_formulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cargarDatos;
        private TextBox apellido;
        private TextBox nombre;
        private MaskedTextBox maskedTextBoxFechaIngreso;
        private MaskedTextBox maskedTextBox_LEGAJO;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private CheckBox cSharp;
        private CheckBox checkBox_HTML;
        private CheckBox checkBox_Js;
        private Button button_finalizarCarga;
        private Button button_showData;
        private Button button_exit;
        private Label label5;
        private RadioButton radioButton_ingeniarias;
        private RadioButton radioButton_tecn;
        private Panel panel_formulario;
    }
}
