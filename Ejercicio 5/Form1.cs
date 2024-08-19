namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_BotonesAcciones.Enabled = false;

        }
        Datos Persona = new Datos();
        private void button_Cargar_Click(object sender, EventArgs e)
        {



            bool validacion = !string.IsNullOrWhiteSpace(textBox_Nombre.Text) &&
                           !string.IsNullOrWhiteSpace(textBox_Apellido.Text) &&
                           !string.IsNullOrWhiteSpace(textBox_Direccion.Text) &&
                           !int.IsNegative(int.Parse(textBox_Edad.Text)) &&
                           !string.IsNullOrWhiteSpace(textBox_Correo.Text) && textBox_Correo.Text.Trim().IndexOf('@') != -1 &&
                           System.Text.RegularExpressions.Regex.IsMatch(textBox_Nombre.Text, @"^[a-zA-Z\s]+$") &&
                           System.Text.RegularExpressions.Regex.IsMatch(textBox_Apellido.Text, @"^[a-zA-Z\s]+$") &&
                            System.Text.RegularExpressions.Regex.IsMatch(textBox_Edad.Text, @"^\d+$") &&
                           System.Text.RegularExpressions.Regex.IsMatch(textBox_Direccion.Text, @"^[a-zA-Z0-9\s]+$");



            if (validacion)
            {
                Persona.Nombre = textBox_Nombre.Text;
                Persona.Apellido = textBox_Apellido.Text;
                Persona.Edad = int.Parse(textBox_Edad.Text);
                Persona.Correo = textBox_Correo.Text;
                Persona.Direccion = textBox_Direccion.Text;



                panel_BotonesAcciones.Enabled = true;

                textBox_Nombre.Text = string.Empty;
                textBox_Apellido.Text = string.Empty;
                textBox_Edad.Text = string.Empty;
                textBox_Direccion.Text = string.Empty;
                textBox_Correo.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Hubo un error al momento de cargar");

            }


        }

        private void button_MostrarNombre_Click(object sender, EventArgs e)
        {
            Persona.MostrarNombre();
        }

        private void button_MostrarApellido_Click(object sender, EventArgs e)
        {
            Persona.MostrarApellido();
        }

        private void button_Saludar_Click(object sender, EventArgs e)
        {
            Persona.Saludar();
        }
    }


    public class Datos
    {
        public string Nombre = string.Empty;
        public string Apellido = string.Empty;
        public int Edad = 0;
        public string Correo = string.Empty;
        public string Direccion = string.Empty;

        public void MostrarNombre()
        {
            MessageBox.Show(Nombre);
        }

        public void MostrarApellido()
        {
            MessageBox.Show(Apellido);
        }
        public void Saludar()
        {
            MessageBox.Show($"Hola {Nombre} que tengas un buen dia");
        }

    }
}
