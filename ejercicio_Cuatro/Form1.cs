using System.Linq.Expressions;

namespace ejercicio_Cuatro {
    public partial class Form1 : Form {

        private string nombre = string.Empty;
        private int edad = 0;
        private string sexo = string.Empty;
        private string vehiculo = string.Empty;
        private int exp = 0;
        private int[] pagos = new int[3];

        public Form1() {
            InitializeComponent();
            comboBox_tipo.SelectedIndex = 0;
        }

        private void tomarDatos() {
            nombre = textBox_nombre.Text;

            if (!int.TryParse(numericUpDown_edad.Text, out edad)) {
                MessageBox.Show("Ingrese una edad válida");
                return;
            }

            if (!int.TryParse(numericUpDown_experiencia.Text, out exp)) {
                MessageBox.Show("Ingrese una experiencia válida");
                return;
            }
   
           
            if (radioButton_masculino.Checked) {
                sexo = "Masculino";
            } else if (radioButton_femenino.Checked) {  
                sexo = "Femenino";
            }
            else {
                MessageBox.Show("Ingrese una experiencia");
            }

            switch (comboBox_tipo.Text) {
                case "Sedan":
                case "SUV":
                case "Deportivo":
                    vehiculo = comboBox_tipo.Text;
                    break;
                default:
                    MessageBox.Show("Seleccione un tipo de vehículo válido");
                    return;
            }
        }

        private void Operaciones() {
            
            pagos = new int[3]; // Restablecer pagos a cero antes de realizar las operaciones

            if (sexo == "Masculino" && edad < 25) {
                pagos[0] = 1000;
            }
            else if (sexo == "Masculino" && edad >= 25) {
                pagos[0] = 700;
            }

            if (sexo == "Femenino" && edad < 21) {
                pagos[0] = 800;
            }
            else if (sexo == "Femenino" && edad >= 21) {
                pagos[0] = 1200;
            }

            switch (comboBox_tipo.Text) {
                case "SUV":
                    pagos[1] += 200;
                    break;
                case "Deportivo":
                    pagos[1] += 400;
                    break;
            }

            if (exp < 2) {
                pagos[2] += 300;
            }
            else if (exp > 5) {
                pagos[2] -= 150;  // Corrección aquí
            }
        }

        private void mostrarDatos() {
            // Colores para indicar ajustes
            if (pagos[0] > 0) {
                label_resultadoBase.Text = pagos[0].ToString();
                label_resultadoBase.ForeColor = Color.Green;
            }
            else {
                label_resultadoBase.Text = "0";
                label_resultadoBase.ForeColor = Color.Black;
            }

            if (pagos[1] != 0) {
                label_resultadoPV.Text = pagos[1].ToString();
                label_resultadoPV.ForeColor = Color.Green;
            }
            else {
                label_resultadoPV.Text = "0";
                label_resultadoPV.ForeColor = Color.Black;
            }

            if (pagos[2] != 0) {
                label_resultadoExp.Text = pagos[2].ToString();
                label_resultadoExp.ForeColor = Color.Green;
            }
            else {
                label_resultadoExp.Text = "0";
                label_resultadoExp.ForeColor = Color.Black;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void maskedTextBox_vehiculo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
        }

        private void label3_Click(object sender, EventArgs e) {
        }

        private void button_calcular_Click(object sender, EventArgs e) {
            tomarDatos();
            Operaciones();
            mostrarDatos();
        }

        private void button_limpiar_Click(object sender, EventArgs e) {
            // Limpiar los datos del formulario
            textBox_nombre.Clear();
            numericUpDown_edad.Value = 0;
            numericUpDown_experiencia.Value = 0;
            radioButton_masculino.Checked = false;
            radioButton_femenino.Checked = false;
            comboBox_tipo.SelectedIndex = 0;
            label_resultadoBase.Text = "0";
            label_resultadoPV.Text = "0";
            label_resultadoExp.Text = "0";

            label_resultadoBase.BackColor = Color.Empty;
            label_resultadoPV.BackColor = Color.Empty;
            label_resultadoExp.BackColor = Color.Empty;
        }
    }
}
