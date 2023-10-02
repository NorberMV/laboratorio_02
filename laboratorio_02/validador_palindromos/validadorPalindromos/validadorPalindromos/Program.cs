
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 9: Validador de Palíndromos");
        Console.WriteLine("Ingresa una palabra o frase:");
        string input = Console.ReadLine();

        if (EsPalindromo(input))
        {
            Console.WriteLine("Es un palíndromo.");
        }
        else
        {
            Console.WriteLine("No es un palíndromo.");
        }
    }
    // Definicion de funciones.
    static bool EsPalindromo(string texto)
    {
        // Eliminar espacios y convertir a minúsculas para la comparación
        texto = texto.Replace(" ", "").ToLower();

        int izquierda = 0;
        int derecha = texto.Length - 1;

        while (izquierda < derecha)
        {
            if (texto[izquierda] != texto[derecha])
            {
                return false;
            }
            izquierda++;
            derecha--;
        }

        return true;
    }
}
