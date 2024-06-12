

namespace SistemaDeNomina.Classes
{
    public class EmpleadoPorHoras : Empleado
    {
        public double HorasTrabajadas { get; set; }
        public double SueldoHora { get; set; }
        public override void CalcularIngreso()
        {
            if (HorasTrabajadas <= 40) 
            {
                double SueldoFinal = (SueldoHora * HorasTrabajadas);
                Console.WriteLine($"Tu sueldo final es: $RD {SueldoFinal} Pesos Dominicanos");
            }
            else
            {
                double SueldoFinalExtra = (40 * SueldoHora + (HorasTrabajadas - 40) * SueldoHora * 1.5);
                Console.WriteLine($"Tu sueldo final es: {SueldoFinalExtra} Pesos Dominicanos");
            }

        }
    }
}
