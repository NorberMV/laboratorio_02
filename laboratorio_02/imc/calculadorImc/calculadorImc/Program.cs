
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 6: Cálculo de IMC (Índice de Masa Corporal)");
        Console.Write("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = CalcularIMC(peso, altura);
        string clasificacion = ClasificarIMC(imc);

        Console.WriteLine($"Su IMC es: {imc:F2}");
        Console.WriteLine($"Clasificación: {clasificacion}");
    }

    // Definir funciones
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static string ClasificarIMC(double imc)
    {
        if (imc < 18.5)
            return "Bajo peso";
        else if (imc < 24.9)
            return "Peso normal";
        else if (imc < 29.9)
            return "Sobrepeso";
        else
            return "Obesidad";
    }
}
