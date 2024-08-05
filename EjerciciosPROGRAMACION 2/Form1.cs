namespace EjerciciosPROGRAMACION_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            comboBox_operaciones.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {

            realizarOperacion(sender, e);

        }
        private void realizarOperacion(object sender, EventArgs e) {

            int data_box_uno = 0;
            int data_box_dos = 0;

            if (!int.TryParse(textBox_numerouno.Text, out data_box_uno)) {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el primer campo.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_numerouno.Focus();
                return;
            }

            if (!int.TryParse(textBox_numerodos.Text, out data_box_dos)) {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el segundo campo.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_numerodos.Focus();
                return;
            }

            int resultado = 0;
            string operacion = comboBox_operaciones.Text;
            switch (operacion) {
                case "Multiplicacion":

                    resultado = data_box_uno * data_box_dos;

                    break;

                case "Suma":
                    resultado = data_box_uno + data_box_dos;
                    break;

                case "Resta":
                    resultado = data_box_uno - data_box_dos;
                    break;

                case "Division":
                    if (data_box_dos != 0) {
                        resultado = data_box_uno / data_box_dos;

                    }
                    else {

                        label_resultado.Text = "Error al ingresar valores. Por favor ingrese numero valido";
                        return;
                    }
                    break;

            }

            label_resultado.Text = resultado.ToString();

        }






        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label_resultado_Click(object sender, EventArgs e) {

        }

        private void button_limpiar_Click(object sender, EventArgs e) {

            textBox_numerouno.Clear();
            textBox_numerodos.Clear();

            comboBox_operaciones.SelectedIndex = 0;

            label_resultado.Text = "";

        }

        private void button_salir_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
