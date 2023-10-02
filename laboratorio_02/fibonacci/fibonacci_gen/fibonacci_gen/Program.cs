
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 4: Generador de Secuencia Fibonacci");
        Console.Write("Ingrese la cantidad de términos a generar: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Secuencia de Fibonacci:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }


    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
