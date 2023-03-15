using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDivInf.Logic
{
    internal class Paciente : Persona
    {
        public int NumeroHistoriaClinica { get; }
        public List<Consulta> ListaConsultas { get; }

        public Paciente(string nombre, int numeroHistoriaClinica)
        {
            Nombre = nombre;
            NumeroHistoriaClinica = numeroHistoriaClinica;
            ListaConsultas = new List<Consulta>();
        }

        public void AgregarConsulta(Consulta consulta)
        {
            ListaConsultas.Add(consulta);
        }
    }
}
