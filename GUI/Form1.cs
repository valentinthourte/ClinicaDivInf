using ClinicaDivInf.Logic;

namespace ClinicaDivInf
{
    public partial class frmClinica : Form
    {
        private Clinica clinica = new Clinica();

        public frmClinica()
        {
            InitializeComponent();
        }

        private void onConsultaChanged(object sender, EventArgs e)
        {
            edtCostoMateriales.Enabled = rbPractica.Checked;
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            string mensaje = "Medico creado correctamente";
            try
            {
                clinica.CrearMedico(edtNombre.Text, decimal.ToInt32(edtNroMatricula.Value), edtEspecialidad.Text);
                ActualizarComboMedicos();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            MessageBox.Show(mensaje);
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            string mensaje = "Paciente creado correctamente";
            try
            {
                clinica.CrearPaciente(edtNombre.Text, decimal.ToInt32(edtNumeroHistoriaClinica.Value));
                ActualizarComboPacientes();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            MessageBox.Show(mensaje);
        }

        private void ActualizarComboPacientes()
        {
            cbParaPaciente.Items.Clear();
            cbParaPaciente.Items.AddRange(clinica.Pacientes.Select(p => p.Nombre).ToArray());
        }

        private void ActualizarComboMedicos()
        {
            cbProfesional.Items.Clear();
            cbProfesional.Items.AddRange(clinica.Medicos.Select(m => m.Nombre).ToArray());
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string nombre = edtNombre.Text;
            Paciente paciente = clinica.GetPacientePorNombre(nombre);
            Medico medico = clinica.GetMedicoPorNombre(nombre);
            if (rbConsultorio.Checked)
            {
                clinica.CrearConsulta(paciente, dtFecha.Value, medico, decimal.ToInt32(edtCostoConsulta.Value), edtDescripcion.Text);
            }
            else
            {
                clinica.CrearConsulta(paciente, dtFecha.Value, medico, decimal.ToInt32(edtCostoConsulta.Value), edtDescripcion.Text, decimal.ToInt32(edtCostoMateriales.Value));
            }
            MessageBox.Show("Consulta creada correctamente");
        }
    }
}

