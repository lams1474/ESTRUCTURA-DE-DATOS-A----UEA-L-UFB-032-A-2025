public class CalculadoraCientifica
{
    public static void Run()
    {
        // Crear instancia de calculadora
        CalculadoraCientifica calc = new CalculadoraCientifica();
        
        // Realizar diversas operaciones
        System.Console.WriteLine("Potencia (2^3): " + calc.Potencia(2, 3));
        System.Console.WriteLine("Raíz cuadrada de 25: " + calc.RaizCuadrada(25));
        System.Console.WriteLine("15% de 200: " + calc.Porcentaje(200, 15));
        System.Console.WriteLine("Valor absoluto de -10: " + calc.ValorAbsoluto(-10));
    }
    
    // Método para calcular potencia
    public double Potencia(double baseNum, double exponente)
    {
        return System.Math.Pow(baseNum, exponente);  // Usa Math.Pow para potencia
    }
    
    // Método para calcular raíz cuadrada
    public double RaizCuadrada(double numero)
    {
        return System.Math.Sqrt(numero);  // Usa Math.Sqrt para raíz cuadrada
    }
    
    // Método para calcular porcentaje
    public double Porcentaje(double total, double porcentaje)
    {
        return (total * porcentaje) / 100;  // Fórmula básica de porcentaje
    }
    
    // Método para valor absoluto
    public double ValorAbsoluto(double numero)
    {
        return System.Math.Abs(numero);  // Usa Math.Abs para valor absoluto
    }
}