public class MatrizNotas
{
    public static void Run()
    {
        // Crear instancia de MatrizNotas para 3 estudiantes y 4 asignaturas
        MatrizNotas gestionNotas = new MatrizNotas(3, 4);
        
        // Agregar notas para el primer estudiante
        gestionNotas.AgregarNota(0, 0, 85);  // Estudiante 0, Asignatura 0: 85
        gestionNotas.AgregarNota(0, 1, 90);  // Estudiante 0, Asignatura 1: 90
        gestionNotas.AgregarNota(0, 2, 78);  // Estudiante 0, Asignatura 2: 78
        gestionNotas.AgregarNota(0, 3, 92);  // Estudiante 0, Asignatura 3: 92
        
        // Agregar notas para el segundo estudiante
        gestionNotas.AgregarNota(1, 0, 88);  // Estudiante 1, Asignatura 0: 88
        gestionNotas.AgregarNota(1, 1, 76);  // Estudiante 1, Asignatura 1: 76
        gestionNotas.AgregarNota(1, 2, 95);  // Estudiante 1, Asignatura 2: 95
        gestionNotas.AgregarNota(1, 3, 81);  // Estudiante 1, Asignatura 3: 81
        
        // Agregar notas para el tercer estudiante
        gestionNotas.AgregarNota(2, 0, 72);  // Estudiante 2, Asignatura 0: 72
        gestionNotas.AgregarNota(2, 1, 85);  // Estudiante 2, Asignatura 1: 85
        gestionNotas.AgregarNota(2, 2, 79);  // Estudiante 2, Asignatura 2: 79
        gestionNotas.AgregarNota(2, 3, 88);  // Estudiante 2, Asignatura 3: 88
        
        // Mostrar todas las notas de la matriz
        System.Console.WriteLine("=== MATRIZ COMPLETA DE NOTAS ===");
        gestionNotas.MostrarMatriz();  // Muestra toda la matriz de notas
        
        // Calcular y mostrar promedios por estudiante
        System.Console.WriteLine("\n=== PROMEDIOS POR ESTUDIANTE ===");
        for (int i = 0; i < 3; i++)  // Recorre los 3 estudiantes
        {
            double promedio = gestionNotas.CalcularPromedioEstudiante(i);  // Calcula promedio
            System.Console.WriteLine("Estudiante " + (i + 1) + ": " + promedio);
        }
        
        // Calcular y mostrar promedios por asignatura
        System.Console.WriteLine("\n=== PROMEDIOS POR ASIGNATURA ===");
        for (int j = 0; j < 4; j++)  // Recorre las 4 asignaturas
        {
            double promedio = gestionNotas.CalcularPromedioAsignatura(j);  // Calcula promedio
            System.Console.WriteLine("Asignatura " + (j + 1) + ": " + promedio);
        }
        
        // Encontrar y mostrar la nota más alta
        int notaMaxima = gestionNotas.EncontrarNotaMaxima();  // Encuentra nota máxima
        System.Console.WriteLine("\nNota más alta: " + notaMaxima);
        
        // Encontrar y mostrar la nota más baja
        int notaMinima = gestionNotas.EncontrarNotaMinima();  // Encuentra nota mínima
        System.Console.WriteLine("Nota más baja: " + notaMinima);
    }
    
    // Campo privado para almacenar la matriz de notas
    private int[,] notas;  // Matriz bidimensional para notas [estudiantes, asignaturas]
    private int cantidadEstudiantes;  // Cantidad de estudiantes
    private int cantidadAsignaturas;  // Cantidad de asignaturas
    
    // Constructor que inicializa la matriz con las dimensiones especificadas
    public MatrizNotas(int numEstudiantes, int numAsignaturas)
    {
        cantidadEstudiantes = numEstudiantes;  // Asigna cantidad de estudiantes
        cantidadAsignaturas = numAsignaturas;  // Asigna cantidad de asignaturas
        notas = new int[numEstudiantes, numAsignaturas];  // Crea matriz bidimensional
        
        // Inicializar toda la matriz con valores cero
        for (int i = 0; i < numEstudiantes; i++)  // Recorre estudiantes
        {
            for (int j = 0; j < numAsignaturas; j++)  // Recorre asignaturas
            {
                notas[i, j] = 0;  // Inicializa cada celda con 0
            }
        }
    }
    
    // Método para agregar una nota en la posición específica de la matriz
    public void AgregarNota(int estudiante, int asignatura, int nota)
    {
        if (estudiante >= 0 && estudiante < cantidadEstudiantes &&  // Valida estudiante
            asignatura >= 0 && asignatura < cantidadAsignaturas)    // Valida asignatura
        {
            notas[estudiante, asignatura] = nota;  // Asigna la nota en la posición
        }
        else
        {
            System.Console.WriteLine("Posición inválida en la matriz");  // Mensaje de error
        }
    }
    
    // Método para mostrar toda la matriz de notas en formato tabular
    public void MostrarMatriz()
    {
        // Encabezado de columnas (asignaturas)
        System.Console.Write("Est\\Asig\t");  // Espacio para columna de estudiantes
        for (int j = 0; j < cantidadAsignaturas; j++)  // Recorre asignaturas
        {
            System.Console.Write("Asig " + (j + 1) + "\t");  // Muestra número de asignatura
        }
        System.Console.WriteLine();  // Salto de línea
        
        // Mostrar filas con datos de notas
        for (int i = 0; i < cantidadEstudiantes; i++)  // Recorre estudiantes
        {
            System.Console.Write("Est " + (i + 1) + "\t");  // Muestra número de estudiante
            for (int j = 0; j < cantidadAsignaturas; j++)  // Recorre asignaturas
            {
                System.Console.Write(notas[i, j] + "\t");  // Muestra nota con tabulación
            }
            System.Console.WriteLine();  // Salto de línea después de cada fila
        }
    }
    
    // Método para calcular el promedio de un estudiante específico
    public double CalcularPromedioEstudiante(int estudiante)
    {
        if (estudiante < 0 || estudiante >= cantidadEstudiantes)  // Valida estudiante
        {
            return 0;  // Retorna 0 si el estudiante no es válido
        }
        
        int suma = 0;  // Inicializa suma en cero
        for (int j = 0; j < cantidadAsignaturas; j++)  // Recorre todas las asignaturas
        {
            suma += notas[estudiante, j];  // Suma cada nota del estudiante
        }
        return (double)suma / cantidadAsignaturas;  // Retorna promedio
    }
    
    // Método para calcular el promedio de una asignatura específica
    public double CalcularPromedioAsignatura(int asignatura)
    {
        if (asignatura < 0 || asignatura >= cantidadAsignaturas)  // Valida asignatura
        {
            return 0;  // Retorna 0 si la asignatura no es válida
        }
        
        int suma = 0;  // Inicializa suma en cero
        for (int i = 0; i < cantidadEstudiantes; i++)  // Recorre todos los estudiantes
        {
            suma += notas[i, asignatura];  // Suma cada nota de la asignatura
        }
        return (double)suma / cantidadEstudiantes;  // Retorna promedio
    }
    
    // Método para encontrar la nota más alta en toda la matriz
    public int EncontrarNotaMaxima()
    {
        int maxima = notas[0, 0];  // Inicia con la primera nota
        for (int i = 0; i < cantidadEstudiantes; i++)  // Recorre estudiantes
        {
            for (int j = 0; j < cantidadAsignaturas; j++)  // Recorre asignaturas
            {
                if (notas[i, j] > maxima)  // Compara con nota máxima actual
                {
                    maxima = notas[i, j];  // Actualiza nota máxima
                }
            }
        }
        return maxima;  // Retorna nota máxima encontrada
    }
    
    // Método para encontrar la nota más baja en toda la matriz
    public int EncontrarNotaMinima()
    {
        int minima = notas[0, 0];  // Inicia con la primera nota
        for (int i = 0; i < cantidadEstudiantes; i++)  // Recorre estudiantes
        {
            for (int j = 0; j < cantidadAsignaturas; j++)  // Recorre asignaturas
            {
                if (notas[i, j] < minima)  // Compara con nota mínima actual
                {
                    minima = notas[i, j];  // Actualiza nota mínima
                }
            }
        }
        return minima;  // Retorna nota mínima encontrada
    }
    
    // Método para obtener una nota específica
    public int GetNota(int estudiante, int asignatura)
    {
        if (estudiante >= 0 && estudiante < cantidadEstudiantes &&  // Valida estudiante
            asignatura >= 0 && asignatura < cantidadAsignaturas)    // Valida asignatura
        {
            return notas[estudiante, asignatura];  // Retorna nota específica
        }
        else
        {
            return -1;  // Retorna -1 para posición inválida
        }
    }
}