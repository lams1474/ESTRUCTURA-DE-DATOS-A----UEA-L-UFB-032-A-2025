public class EjercicioCasting
{
    public static void run()
    {
        // Pedir un número entero
        Console.Write("Ingresa tu edad: ");
        string textoEdad = Console.ReadLine();
        int edad = int.Parse(textoEdad); // string → int

        // Pedir un número con decimales
        Console.Write("Ingresa tu altura en metros (ej: 1.75): ");
        string textoAltura = Console.ReadLine();
        double altura = double.Parse(textoAltura); // string → double

        // Mostrar los valores convertidos
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine("Edad (int): " + edad);
        Console.WriteLine("Altura (double): " + altura);

        // Casting explícito: truncar la altura a entero
        int alturaEntera = (int)altura;
        Console.WriteLine("Altura truncada (casting a int): " + alturaEntera);

        // Operaciones con los datos
        int edadEn5 = edad + 5;
        double alturaDoble = altura * 2;

        Console.WriteLine("\nEdad en 5 años: " + edadEn5);
        Console.WriteLine("El doble de tu altura: " + alturaDoble);

        // Ejemplo con TryParse (más seguro)
        Console.Write("\nIngresa un número cualquiera: ");
        string textoNumero = Console.ReadLine();
        bool exito = int.TryParse(textoNumero, out int numeroConvertido);

        if (exito)
        {
            Console.WriteLine("Número convertido correctamente: " + numeroConvertido);
        }
        else
        {
            Console.WriteLine("Error: el texto ingresado no es un número válido.");
        }
    }
}
