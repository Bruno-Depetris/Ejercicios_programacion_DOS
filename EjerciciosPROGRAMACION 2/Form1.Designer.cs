namespace EjerciciosPROGRAMACION_2 {
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
            button_calcular = new Button();
            button_limpiar = new Button();
            button_salir = new Button();
            textBox_numerouno = new TextBox();
            textBox_numerodos = new TextBox();
            comboBox_operaciones = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label_resu = new Label();
            label5 = new Label();
            label_resultado = new Label();
            SuspendLayout();
            // 
            // button_calcular
            // 
            button_calcular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_calcular.BackColor = Color.MistyRose;
            button_calcular.FlatAppearance.MouseDownBackColor = Color.Red;
            button_calcular.FlatAppearance.MouseOverBackColor = Color.Lime;
            button_calcular.FlatStyle = FlatStyle.Flat;
            button_calcular.ForeColor = SystemColors.ControlText;
            button_calcular.Location = new Point(354, 408);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(167, 23);
            button_calcular.TabIndex = 0;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = false;
            button_calcular.Click += button1_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_limpiar.BackColor = Color.MistyRose;
            button_limpiar.FlatAppearance.MouseDownBackColor = Color.Red;
            button_limpiar.FlatAppearance.MouseOverBackColor = Color.Lime;
            button_limpiar.FlatStyle = FlatStyle.Flat;
            button_limpiar.ForeColor = SystemColors.ControlText;
            button_limpiar.Location = new Point(527, 408);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(167, 23);
            button_limpiar.TabIndex = 1;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = false;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_salir.BackColor = Color.MistyRose;
            button_salir.FlatAppearance.MouseDownBackColor = Color.Red;
            button_salir.FlatAppearance.MouseOverBackColor = Color.Lime;
            button_salir.FlatStyle = FlatStyle.Flat;
            button_salir.ForeColor = SystemColors.ControlText;
            button_salir.Location = new Point(181, 408);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(167, 23);
            button_salir.TabIndex = 2;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = false;
            button_salir.Click += button_salir_Click;
            // 
            // textBox_numerouno
            // 
            textBox_numerouno.Location = new Point(252, 213);
            textBox_numerouno.Name = "textBox_numerouno";
            textBox_numerouno.Size = new Size(336, 23);
            textBox_numerouno.TabIndex = 3;
            // 
            // textBox_numerodos
            // 
            textBox_numerodos.Location = new Point(252, 242);
            textBox_numerodos.Name = "textBox_numerodos";
            textBox_numerodos.Size = new Size(336, 23);
            textBox_numerodos.TabIndex = 4;
            // 
            // comboBox_operaciones
            // 
            comboBox_operaciones.FormattingEnabled = true;
            comboBox_operaciones.Items.AddRange(new object[] { "Seleccionar", "Multiplicacion", "Suma", "Resta", "Division" });
            comboBox_operaciones.Location = new Point(362, 305);
            comboBox_operaciones.Name = "comboBox_operaciones";
            comboBox_operaciones.Size = new Size(121, 23);
            comboBox_operaciones.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 213);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "Numero Uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 250);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Numero Dos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 308);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Operacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(294, 94);
            label4.Name = "label4";
            label4.Size = new Size(230, 54);
            label4.TabIndex = 8;
            label4.Text = "Calculadora";
            // 
            // label_resu
            // 
            label_resu.AutoSize = true;
            label_resu.Location = new Point(319, 354);
            label_resu.Name = "label_resu";
            label_resu.Size = new Size(62, 15);
            label_resu.TabIndex = 9;
            label_resu.Text = "Resultado:";
            label_resu.Click += label_resultado_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 354);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Location = new Point(387, 354);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(10, 15);
            label_resultado.TabIndex = 11;
            label_resultado.Text = ":";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(label_resultado);
            Controls.Add(label5);
            Controls.Add(label_resu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_operaciones);
            Controls.Add(textBox_numerodos);
            Controls.Add(textBox_numerouno);
            Controls.Add(button_salir);
            Controls.Add(button_limpiar);
            Controls.Add(button_calcular);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EjerciciosProgramacion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_calcular;
        private Button button_limpiar;
        private Button button_salir;
        private TextBox textBox_numerouno;
        private TextBox textBox_numerodos;
        private ComboBox comboBox_operaciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label_resu;
        private Label label5;
        private Label label_resultado;
    }
}
