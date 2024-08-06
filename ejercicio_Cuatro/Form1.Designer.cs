namespace ejercicio_Cuatro {
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
            textBox_nombre = new TextBox();
            numericUpDown_edad = new NumericUpDown();
            radioButton_masculino = new RadioButton();
            radioButton_femenino = new RadioButton();
            comboBox_tipo = new ComboBox();
            numericUpDown_experiencia = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_calcular = new Button();
            button_limpiar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label_resultadoBase = new Label();
            label_resultadoPV = new Label();
            label_resultadoExp = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_edad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_experiencia).BeginInit();
            SuspendLayout();
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(64, 47);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(182, 23);
            textBox_nombre.TabIndex = 0;
            textBox_nombre.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown_edad
            // 
            numericUpDown_edad.Location = new Point(64, 76);
            numericUpDown_edad.Name = "numericUpDown_edad";
            numericUpDown_edad.Size = new Size(182, 23);
            numericUpDown_edad.TabIndex = 1;
            // 
            // radioButton_masculino
            // 
            radioButton_masculino.AutoSize = true;
            radioButton_masculino.Location = new Point(27, 125);
            radioButton_masculino.Name = "radioButton_masculino";
            radioButton_masculino.Size = new Size(80, 19);
            radioButton_masculino.TabIndex = 2;
            radioButton_masculino.TabStop = true;
            radioButton_masculino.Text = "Masculino";
            radioButton_masculino.UseVisualStyleBackColor = true;
            // 
            // radioButton_femenino
            // 
            radioButton_femenino.AutoSize = true;
            radioButton_femenino.Location = new Point(230, 125);
            radioButton_femenino.Name = "radioButton_femenino";
            radioButton_femenino.Size = new Size(78, 19);
            radioButton_femenino.TabIndex = 3;
            radioButton_femenino.TabStop = true;
            radioButton_femenino.Text = "Femenino";
            radioButton_femenino.UseVisualStyleBackColor = true;
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Items.AddRange(new object[] { "Seleccionar", "Sedan", "SUV", "Deportivo" });
            comboBox_tipo.Location = new Point(64, 174);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(182, 23);
            comboBox_tipo.TabIndex = 4;
            // 
            // numericUpDown_experiencia
            // 
            numericUpDown_experiencia.Font = new Font("Segoe UI", 9F);
            numericUpDown_experiencia.Location = new Point(64, 249);
            numericUpDown_experiencia.Name = "numericUpDown_experiencia";
            numericUpDown_experiencia.Size = new Size(182, 23);
            numericUpDown_experiencia.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 50);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 78);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 156);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Vehiculo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 231);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Experiencia";
            // 
            // button_calcular
            // 
            button_calcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            button_calcular.FlatAppearance.MouseOverBackColor = Color.Blue;
            button_calcular.FlatStyle = FlatStyle.Flat;
            button_calcular.Location = new Point(12, 415);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(140, 23);
            button_calcular.TabIndex = 10;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = true;
            button_calcular.Click += button_calcular_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            button_limpiar.FlatAppearance.MouseOverBackColor = Color.Blue;
            button_limpiar.FlatStyle = FlatStyle.Flat;
            button_limpiar.Location = new Point(168, 415);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(140, 23);
            button_limpiar.TabIndex = 11;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 12;
            label5.Text = "Arancel Base:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 341);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 13;
            label6.Text = "Ajuste por vehiculo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 379);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 14;
            label7.Text = "Ajuste por Experiencia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 304);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 15;
            label8.Text = "$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 341);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 16;
            label9.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(139, 379);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 17;
            label10.Text = "$";
            // 
            // label_resultadoBase
            // 
            label_resultadoBase.AutoSize = true;
            label_resultadoBase.Location = new Point(108, 304);
            label_resultadoBase.Name = "label_resultadoBase";
            label_resultadoBase.Size = new Size(13, 15);
            label_resultadoBase.TabIndex = 18;
            label_resultadoBase.Text = "0";
            // 
            // label_resultadoPV
            // 
            label_resultadoPV.AutoSize = true;
            label_resultadoPV.Location = new Point(139, 341);
            label_resultadoPV.Name = "label_resultadoPV";
            label_resultadoPV.Size = new Size(13, 15);
            label_resultadoPV.TabIndex = 19;
            label_resultadoPV.Text = "0";
            // 
            // label_resultadoExp
            // 
            label_resultadoExp.AutoSize = true;
            label_resultadoExp.Location = new Point(158, 379);
            label_resultadoExp.Name = "label_resultadoExp";
            label_resultadoExp.Size = new Size(13, 15);
            label_resultadoExp.TabIndex = 20;
            label_resultadoExp.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(label_resultadoExp);
            Controls.Add(label_resultadoPV);
            Controls.Add(label_resultadoBase);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button_limpiar);
            Controls.Add(button_calcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown_experiencia);
            Controls.Add(comboBox_tipo);
            Controls.Add(radioButton_femenino);
            Controls.Add(radioButton_masculino);
            Controls.Add(numericUpDown_edad);
            Controls.Add(textBox_nombre);
            Name = "Form1";
            Text = "Calculadora de seguros";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_edad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_experiencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_nombre;
        private NumericUpDown numericUpDown_edad;
        private RadioButton radioButton_masculino;
        private RadioButton radioButton_femenino;
        private ComboBox comboBox_tipo;
        private NumericUpDown numericUpDown_experiencia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_calcular;
        private Button button_limpiar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label_resultadoBase;
        private Label label_resultadoPV;
        private Label label_resultadoExp;
    }
}
