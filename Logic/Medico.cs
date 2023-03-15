using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDivInf.Logic
{
    internal class Medico : Persona
    {
        public int NumeroMatricula { get; set; }
        public string Especialidad { get; set; }

        public Medico(string nombre, int numeroMatricula, string especialidad)
        {
            Nombre = nombre;
            NumeroMatricula = numeroMatricula;
            Especialidad = especialidad;
        }
    }
}
