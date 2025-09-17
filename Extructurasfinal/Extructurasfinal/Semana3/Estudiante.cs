public class Estudiante
{
    public static void Run()
    {
        // Crear instancia de Estudiante con nombre y 3 calificaciones
        Estudiante estudiante = new Estudiante("Luis Maigua", 3);
        
        // Agregar calificaciones del estudiante
        estudiante.AgregarCalificacion(85);  // Agrega calificación de 85
        estudiante.AgregarCalificacion(92);  // Agrega calificación de 92
        estudiante.AgregarCalificacion(78);  // Agrega calificación de 78
        
        // Mostrar información del estudiante
        System.Console.WriteLine("=== INFORMACIÓN DEL ESTUDIANTE ===");
        System.Console.WriteLine("Nombre: " + estudiante.GetNombre());
        
        // Mostrar todas las calificaciones
        System.Console.WriteLine("=== CALIFICACIONES ===");
        estudiante.MostrarCalificaciones();
        
        // Calcular y mostrar el promedio
        double promedio = estudiante.CalcularPromedio();  // Calcula el promedio
        System.Console.WriteLine("Promedio: " + promedio);
        
        // Determinar y mostrar la situación académica
        string situacion = estudiante.DeterminarSituacion();  // Determina aprobado/reprobado
        System.Console.WriteLine("Situación: " + situacion);
        
        // Mostrar la calificación más alta
        int maxima = estudiante.ObtenerCalificacionMaxima();  // Obtiene la calificación máxima
        System.Console.WriteLine("Calificación máxima: " + maxima);
        
        // Mostrar la calificación más baja
        int minima = estudiante.ObtenerCalificacionMinima();  // Obtiene la calificación mínima
        System.Console.WriteLine("Calificación mínima: " + minima);
    }
    
    // Campos privados para almacenar datos del estudiante
    private string nombre;
    private int[] calificaciones;
    private int contadorCalificaciones;
    
    // Constructor que inicializa el estudiante con nombre y número de calificaciones
    public Estudiante(string nombreEstudiante, int numeroCalificaciones)
    {
        nombre = nombreEstudiante;  // Asigna el nombre del estudiante
        calificaciones = new int[numeroCalificaciones];  // Crea arreglo para calificaciones
        contadorCalificaciones = 0;  // Inicializa contador en cero
    }
    
    // Método para obtener el nombre del estudiante
    public string GetNombre()
    {
        return nombre;  // Retorna el nombre del estudiante
    }
    
    // Método para agregar una calificación al arreglo
    public void AgregarCalificacion(int calificacion)
    {
        if (contadorCalificaciones < calificaciones.Length)  // Verifica espacio disponible
        {
            calificaciones[contadorCalificaciones] = calificacion;  // Almacena calificación
            contadorCalificaciones++;  // Incrementa contador
        }
        else
        {
            System.Console.WriteLine("No se pueden agregar más calificaciones");  // Error
        }
    }
    
    // Método para mostrar todas las calificaciones
    public void MostrarCalificaciones()
    {
        for (int i = 0; i < contadorCalificaciones; i++)  // Recorre calificaciones
        {
            System.Console.WriteLine("Calificación " + (i + 1) + ": " + calificaciones[i]);
        }
    }
    
    // Método para calcular el promedio de calificaciones
    public double CalcularPromedio()
    {
        if (contadorCalificaciones == 0) return 0;  // Evita división por cero
        
        int suma = 0;
        for (int i = 0; i < contadorCalificaciones; i++)  // Recorre calificaciones
        {
            suma += calificaciones[i];  // Suma cada calificación
        }
        return (double)suma / contadorCalificaciones;  // Retorna promedio
    }
    
    // Método para determinar la situación académica (aprobado/reprobado)
    public string DeterminarSituacion()
    {
        double promedio = CalcularPromedio();  // Obtiene el promedio
        if (promedio >= 70)  // Si el promedio es 70 o más
        {
            return "Aprobado";  // Retorna aprobado
        }
        else
        {
            return "Reprobado";  // Retorna reprobado
        }
    }
    
    // Método para obtener la calificación máxima
    public int ObtenerCalificacionMaxima()
    {
        if (contadorCalificaciones == 0) return 0;  // Retorna 0 si no hay calificaciones
        
        int maxima = calificaciones[0];  // Inicia con primera calificación
        for (int i = 1; i < contadorCalificaciones; i++)  // Recorre calificaciones
        {
            if (calificaciones[i] > maxima)  // Compara con máxima actual
            {
                maxima = calificaciones[i];  // Actualiza máxima
            }
        }
        return maxima;  // Retorna calificación máxima
    }
    
    // Método para obtener la calificación mínima
    public int ObtenerCalificacionMinima()
    {
        if (contadorCalificaciones == 0) return 0;  // Retorna 0 si no hay calificaciones
        
        int minima = calificaciones[0];  // Inicia con primera calificación
        for (int i = 1; i < contadorCalificaciones; i++)  // Recorre calificaciones
        {
            if (calificaciones[i] < minima)  // Compara con mínima actual
            {
                minima = calificaciones[i];  // Actualiza mínima
            }
        }
        return minima;  // Retorna calificación mínima
    }
}