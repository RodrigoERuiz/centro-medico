namespace formulario
{
    using Biblioteca_de_clases;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItems.Count == 0 || lstPacientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un doctor y un paciente", "ERROR");
            }
            else
            {
                Paciente pacienteElegido = (Paciente)lstPacientes.SelectedItem;
                pacienteElegido.Diagnostico = "Paciente curado";

                PersonalMedico medicoElegido = (PersonalMedico)lstMedicos.SelectedItem;

                Consulta nuevaConsulta = new Consulta(DateTime.Now, pacienteElegido);
                nuevaConsulta = medicoElegido + pacienteElegido;

                MessageBox.Show($"{nuevaConsulta.ToString()}\nDiagnóstico: {pacienteElegido.Diagnostico}", "Atención finalizada");

                lstMedicos.SelectedIndex = -1;
                lstPacientes.SelectedIndex = -1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedItem is not null)
            {
                PersonalMedico doctorSelecionado = (PersonalMedico)lstMedicos.SelectedItem;
                rtbInfoMedico.Text = doctorSelecionado.FichaExtra2;
            }
        }

        private void rtbInfoMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // Si el usuario selecciona No, cancelar el cierre del formulario
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
