
namespace SistemaDeNomina.Classes
{
    public class EmpleadoPorComision : Empleado
    {
        public int VentasBrutas { get; set; }
        public double TarifaComision { get; set; }
        public override void CalcularIngreso()
        {
            double SueldoEmpleadoComision = (VentasBrutas * TarifaComision);
            
            Console.WriteLine($"Tu sueldo final es: $RD {SueldoEmpleadoComision} Pesos Dominicanos");
        }
    }
}
