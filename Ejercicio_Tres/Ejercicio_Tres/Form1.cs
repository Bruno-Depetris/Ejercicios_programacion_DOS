namespace Ejercicio_Tres {
    public partial class Form1 : Form {
        private int salario = 0;
        private int horas = 0;

        private int resultado = 0;

        public Form1() {
            InitializeComponent();
        }
        private void operaciones() {
            switch (horas) {
                case <= 40:
                    salario = 150;
                    resultado = horas * salario;
                    break;

                case >= 40:
                    horas = horas - 40;
                    salario = 250;
                    resultado = horas * salario + 6000;
                    break;

            }



            label_mostrarSalario.Text = resultado.ToString();
        }
        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox_Salario_TextChanged(object sender, EventArgs e) {


        }

        private void button_calcular_Click(object sender, EventArgs e) {
            if (!int.TryParse(textBox_Salario.Text, out horas)) { //valido el legajo
                MessageBox.Show("Ingrese el formato valido.");
                return;
            }
            operaciones();

        }

        private void button_limpiar_Click(object sender, EventArgs e) {
            textBox_Salario.Clear();
            label_mostrarSalario.Text = "0";
        }
    }
}
