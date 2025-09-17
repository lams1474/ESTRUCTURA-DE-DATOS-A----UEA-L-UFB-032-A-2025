public class Estudiantee
{
    public static void Run()
    {
        // Crear instancia de Estudiantee con datos completos de Luis Alfonso
        Estudiantee estudiantee1 = new Estudiantee(
            1002,                                       // ID del estudiantee
            "Luis Alfonso",                             // Nombres del estudiantee
            "Maigua Sisalema",                          // Apellidos del estudiantee
            "Calle Rafael Morales y Calle A",           // Dirección del estudiantee
            new string[] { "0996813865", "022345678", "044567890" }  // Array de teléfonos
        );
        
        // Mostrar información completa del estudiantee
        System.Console.WriteLine("=== INFORMACIÓN DEL ESTUDIANTEE ===");
        estudiantee1.MostrarInformacion();               // Muestra todos los datos del estudiantee
        
        System.Console.WriteLine("\n=== TELÉFONOS REGISTRADOS ===");
        estudiantee1.MostrarTelefonos();                 // Muestra solo los números telefónicos
        
        // Agregar un nuevo teléfono al estudiantee
        System.Console.WriteLine("\n=== AGREGAR NUEVO TELÉFONO ===");
        estudiantee1.AgregarTelefono("0987654321");      // Agrega un cuarto número telefónico
        estudiantee1.MostrarTelefonos();                 // Muestra los teléfonos actualizados
        
        // Intentar agregar más teléfonos de los permitidos
        System.Console.WriteLine("\n=== INTENTO DE AGREGAR TELÉFONO EXTRA ===");
        estudiantee1.AgregarTelefono("0999999999");      // Intenta agregar un quinto teléfono
    }
    
    // Campos privados para almacenar los datos del estudiantee
    private int id;                                      // Almacena el ID único del estudiantee
    private string nombres;                              // Almacena los nombres del estudiantee
    private string apellidos;                            // Almacena los apellidos del estudiantee
    private string direccion;                            // Almacena la dirección del estudiantee
    private string[] telefonos;                          // Array para almacenar los teléfonos
    private int contadorTelefonos;                       // Contador de teléfonos registrados
    
    // Constructor de la clase Estudiantee que recibe todos los datos iniciales
    public Estudiantee(int idEstudiantee, string nombresEstudiantee, string apellidosEstudiantee, 
                     string direccionEstudiantee, string[] telefonosIniciales)
    {
        id = idEstudiantee;                               // Asigna el ID del estudiantee
        nombres = nombresEstudiantee;                     // Asigna los nombres del estudiantee
        apellidos = apellidosEstudiantee;                 // Asigna los apellidos del estudiantee
        direccion = direccionEstudiantee;                 // Asigna la dirección del estudiantee
        telefonos = new string[4];                       // Crea array para máximo 4 teléfonos
        contadorTelefonos = 0;                           // Inicializa contador en cero
        
        // Agregar teléfonos iniciales al array
        foreach (string telefono in telefonosIniciales)  // Recorre cada teléfono inicial
        {
            if (contadorTelefonos < telefonos.Length)    // Verifica si hay espacio disponible
            {
                telefonos[contadorTelefonos] = telefono; // Agrega teléfono al array
                contadorTelefonos++;                     // Incrementa el contador
            }
        }
    }
    
    // Método para mostrar toda la información del estudiantee
    public void MostrarInformacion()
    {
        System.Console.WriteLine("ID: " + id);                          // Muestra el ID
        System.Console.WriteLine("Nombres: " + nombres);                // Muestra los nombres
        System.Console.WriteLine("Apellidos: " + apellidos);            // Muestra los apellidos
        System.Console.WriteLine("Dirección: " + direccion);            // Muestra la dirección
        System.Console.WriteLine("Cantidad de teléfonos: " + contadorTelefonos); // Muestra cantidad
        
        // Mostrar cada teléfono registrado
        for (int i = 0; i < contadorTelefonos; i++)                     // Recorre teléfonos
        {
            System.Console.WriteLine("Teléfono " + (i + 1) + ": " + telefonos[i]); // Muestra cada teléfono
        }
    }
    
    // Método para mostrar solo los números telefónicos
    public void MostrarTelefonos()
    {
        if (contadorTelefonos == 0)                                     // Verifica si hay teléfonos
        {
            System.Console.WriteLine("No hay teléfonos registrados.");  // Mensaje si no hay teléfonos
            return;
        }
        
        System.Console.WriteLine("=== LISTA DE TELÉFONOS ===");
        for (int i = 0; i < contadorTelefonos; i++)                     // Recorre teléfonos
        {
            System.Console.WriteLine((i + 1) + ". " + telefonos[i]);    // Muestra número con índice
        }
    }
    
    // Método para agregar un nuevo número telefónico al array
    public void AgregarTelefono(string nuevoTelefono)
    {
        if (contadorTelefonos < telefonos.Length)                       // Verifica espacio disponible
        {
            telefonos[contadorTelefonos] = nuevoTelefono;               // Agrega nuevo teléfono
            contadorTelefonos++;                                        // Incrementa contador
            System.Console.WriteLine("Teléfono agregado: " + nuevoTelefono); // Mensaje de confirmación
        }
        else
        {
            // Mensaje de error si no hay espacio
            System.Console.WriteLine("No se pueden agregar más teléfonos. Límite alcanzado (4 teléfonos).");
        }
    }
    
    // Método para obtener el ID del estudiantee
    public int GetId()
    {
        return id;                                  // Retorna el ID del estudiantee
    }
    
    // Método para obtener los nombres del estudiantee
    public string GetNombres()
    {
        return nombres;                             // Retorna los nombres del estudiantee
    }
    
    // Método para obtener los apellidos del estudiantee
    public string GetApellidos()
    {
        return apellidos;                           // Retorna los apellidos del estudiantee
    }
    
    // Método para obtener la dirección del estudiantee
    public string GetDireccion()
    {
        return direccion;                           // Retorna la dirección del estudiantee
    }
    
    // Método para obtener la cantidad de teléfonos registrados
    public int GetCantidadTelefonos()
    {
        return contadorTelefonos;                   // Retorna la cantidad de teléfonos
    }
    
    // Método para obtener un teléfono específico por índice
    public string GetTelefono(int indice)
    {
        if (indice >= 0 && indice < contadorTelefonos)  // Verifica índice válido
        {
            return telefonos[indice];                   // Retorna el teléfono solicitado
        }
        else
        {
            return "Índice inválido";                   // Mensaje de error para índice inválido
        }
    }
}