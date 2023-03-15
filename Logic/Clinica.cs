using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDivInf.Logic
{
    internal class Clinica
    {
        // Se podría tener una única lista de Personas, y comparar por el tipo de dato al querer obtener
        // un paciente o médico específico. Considero que esta implementación resultaría mas eficiente, ya que no se 
        // debe iterar innecesariamente sobre elementos que no corresponden

        private List<Medico> listaMedicos;    
        private List<Paciente> listaPacientes;

        public Clinica()
        {
            listaMedicos = new List<Medico>();
            listaPacientes = new List<Paciente>();
        }

        public List<Medico> Medicos { get { return listaMedicos; } }

        public List<Paciente> Pacientes { get { return listaPacientes; } }

        public void CrearConsulta(Paciente paciente, DateTime fecha, Medico profesional, int costo, string descripcion)
        {
            Consulta consulta = new Consulta(fecha, profesional, costo, descripcion);
            paciente.AgregarConsulta(consulta);

        }
        public void CrearConsulta(Paciente paciente, DateTime fecha, Medico profesional, int costo, string descripcion, int costoMateriales)
        {
            Consulta consulta = new Consulta(fecha, profesional, costo, descripcion, costoMateriales);
            paciente.AgregarConsulta(consulta);
        }

        public void CrearPaciente(string nombre, int numeroHistoriaClinica)
        {
            // Aquí se podría hacer la llamada a la clase de persistencia para persistir la información.
            // Por el tamaño del proyecto lo considero innecesario

            if (GetPacientePorNombre(nombre) is not null)
            {
                throw new Exception("El paciente ya existe");
            }
            listaPacientes.Add(new Paciente(nombre, numeroHistoriaClinica));
        }

        public void CrearMedico(string nombre, int numeroMatricula, string especialidad)
        {
            if (GetMedicoPorNombre(nombre) is not null)
            {
                throw new Exception("El medico ya existe");
            }
            listaMedicos.Add(new Medico(nombre, numeroMatricula, especialidad));
        }

        internal Paciente GetPacientePorNombre(string nombre)
        {
            return listaPacientes.FirstOrDefault(paciente => paciente.Nombre == nombre);
        }

        internal Medico GetMedicoPorNombre(string nombre)
        {
            return listaMedicos.FirstOrDefault(medico => medico.Nombre == nombre);
        }
    }
}