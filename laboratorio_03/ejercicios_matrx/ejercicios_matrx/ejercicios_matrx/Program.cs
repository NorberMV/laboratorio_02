internal class Program
{
    private static void Main(string[] args)
    {
        // Ejercicios Matrices
        int[,] matrizA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrizB = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        while (true)
        {
            Console.WriteLine("\n\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar contenido de una matriz de enteros.");
            Console.WriteLine("2. Sumar dos matrices.");
            Console.WriteLine("3. Multiplicar una matriz por un escalar.");
            Console.WriteLine("4. Encontrar el determinante de una matriz cuadrada.");
            Console.WriteLine("5. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Contenido de la matriz:");
                    MostrarMatriz(matrizA);
                    break;
                case "2":
                    SumarMatrices(matrizA, matrizB);
                    break;
                case "3":
                    MultiplicarPorEscalar(matrizA);
                    break;
                case "4":
                    EncontrarDeterminante(matrizA);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    // Definición de funciones

    static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void SumarMatrices(int[,] matrizA, int[,] matrizB)
    {
        int filas = matrizA.GetLength(0);
        int columnas = matrizA.GetLength(1);

        int[,] resultado = new int[filas, columnas];

        Console.WriteLine("Calculando la suma de las siguientes matrices: ");
        MostrarMatriz(matrizA);
        Console.WriteLine(" + ");
        MostrarMatriz(matrizB);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        Console.WriteLine("Resultado de la suma de matrices:");
        MostrarMatriz(resultado);
    }

    static void MultiplicarPorEscalar(int[,] matriz)
    {
        Console.Write("Ingrese el escalar a multiplicar por la matriz: ");
        if (int.TryParse(Console.ReadLine(), out int escalar))
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            int[,] resultado = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = matriz[i, j] * escalar;
                }
            }

            Console.WriteLine("El resultado de la multiplicación por escalar es: ");
            MostrarMatriz(resultado);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        }
    }

    static void EncontrarDeterminante(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int resultado = 0;

        Console.WriteLine("Calculando el determinante para la siguiente matriz: ");
        MostrarMatriz(matriz);
        if (filas != columnas)
        {
            Console.WriteLine("La matriz no es cuadrada. No se puede calcular el determinante.");
            throw new CustomException("La matriz no es cuadrada. No se puede calcular el determinante.");
        }

        if (filas == 2)
        {
            // Caso base: matriz de 2x2
            resultado = (matriz[0, 0] * matriz[1, 1]) - (matriz[0, 1] * matriz[1, 0]);
        }
        else if (filas == 3)
        {
            // Caso base: matriz de 3x3
            int a = matriz[0, 0];
            int b = matriz[0, 1];
            int c = matriz[0, 2];
            int d = matriz[1, 0];
            int e = matriz[1, 1];
            int f = matriz[1, 2];
            int g = matriz[2, 0];
            int h = matriz[2, 1];
            int i = matriz[2, 2];

            resultado = (a * e * i) + (b * f * g) + (c * d * h) - (c * e * g) - (a * f * h) - (b * d * i);

        }
        else
        {
            Console.WriteLine("El cálculo del determinante para matrices de más de 3x3 no está implementado en este ejemplo.");
        }
        //some logic
        Console.Write("El determinante de la matriz es: " + resultado);
       
  
    }


}

// Definiendo una Custom exception
class CustomException : Exception
{
    public CustomException(string message)
    {
    }
}



