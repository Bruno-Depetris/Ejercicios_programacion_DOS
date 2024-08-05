namespace ejerciciodos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            formularioInhabilitado();

        }
        public void cargadodedatos() {

            string nombre_usuario = nombre.Text;
            string apellido_usuario = apellido.Text;


            int legajo_usuario;
            if (!int.TryParse(maskedTextBox_LEGAJO.Text, out legajo_usuario)) { //valido el legajo
                MessageBox.Show("El legajo ingresado no es válido.");
                return;
        }

            string fecha_ingreso = maskedTextBoxFechaIngreso.Text;
            string carrera = string.Empty; 


            if (radioButton_ingeniarias.Checked) {
                carrera = "Ingeniería";
            }
            else if (radioButton_tecn.Checked) {
                carrera = "Tecnicatura";
            }


            string tecnologia_html = checkBox_HTML.Checked ? "HTML" : string.Empty; //si esta chequeado entonces guarda HTML sino. mientras tanto esta vacio 
            string tecnologia_csharp = cSharp.Checked ? "C#" : string.Empty;
            string tecnologia_js = checkBox_Js.Checked ? "JavaScript" : string.Empty;


            mensaje = $"Nombre: {nombre_usuario}\n" +
                            $"Apellido: {apellido_usuario}\n" +
                            $"Legajo: {legajo_usuario}\n" +
                            $"Fecha de Ingreso: {fecha_ingreso}\n" +
                            $"Carrera: {carrera}\n" +
                            $"Tecnologías: {tecnologia_html} {tecnologia_csharp} {tecnologia_js} \n ";

        }
        private void formularioInhabilitado() {
            panel_formulario.Enabled = false;

        }
        private void formularioActivado() {
            panel_formulario.Enabled = true;
        }


        private void anioingreso_TextChanged(object sender, EventArgs e) {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            cargadodedatos();


            nombre.Clear();
            apellido.Clear();
            maskedTextBox_LEGAJO.Clear();
            maskedTextBoxFechaIngreso.Clear();

            radioButton_ingeniarias.Controls.Clear();
            radioButton_tecn.Controls.Clear();

            checkBox_HTML.Controls.Clear();
            checkBox_Js.Controls.Clear();
            cSharp.Controls.Clear();

            formularioInhabilitado();

            




        }

        private void cargarDatos_Click(object sender, EventArgs e) {

            formularioActivado();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button_showData_Click(object sender, EventArgs e) {
            MessageBox.Show(mensaje);
        }

        private void button_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
