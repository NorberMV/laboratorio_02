
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 7: Conversión de Temperatura");
        Console.WriteLine("Seleccione la conversión deseada:");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Celsius a Kelvin");
        Console.WriteLine("3. Fahrenheit a Celsius");
        Console.WriteLine("4. Fahrenheit a Kelvin");
        Console.WriteLine("5. Kelvin a Celsius");
        Console.WriteLine("6. Kelvin a Fahrenheit");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        double temperatura;

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese la temperatura en grados Celsius: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {CelsiusToFahrenheit(temperatura)} °F");
                break;
            case 2:
                Console.Write("Ingrese la temperatura en grados Celsius: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {CelsiusToKelvin(temperatura)} K");
                break;
            case 3:
                Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {FahrenheitToCelsius(temperatura)} °C");
                break;
            case 4:
                Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {FahrenheitToKelvin(temperatura)} K");
                break;
            case 5:
                Console.Write("Ingrese la temperatura en Kelvin: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {KelvinToCelsius(temperatura)} °C");
                break;
            case 6:
                Console.Write("Ingrese la temperatura en Kelvin: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {KelvinToFahrenheit(temperatura)} °F");
                break;
            default:
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                break;
        }
    }
    // Definicion de funciones
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9 + 273.15;
    }

    static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin - 273.15) * 9 / 5 + 32;
    }


}