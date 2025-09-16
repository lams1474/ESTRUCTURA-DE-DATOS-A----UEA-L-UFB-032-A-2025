public class CalculadoraBasica
{
    public static void run()
    {
        // declarar dos numeros enteros
        int numero1 = 15;
        int numero2 = 3;

        // realizar operaciones basicas
        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        double division = (double)numero1 / numero2;   // casting explicito
        int modulo = numero1 % numero2;

        // mostrar resultados 
        System.Console.WriteLine("Numeros: " + numero1 + " y " + numero2);
        System.Console.WriteLine("Suna: " + suma);
        System.Console.WriteLine("Resta: " + resta);
        System.Console.WriteLine("Multiplicacion: " + multiplicacion);
        System.Console.WriteLine("Division: " + division);
        System.Console.WriteLine("Modulo: " + modulo);
    }

}