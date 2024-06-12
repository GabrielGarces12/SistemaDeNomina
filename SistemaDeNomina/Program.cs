
using SistemaDeNomina.Classes;

List<EmpleadoBaseMasComision> empleados = new List<EmpleadoBaseMasComision>();

EmpleadoBaseMasComision empleado = new EmpleadoBaseMasComision();

Console.WriteLine("Ingrese el nombre: ");
empleado.PrimerNombre = Console.ReadLine();

Console.WriteLine("Ingrese el apellido: ");
empleado.ApellidoPaterno = Console.ReadLine();

Console.WriteLine("Ingrese los 8 digitos del Seguro Social: ");
empleado.NumeroSeguroSocial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese las ventas brutas: ");
empleado.VentasBrutas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la tarifa de comision: ");
empleado.TarifaComision = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el salario base: ");
empleado.SalarioBase = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n{empleado.PrimerNombre} {empleado.ApellidoPaterno}");

empleado.CalcularIngreso();