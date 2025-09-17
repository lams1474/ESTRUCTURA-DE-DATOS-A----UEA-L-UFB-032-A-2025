// Ejemplo Temperatura
public class Temperatura
{
    public static void Run()
    {
        // Crear instancia con temperatura en Celsius
        Temperatura temp = new Temperatura(100);

        // Convertir y mostrar en Fahrenheit
        System.Console.WriteLine("Celsius: " + temp.GetCelsius());
        System.Console.WriteLine("Fahrenheit: " + temp.ConvertirAFahrenheit());
    }

    private double celsius;  // Campo privado para temperatura en Celsius

    public Temperatura(double tempCelsius)
    {
        celsius = tempCelsius;  // Asigna temperatura inicial
    }

    // Método público para obtener el valor en Celsius
    public double GetCelsius()
    {
        return celsius;  // Devuelve el valor en Celsius
    }

    // Método para convertir a Fahrenheit
    public double ConvertirAFahrenheit()
    {
        return (celsius * 9 / 5) + 32;  // Fórmula de conversión a Fahrenheit
    }
}