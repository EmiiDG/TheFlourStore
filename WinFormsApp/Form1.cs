using System.Text.Json;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form2 Nuevo = new Form2();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("Logo.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string nombrePaciente = PacienteName.Text;
            string apellidoPaciente = PacienteSurname.Text;
            string nombreProfeisonal = ProfesionalName.Text;
            string ApellidoProfesional = ProfesionalSurname.Text;
            string turno = Turno.Text;
            string departamento = Departamento.Text;
            string piso = Piso.Text;
            string consultorio = Consultorio.Text; 
            await EnviarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PacienteName.ResetText();
            PacienteSurname.ResetText();
            ProfesionalName.ResetText();
            ProfesionalSurname.ResetText();
            Turno.ResetText();
            Departamento.ResetText();
            Piso.ResetText();
            Consultorio.ResetText();
        }

        private void Piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async Task EnviarDatos()
        {
            var consulta = new
            {
                nombrePaciente = PacienteName.Text,
                apellidoPaciente = PacienteSurname.Text,
                nombreProfesional = ProfesionalName.Text,
                apellidoProfesional = ProfesionalSurname.Text,
                turno = int.TryParse(Turno.Text, out int turno) ? turno : 0,
                departamento = Departamento.Text,
                piso = int.TryParse(Piso.Text, out int piso) ? piso : 0,
                consultorio = Consultorio.Text,
                token = Nuevo.Token,
                hospital = Nuevo.Hospital,
                atendido = false
        };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5028/swagger/index.html");
                var json = JsonSerializer.Serialize(consulta);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/api/Servidor/upload", content);
                string result = await response.Content.ReadAsStringAsync();

                MessageBox.Show("Consulta asignada con éxito");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nuevo.Show();
        }
    }
}
