public class GestorNumeros
{
    public static void Run()
    {
        // Crear instancia de GestorNumeros con capacidad para 5 números
        GestorNumeros gestor = new GestorNumeros(5);
        
        // Agregar números al arreglo
        gestor.AgregarNumero(10);  // Agrega el número 10 al arreglo
        gestor.AgregarNumero(25);  // Agrega el número 25 al arreglo
        gestor.AgregarNumero(15);  // Agrega el número 15 al arreglo
        gestor.AgregarNumero(30);  // Agrega el número 30 al arreglo
        gestor.AgregarNumero(20);  // Agrega el número 20 al arreglo
        
        // Mostrar todos los números almacenados
        System.Console.WriteLine("=== TODOS LOS NÚMEROS ===");
        gestor.MostrarNumeros();  // Muestra todos los números del arreglo
        
        // Calcular y mostrar el promedio de los números
        double promedio = gestor.CalcularPromedio();  // Calcula el promedio de los números
        System.Console.WriteLine("Promedio: " + promedio);
        
        // Encontrar y mostrar el número mayor
        int mayor = gestor.EncontrarMayor();  // Encuentra el número más grande
        System.Console.WriteLine("Número mayor: " + mayor);
        
        // Encontrar y mostrar el número menor
        int menor = gestor.EncontrarMenor();  // Encuentra el número más pequeño
        System.Console.WriteLine("Número menor: " + menor);
        
        // Mostrar la suma total de todos los números
        int suma = gestor.CalcularSuma();  // Calcula la suma de todos los números
        System.Console.WriteLine("Suma total: " + suma);
    }
    
    // Campo privado para almacenar el arreglo de números
    private int[] numeros;
    
    // Campo privado para llevar el conteo de números agregados
    private int contador;
    
    // Constructor que inicializa el arreglo con una capacidad específica
    public GestorNumeros(int capacidad)
    {
        numeros = new int[capacidad];  // Crea un nuevo arreglo con el tamaño especificado
        contador = 0;  // Inicializa el contador en cero
    }
    
    // Método para agregar un número al arreglo
    public void AgregarNumero(int numero)
    {
        if (contador < numeros.Length)  // Verifica si hay espacio disponible
        {
            numeros[contador] = numero;  // Agrega el número en la posición actual
            contador++;  // Incrementa el contador de números
        }
        else
        {
            System.Console.WriteLine("El arreglo está lleno");  // Mensaje de error
        }
    }
    
    // Método para mostrar todos los números del arreglo
    public void MostrarNumeros()
    {
        for (int i = 0; i < contador; i++)  // Recorre todos los números agregados
        {
            System.Console.WriteLine("Número " + (i + 1) + ": " + numeros[i]);
        }
    }
    
    // Método para calcular el promedio de los números
    public double CalcularPromedio()
    {
        if (contador == 0) return 0;  // Evita división por cero
        
        int suma = CalcularSuma();  // Obtiene la suma total
        return (double)suma / contador;  // Calcula el promedio
    }
    
    // Método para encontrar el número mayor en el arreglo
    public int EncontrarMayor()
    {
        if (contador == 0) return 0;  // Retorna 0 si no hay números
        
        int mayor = numeros[0];  // Inicializa con el primer número
        for (int i = 1; i < contador; i++)  // Recorre desde el segundo número
        {
            if (numeros[i] > mayor)  // Compara con el número mayor actual
            {
                mayor = numeros[i];  // Actualiza el número mayor
            }
        }
        return mayor;  // Retorna el número mayor encontrado
    }
    
    // Método para encontrar el número menor en el arreglo
    public int EncontrarMenor()
    {
        if (contador == 0) return 0;  // Retorna 0 si no hay números
        
        int menor = numeros[0];  // Inicializa con el primer número
        for (int i = 1; i < contador; i++)  // Recorre desde el segundo número
        {
            if (numeros[i] < menor)  // Compara con el número menor actual
            {
                menor = numeros[i];  // Actualiza el número menor
            }
        }
        return menor;  // Retorna el número menor encontrado
    }
    
    // Método para calcular la suma total de todos los números
    public int CalcularSuma()
    {
        int suma = 0;  // Inicializa la suma en cero
        for (int i = 0; i < contador; i++)  // Recorre todos los números
        {
            suma += numeros[i];  // Suma cada número al total
        }
        return suma;  // Retorna la suma total
    }
}