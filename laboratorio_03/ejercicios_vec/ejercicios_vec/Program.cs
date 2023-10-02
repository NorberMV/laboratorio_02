internal class Program
{
    private static void Main(string[] args)
    {
        // Ejercicios Vectores
        int[] numerosEnteros = { 5, 10, 3, 8, 1 };
        double[] numerosReales = { 2.5, 4.7, 1.2, 6.8, 3.0 };
        int[] numerosEnteros2 = { 15, 7, 22, 4, 9 };
        string[] cadenas = { "manzana", "pera", "banana", "naranja", "uva" };
        bool salir = false;

        while (!salir)
        {
            // Menú de selección
            Console.WriteLine("\n\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar contenido de un vector de números enteros.");
            Console.WriteLine("2. Calcular la suma de elementos en un vector de números reales.");
            Console.WriteLine("3. Encontrar el elemento más grande y el más pequeño en un vector de números enteros.");
            Console.WriteLine("4. Ordenar un vector de cadenas alfabéticamente.");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese su opción: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    MostrarContenidoVector(numerosEnteros);
                    break;
                case "2":
                    CalcularSuma(numerosReales);
                    break;
                case "3":
                    EncontrarMaximoYMinimo(numerosEnteros2);
                    break;
                case "4":
                    OrdenarCadenas(cadenas);
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void MostrarContenidoVector(int[] vector)
        {
            Console.WriteLine("Contenido del vector de números enteros:");
            foreach (var numero in vector)
            {
                Console.Write(numero + ", ");
            }
            Console.WriteLine();
        }

    static void CalcularSuma(double[] vector)
    {
        double suma = 0;
        Console.Write("Calculando la suma del siguiente vector: { ");
        // Mostrar el vector
        foreach (var numero in vector)
        {
            Console.Write(numero + ", ");
        }
        Console.WriteLine("}");
        Console.WriteLine();
        // Iterando en el vector para sumar los elementos
        foreach (var numero in vector)
        {
            suma += numero;
        }
        Console.WriteLine("La suma de los elementos en el vector de números reales es: " + suma);
    }


    static void EncontrarMaximoYMinimo(int[] vector)
    {
        int maximo = vector[0];
        int minimo = vector[0];

        Console.Write("Calculando el máximo valor del siguiente vector: { ");
        // Mostrar el vector
        foreach (var numero in vector)
        {
            Console.Write(numero + ", ");
        }
        Console.WriteLine("}");
        Console.WriteLine();

        foreach (var numero in vector)
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
            if (numero < minimo)
            {
                minimo = numero;
            }
        }

        Console.WriteLine("El elemento más grande es: " + maximo);
        Console.WriteLine("El elemento más pequeño es: " + minimo);
    }

    static void OrdenarCadenas(string[] vector)
    {
        Console.Write("Ordenando alfabeticamente el siguiente vector: { ");
        // Mostrar el vector
        foreach (var numero in vector)
        {
            Console.Write(numero + ", ");
        }
        Console.WriteLine("}");
        Console.WriteLine();
        Array.Sort(vector);
        Console.WriteLine("Vector de cadenas ordenado alfabéticamente:");
        foreach (var cadena in vector)
        {
            Console.Write(cadena + ", ");
        }
        Console.WriteLine();
    }
}





