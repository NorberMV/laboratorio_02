
internal class Program
{
    private static void Main(string[] args)
    {
    Console.WriteLine("\n\nEjercicio 5: Cálculo de Área y Perímetro");

    while (true)
    {
        Console.WriteLine("Seleccione una figura para calcular su area: ");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Triángulo");
        Console.WriteLine("3. Rectángulo");
        Console.WriteLine("4. Salir");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                CalcularCirculo();
                break;
            case 2:
                CalcularTriangulo();
                break;
            case 3:
                CalcularRectangulo();
                break;
            case 4:
                return;
            default:
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                break;
        }
    }
}

    // Definicion de funciones
    static void CalcularCirculo()
    {
        Console.Write("Ingrese el radio del círculo en [m]: ");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine($"Área del círculo: {area}m2");
        Console.WriteLine($"Perímetro del círculo: {perimetro}m2");
    }

    static void CalcularTriangulo()
    {
        Console.Write("Ingrese la base del triángulo en [m]: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo en [m]: ");
        double altura = double.Parse(Console.ReadLine());

        double area = 0.5 * baseTriangulo * altura;
        double perimetro = 3 * baseTriangulo;

        Console.WriteLine($"Área del triángulo: {area}m2");
        Console.WriteLine($"Perímetro del triángulo: {perimetro}m2");
    }

    static void CalcularRectangulo()
    {
        Console.Write("Ingrese la longitud del lado 1 en [m]: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la longitud del lado 2 en [m]: ");
        double lado2 = double.Parse(Console.ReadLine());

        double area = lado1 * lado2;
        double perimetro = 2 * (lado1 + lado2);

        Console.WriteLine($"Área del rectángulo: {area}m2");
        Console.WriteLine($"Perímetro del rectángulo: {perimetro}m2");
    }

}
