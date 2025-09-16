public class Numero
{
    public static void run()
    {
        // Crear una instancia de Numero con un valor inicial 10
        Numero numero1 = new Numero(10);

        // Crear una segunda instancia con un valor inicial 5
        Numero numero2 = new Numero(5);

        // Mostrar los valores iniciales
        System.Console.WriteLine("Valor de numero1: " + numero1.Valor);
        System.Console.WriteLine("Valor de numero2: " + numero2.Valor);

        // Realizamos operaciones
        int suma = numero1.Sumar(numero2.Valor);   // suma 10 + 5
        int resta = numero1.Resta(numero2.Valor);  // resta 10 - 5

        // Mostrar resultados 
        System.Console.WriteLine("Suma: " + suma);
        System.Console.WriteLine("Resta: " + resta);
    }

    // Campo privado para almacenar el valor encapsulado
    private int valor;

    // Constructor que inicializa el valor
    public Numero(int valorInicial)
    {
        valor = valorInicial;
    }

    // Propiedad para acceder al valor
    public int Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    // Método para sumar otro número
    public int Sumar(int otroNumero)
    {
        return valor + otroNumero;
    }

    // Método para restar otro número
    public int Resta(int otroNumero)
    {
        return valor - otroNumero;
    }
}
