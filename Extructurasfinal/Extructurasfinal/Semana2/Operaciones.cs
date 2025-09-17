// Clase con Múltiples Datos Primitivos

public class Operaciones
{
    public static void run()
    {
        // Creamos una instancia con dos valores numéricos
        Operaciones op = new Operaciones(20.5, 4.5);

        // Realizamos y mostramos todas las operaciones
        System.Console.WriteLine("Suma: " + op.Sumar());
        System.Console.WriteLine("Resta: " + op.Restar());
        System.Console.WriteLine("Multiplicacion: " + op.Multiplicar());

        // Manejo de excepción en división
        try
        {
            System.Console.WriteLine("Divicion: " + op.Dividir());
        }

        catch (System.DivideByZeroException ex)
        {
            System.Console.WriteLine("Error: " + ex.Message);
        }
    }
    // Campos privados para los dos números
    private double número1;
    private double numero2;

    // Constructor que inicializa ambos números
    public Operaciones(double n1, double n2)
    {
        número1 = n1;   // Asigna primer número
        numero2 = n2;   // Asigna segundo número 
    }

    // Método para sumar los dos números
    public double Sumar()
    {
        return número1 + numero2;    // Retorna suma de ambos números   
    }

    // Método para restar los dos números
    public double Restar()
    {
        return número1 - numero2;     // Retorna resta de ambos números
    }

    // Método para multiplicar los dos números
    public double Multiplicar()
    {
        return número1 * numero2;       // Retorna multiplicación de ambos números
    }

    // Método para dividir los dos números
    public double Dividir()
    {
        // Validación para evitar división por cero
        if (numero2 == 0)
        {
            throw new System.DivideByZeroException("El divisor no puede ser cero.");
        }
        return número1 / numero2;  // Retorna división de ambos números
    }
}