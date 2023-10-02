
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 8: Cálculo de Edad");
        Console.Write("Ingrese su fecha de nacimiento (yyyy-mm-dd): ");
        try
        {
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            int edad = CalcularEdad(fechaNacimiento);
            Console.WriteLine($"Su edad es: {edad} años");
        }
        catch (System.FormatException e)
        {
            Console.WriteLine($"La fecha no tiene el formato indicado (yyyy-mm-dd), ver el traceback original abajo:\n\n{e}");
        }
       
    }
    // Definicion de funciones
    static int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;
        if (fechaNacimiento.Year >= fechaActual.Year )
        {
            throw new Exception($"Favor ingrese un año de nacimiento <= {fechaActual.Year}!");
        }

        if (fechaNacimiento > fechaActual.AddYears(-edad))
            edad--;

        return edad;
    }
}
