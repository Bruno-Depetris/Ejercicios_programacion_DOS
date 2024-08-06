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
                MessageBox.Show("ingrese una edad valida");
                return;
            }

            if (int.TryParse(numericUpDown_experiencia.Text, out exp)) { //valido el legajo
                MessageBox.Show("ingrese una edad valida");
                return;
            }


            if (radioButton_masculino.Checked) {
                sexo = "Masculino";
            }else if (radioButton_masculino.Checked) {
                sexo = "Femenino";
            }

            switch(comboBox_tipo.Text){
                case "Sedan":
                    vehiculo = comboBox_tipo.Text;

                    break;
                case "SUV":
                    vehiculo = comboBox_tipo.Text;

                    break;
                case "Deportivo":
                    vehiculo = comboBox_tipo.Text;

                    break;
            }
        }

        private void Operaciones() {

            if(sexo == "Masculino" && edad < 25) {
                pagos[0] = 1000;
            }
            if (sexo == "Masculino" && edad >= 25) {
                pagos[0] = 700;
            }
            if (sexo == "Femenino" && edad < 21) {
                pagos[0] = 800;
            }
            if (sexo == "Femenino" && edad >= 21) {
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
                pagos[3] = 150; //se resta

            }


        }
        private void mostrarDatos() {
            label_resultadoBase.Text = pagos[0].ToString();
   
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




        }
    }
}
