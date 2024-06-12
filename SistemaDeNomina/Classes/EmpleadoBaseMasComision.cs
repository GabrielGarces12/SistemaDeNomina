
namespace SistemaDeNomina.Classes
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public int SalarioBase { get; set; }

        public override void CalcularIngreso()
        {

            double SueldoFinalBaseComision = (TarifaComision * VentasBrutas) + SalarioBase;

            Console.WriteLine($"Tu sueldo final es: $RD {SueldoFinalBaseComision} Pesos Dominicanos");
        }
    }
}
