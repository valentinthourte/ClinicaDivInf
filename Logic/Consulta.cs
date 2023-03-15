namespace ClinicaDivInf.Logic
{
    public class Consulta
    {

        private bool FueEnConsultorio { get; }
        private DateTime FechaRealizacion { get; }
        private Medico Profesional { get; }
        private int Costo { get; }
        private string Descripcion { get; }
        private int CostoMaterialDescartable { get; }

        internal Consulta(DateTime fecha, Medico profesional, int costo, string descripcion)
        {
            FueEnConsultorio = true;
            FechaRealizacion = fecha;
            Profesional = profesional;
            Costo = costo;
            Descripcion = descripcion;
        }
        internal Consulta(DateTime fecha, Medico profesional, int costo, string descripcion, int costoMateriales)
        {
            FueEnConsultorio = false;
            FechaRealizacion = fecha;
            Profesional = profesional;
            Costo = costo;
            Descripcion = descripcion;
            CostoMaterialDescartable = costoMateriales;
        }
    }
}