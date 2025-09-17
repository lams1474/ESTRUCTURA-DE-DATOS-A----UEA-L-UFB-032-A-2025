public class Circulo
{
    public static void Run()
    {
        // Crear instancia de Circulo con radio de 5 unidades
        Circulo miCirculo = new Circulo(5.0);
        
        // Calcular y mostrar el área del círculo
        double area = miCirculo.CalcularArea();          // Calcula el área usando el radio
        System.Console.WriteLine("Área del círculo: " + area);
        
        // Calcular y mostrar el perímetro del círculo
        double perimetro = miCirculo.CalcularPerimetro(); // Calcula el perímetro (circunferencia)
        System.Console.WriteLine("Perímetro del círculo: " + perimetro);
        
        // Mostrar el radio actual del círculo
        System.Console.WriteLine("Radio del círculo: " + miCirculo.GetRadio());
    }
    
    // Campo privado para almacenar el radio del círculo
    private double radio;
    
    // Constructor que inicializa el círculo con un radio específico
    public Circulo(double radioInicial)
    {
        radio = radioInicial;  // Asigna el valor del radio al campo privado
    }
    
    // Método para obtener el valor actual del radio
    public double GetRadio()
    {
        return radio;  // Devuelve el valor del radio almacenado
    }
    
    // Método para calcular el área del círculo
    // Fórmula: π * radio²
    public double CalcularArea()
    {
        return System.Math.PI * radio * radio;  // π multiplicado por radio al cuadrado
    }
    
    // Método para calcular el perímetro (circunferencia) del círculo
    // Fórmula: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * System.Math.PI * radio;  // Dos veces π multiplicado por el radio
    }
}