using System.Xml;

namespace Ejercicio_Cinco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < Alumno.Length; i++)
            {
                Alumno[i] = new GestionAlumnos();
            }

            button_Calcular.Enabled = false;

        }
        GestionAlumnos[] Alumno = new GestionAlumnos[3];
        int contador = 0;

        private void CalcularValores()
        {
            int maxNota = int.MinValue;
            int minNota = int.MaxValue;
            string nombreMaxNota = string.Empty;
            string nombreMinNota = string.Empty;

            string resultadoCargados = "Los alumnos Cargados son: \n";
            for (int i = 0; i < Alumno.Length; i++)

            {

                if (Alumno[i].GetNota() > maxNota)
                {
                    maxNota = Alumno[i].GetNota();
                    nombreMaxNota = Alumno[i].GetNombre();\

                }else if (Alumno[i].GetNota() < minNota)
                {
                    maxNota = Alumno[i].GetNota();
                    nombreMinNota = Alumno[i].GetNombre();
                }

                
            }
            for (int i = 0; i < Alumno.Length; i++) {

                resultadoCargados += $"Nombre {i + 1}: {Alumno[i].GetNombre()} , Nota {i + 1} : {Alumno[i].GetNota()} \n ";
            }

                MessageBox.Show(resultadoCargados + $" \n La nota mas alta es la de {nombreMaxNota} obteniendo una nota de {maxNota} \n \n La nota mas baja fue la de {nombreMinNota} Obteniendo una nota de {minNota}");


        }


        private void button_Guardar_Click(object sender, EventArgs e)
        {

            if (contador < Alumno.Length)
            {

                bool validacion = !string.IsNullOrWhiteSpace(textBox_Nombre.Text) &&
                             !int.IsNegative(int.Parse(textBox_Nota.Text)) && int.Parse(textBox_Nota.Text) >= 0 &&
                             System.Text.RegularExpressions.Regex.IsMatch(textBox_Nombre.Text, @"^[a-zA-Z\s]+$") &&
                              System.Text.RegularExpressions.Regex.IsMatch(textBox_Nota.Text, @"^\d+$");


                if (validacion)
                {

                    Alumno[contador].SetNombre(textBox_Nombre.Text);
                    Alumno[contador].SetNota(int.Parse(textBox_Nota.Text));

                    MessageBox.Show("Alumno Guardado Correctamente");

                    textBox_Nombre.Text = string.Empty;
                    textBox_Nota.Text = string.Empty;
                    contador++;

                }
                else
                {
                    MessageBox.Show("Por favor ingrese valores validos");
                }


            }
            if (contador > 2)
            {

                MessageBox.Show("Todos los alumnos fueron cargados");

                button_Calcular.Enabled = true;
                button_Guardar.Enabled = false;
            }



        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            CalcularValores();
        }
    }

    public class GestionAlumnos
    {
        private string Nombre = string.Empty;   
        private int Nota = 0;

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void SetNota(int nota) {
            Nota = nota;
        }

        public int GetNota()
        {
            return Nota;
        }

        public string GetNombre()
        {
            return Nombre;
        }

    }
}
