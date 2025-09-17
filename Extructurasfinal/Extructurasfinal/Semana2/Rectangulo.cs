public class Rectangulo
{
    public static void Run()
    {
        // Crear instancia de Rectangulo con base 8 y altura 4 unidades
        Rectangulo miRectangulo = new Rectangulo(8.0, 4.0);
        
        // Calcular y mostrar el área del rectángulo
        double area = miRectangulo.CalcularArea();          // Calcula el área: base × altura
        System.Console.WriteLine("Área del rectángulo: " + area);
        
        // Calcular y mostrar el perímetro del rectángulo
        double perimetro = miRectangulo.CalcularPerimetro(); // Calcula el perímetro
        System.Console.WriteLine("Perímetro del rectángulo: " + perimetro);
        
        // Mostrar las dimensiones actuales del rectángulo
        System.Console.WriteLine("Base del rectángulo: " + miRectangulo.GetBase());
        System.Console.WriteLine("Altura del rectángulo: " + miRectangulo.GetAltura());
    }
    
    // Campos privados para almacenar base y altura del rectángulo
    private double baseRectangulo;
    private double alturaRectangulo;
    
    // Constructor que inicializa el rectángulo con base y altura específicas
    public Rectangulo(double baseInicial, double alturaInicial)
    {
        baseRectangulo = baseInicial;    // Asigna la base al campo privado
        alturaRectangulo = alturaInicial; // Asigna la altura al campo privado
    }
    
    // Método para obtener el valor actual de la base
    public double GetBase()
    {
        return baseRectangulo;  // Devuelve el valor de la base almacenada
    }
    
    // Método para obtener el valor actual de la altura
    public double GetAltura()
    {
        return alturaRectangulo;  // Devuelve el valor de la altura almacenada
    }
    
    // Método para calcular el área del rectángulo
    // Fórmula: base × altura
    public double CalcularArea()
    {
        return baseRectangulo * alturaRectangulo;  // Multiplica base por altura
    }
    
    // Método para calcular el perímetro del rectángulo
    // Fórmula: 2 × (base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + alturaRectangulo);  // Dos veces la suma de base y altura
    }
}