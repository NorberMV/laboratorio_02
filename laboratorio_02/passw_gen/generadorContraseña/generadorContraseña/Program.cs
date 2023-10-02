

using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 10: Generador de Contraseñas");
        Console.Write("Ingresa la longitud de la contraseña: ");
        int longitud = Convert.ToInt32(Console.ReadLine());

        Console.Write("Incluir mayúsculas (S/N): ");
        bool incluirMayusculas = Console.ReadLine().ToUpper() == "S";

        Console.Write("Incluir minúsculas (S/N): ");
        bool incluirMinusculas = Console.ReadLine().ToUpper() == "S";

        Console.Write("Incluir números (S/N): ");
        bool incluirNumeros = Console.ReadLine().ToUpper() == "S";

        Console.Write("Incluir caracteres especiales (S/N): ");
        bool incluirEspeciales = Console.ReadLine().ToUpper() == "S";

        string contraseña = GenerarContraseña(longitud, incluirMayusculas, incluirMinusculas, incluirNumeros, incluirEspeciales);

        Console.WriteLine("Contraseña generada: " + contraseña);
    }

    // Definicion de funciones
    static string GenerarContraseña(int longitud, bool incluirMayusculas, bool incluirMinusculas, bool incluirNumeros, bool incluirEspeciales)
    {
        string caracteresMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string caracteresMinusculas = "abcdefghijklmnopqrstuvwxyz";
        string caracteresNumeros = "0123456789";
        string caracteresEspeciales = "!@#$%^&*()_+-=[]{}|;:,.<>?";

        StringBuilder caracteresPermitidos = new StringBuilder();

        if (incluirMayusculas)
        {
            caracteresPermitidos.Append(caracteresMayusculas);
        }

        if (incluirMinusculas)
        {
            caracteresPermitidos.Append(caracteresMinusculas);
        }

        if (incluirNumeros)
        {
            caracteresPermitidos.Append(caracteresNumeros);
        }

        if (incluirEspeciales)
        {
            caracteresPermitidos.Append(caracteresEspeciales);
        }

        Random random = new Random();
        StringBuilder contraseña = new StringBuilder();

        for (int i = 0; i < longitud; i++)
        {
            int indiceAleatorio = random.Next(0, caracteresPermitidos.Length);
            contraseña.Append(caracteresPermitidos[indiceAleatorio]);
        }

        return contraseña.ToString();
    }
}
