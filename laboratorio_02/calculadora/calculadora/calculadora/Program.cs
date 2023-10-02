internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nCalculadora Avanzada");
            Console.WriteLine("Operaciónes disponibles: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potenciación");
            Console.WriteLine("6. Raíz Cuadrada");
            Console.WriteLine("7. Salir");

            Console.Write("Seleccione una operación (1-7): ");

            int opcion;

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    RealizarSuma();
                    break;
                case 2:
                    RealizarResta();
                    break;
                case 3:
                    RealizarMultiplicacion();
                    break;
                case 4:
                    RealizarDivision();
                    break;
                case 5:
                    RealizarPotenciacion();
                    break;
                case 6:
                    RealizarRaizCuadrada();
                    break;
                case 7:
                    Console.WriteLine("Saliendo de la calculadora.");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    // Definicion de funciones
    static void RealizarSuma()
    {
        Console.Write("\n\nIngrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void RealizarResta()
    {
        Console.Write("\n\nIngrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void RealizarMultiplicacion()
    {
        Console.Write("\n\nIngrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void RealizarDivision()
    {
        Console.Write("\n\nIngrese el numerador: ");
        double numerador = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el denominador: ");
        double denominador = Convert.ToDouble(Console.ReadLine());

        if (denominador == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
            double resultado = numerador / denominador;
            Console.WriteLine($"Resultado: {resultado}");
        }
    }   

    static void RealizarPotenciacion()
    {
        Console.Write("\n\nIngrese la base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el exponente: ");
        double exponente = Convert.ToDouble(Console.ReadLine());

        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void RealizarRaizCuadrada()
    {
        Console.Write("\n\nIngrese el número: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
        }
        else
        {
            double resultado = Math.Sqrt(num);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }


}

