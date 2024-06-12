
namespace SistemaDeNomina.Classes
{
    public class EmpleadoAsalariado : Empleado
    {
        public int SalarioSemanal { get; set; }
        public override void CalcularIngreso()
        {
            Console.WriteLine($"Tu sueldo final es: $RD {SalarioSemanal} Pesos Dominicanos");
        }
    }
}
