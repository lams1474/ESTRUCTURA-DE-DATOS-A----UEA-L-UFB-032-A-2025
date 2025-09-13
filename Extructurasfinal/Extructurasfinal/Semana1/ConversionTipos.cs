public class ConversionTipos
{
    public static void run()
    {
        // Conversión implícita (automática)
        int numeroEntero = 10;
        double numeroDecimal = numeroEntero; // int → double
        Console.WriteLine("Conversión implícita (int a double): " + numeroDecimal);

        // Conversión explícita (casting)
        double pi = 3.14159;
        int piEntero = (int)pi; // double → int (trunca decimales)
        Console.WriteLine("Conversión explícita (double a int): " + piEntero);

        // Ejemplo con float
        float valorFlotante = 9.75f;
        int valorEntero = (int)valorFlotante; // Pierde decimales
        Console.WriteLine("Casting float a int: " + valorEntero);

        // Conversión con métodos de C#
        string textoNumero = "123";
        int numeroParseado = int.Parse(textoNumero); // string → int
        Console.WriteLine("Conversión con int.Parse: " + numeroParseado);

        // Conversión segura con TryParse
        string textoInvalido = "abc";
        bool exito = int.TryParse(textoInvalido, out int resultado);
        Console.WriteLine("Conversión con TryParse exitosa: " + exito);
        Console.WriteLine("Valor convertido: " + resultado);
    }
}
