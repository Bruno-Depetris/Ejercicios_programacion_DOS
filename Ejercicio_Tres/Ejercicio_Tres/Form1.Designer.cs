namespace Ejercicio_Tres {
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
            textBox_Salario = new TextBox();
            button_calcular = new Button();
            button_limpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label_mostrarSalario = new Label();
            SuspendLayout();
            // 
            // textBox_Salario
            // 
            textBox_Salario.BackColor = SystemColors.InactiveBorder;
            textBox_Salario.BorderStyle = BorderStyle.FixedSingle;
            textBox_Salario.Location = new Point(237, 173);
            textBox_Salario.Name = "textBox_Salario";
            textBox_Salario.Size = new Size(313, 23);
            textBox_Salario.TabIndex = 0;
            textBox_Salario.TextAlign = HorizontalAlignment.Center;
            textBox_Salario.TextChanged += textBox_Salario_TextChanged;
            // 
            // button_calcular
            // 
            button_calcular.Location = new Point(117, 217);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(216, 23);
            button_calcular.TabIndex = 1;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = true;
            // 
            // button_limpiar
            // 
            button_limpiar.Location = new Point(429, 217);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(216, 23);
            button_limpiar.TabIndex = 2;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 298);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Salario : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 298);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 4;
            label2.Text = "$";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 298);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 4;
            label3.Text = "$";
            label3.Click += label2_Click;
            // 
            // label_mostrarSalario
            // 
            label_mostrarSalario.AutoSize = true;
            label_mostrarSalario.Location = new Point(304, 298);
            label_mostrarSalario.Name = "label_mostrarSalario";
            label_mostrarSalario.Size = new Size(13, 15);
            label_mostrarSalario.TabIndex = 5;
            label_mostrarSalario.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_mostrarSalario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_limpiar);
            Controls.Add(button_calcular);
            Controls.Add(textBox_Salario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Salario;
        private Button button_calcular;
        private Button button_limpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_mostrarSalario;
    }
}
