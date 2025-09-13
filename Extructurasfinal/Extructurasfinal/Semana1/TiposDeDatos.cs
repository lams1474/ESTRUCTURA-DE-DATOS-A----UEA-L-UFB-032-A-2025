public class TiposDeDatos
{
    public static void run()
    {
        // Declaración de variables primitivas
        int edad = 46;               // Entero
        float altura = 1.75f;        // Flotante (se agrega 'f')
        double salario = 2000.05;    // Doble precisión
        char inicial = 'L';          // Carácter
        bool esEstudiante = true;    // Booleano

        // Operaciones aritméticas
        int suma = edad + 5;
        double division = salario / 2;

        // Operaciones relacionales
        bool mayorEdad = edad >= 18; // true
        bool salarioAlto = salario > 3000; // false

        // Operaciones lógicas
        bool resultado = esEstudiante && mayorEdad;

        // Imprimir resultados
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Salario: " + salario);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Es estudiante: " + esEstudiante);

        Console.WriteLine("\n--- Operaciones ---");
        Console.WriteLine("Edad + 5 = " + suma);
        Console.WriteLine("Salario / 2 = " + division);
        Console.WriteLine("¿Mayor de edad? " + mayorEdad);
        Console.WriteLine("¿Salario alto? " + salarioAlto);
        Console.WriteLine("¿Estudiante y mayor de edad? " + resultado);
    }
}
