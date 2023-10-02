
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nElija la conversión deseada:");
            Console.WriteLine("1. Milímetros a Centímetros");
            Console.WriteLine("2. Centímetros a Pulgadas");
            Console.WriteLine("3. Pulgadas a Metros");
            Console.WriteLine("4. Metros a Kilómetros");
            Console.WriteLine("5. Salir");

            int opcion = LeerEntero("Ingrese el número de la opción: ");

            switch (opcion)
            {
                case 1:
                    MilimetrosACentimetros();
                    break;
                case 2:
                    CentimetrosAPulgadas();
                    break;
                case 3:
                    PulgadasAMetros();
                    break;
                case 4:
                    MetrosAKilometros();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del conversor!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static int LeerEntero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }
    }

    static void MilimetrosACentimetros()
    {
        double milimetros = LeerDouble("Ingrese la longitud en milímetros: ");
        double centimetros = milimetros / 10;
        Console.WriteLine($"{milimetros} milímetros equivalen a {centimetros} centímetros.");
    }

    static void CentimetrosAPulgadas()
    {
        double centimetros = LeerDouble("Ingrese la longitud en centímetros: ");
        double pulgadas = centimetros / 2.54;
        Console.WriteLine($"{centimetros} centímetros equivalen a {pulgadas} pulgadas.");
    }

    static void PulgadasAMetros()
    {
        double pulgadas = LeerDouble("Ingrese la longitud en pulgadas: ");
        double metros = pulgadas * 0.0254;
        Console.WriteLine($"{pulgadas} pulgadas equivalen a {metros} metros.");
    }

    static void MetrosAKilometros()
    {
        double metros = LeerDouble("Ingrese la longitud en metros: ");
        double kilometros = metros / 1000;
        Console.WriteLine($"{metros} metros equivalen a {kilometros} kilómetros.");
    }

    static double LeerDouble(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
            }
        }
    }
}
