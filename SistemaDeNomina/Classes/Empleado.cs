
namespace SistemaDeNomina.Classes
{
    public abstract class Empleado
    {
        public string? PrimerNombre { get; set; }

        public string? ApellidoPaterno { get; set; }

        public int NumeroSeguroSocial { get; set; }

        public abstract void CalcularIngreso();

    }
}
