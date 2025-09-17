public class SistemaGestionExcepciones
{
    public static void Run()
    {
        // Crear instancia del sistema de gestión con manejo de excepciones
        SistemaGestionExcepciones sistema = new SistemaGestionExcepciones(5);
        
        // Ejecutar demostración del sistema
        sistema.EjecutarDemo();
    }
    
    // Clase interna para representar un empleado con validaciones
    private class Empleado
    {
        public int Id { get; private set; }               // ID con validación
        private string nombres;                           // Campo privado para nombres
        private string apellidos;                         // Campo privado para apellidos
        private decimal salario;                          // Campo privado para salario
        
        // Propiedad para nombres con validación
        public string Nombres
        {
            get { return nombres; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))     // Validar que no esté vacío
                    throw new ArgumentException("Los nombres no pueden estar vacíos");
                if (value.Length < 2)                     // Validar longitud mínima
                    throw new ArgumentException("Los nombres deben tener al menos 2 caracteres");
                if (value.Length > 50)                    // Validar longitud máxima
                    throw new ArgumentException("Los nombres no pueden exceder 50 caracteres");
                if (!EsNombreValido(value))               // Validar formato del nombre
                    throw new ArgumentException("El nombre contiene caracteres inválidos");
                
                nombres = value.Trim();                   // Asignar valor validado
            }
        }
        
        // Propiedad para apellidos con validación
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))     // Validar que no esté vacío
                    throw new ArgumentException("Los apellidos no pueden estar vacíos");
                if (value.Length < 2)                     // Validar longitud mínima
                    throw new ArgumentException("Los apellidos deben tener al menos 2 caracteres");
                if (value.Length > 50)                    // Validar longitud máxima
                    throw new ArgumentException("Los apellidos no pueden exceder 50 caracteres");
                if (!EsNombreValido(value))               // Validar formato del apellido
                    throw new ArgumentException("El apellido contiene caracteres inválidos");
                
                apellidos = value.Trim();                 // Asignar valor validado
            }
        }
        
        // Propiedad para salario con validación
        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value < 425)                         // Validar salario mínimo (2024)
                    throw new ArgumentException("El salario no puede ser menor al básico ($425)");
                if (value > 10000)                       // Validar salario máximo
                    throw new ArgumentException("El salario no puede exceder $10,000");
                
                salario = value;                         // Asignar valor validado
            }
        }
        
        // Constructor con validación integrada
        public Empleado(int id, string nombres, string apellidos, decimal salario)
        {
            if (id <= 0)                                 // Validar ID positivo
                throw new ArgumentException("El ID debe ser un número positivo");
            
            Id = id;                                     // Asignar ID validado
            Nombres = nombres;                           // Usar propiedad con validación
            Apellidos = apellidos;                       // Usar propiedad con validación
            Salario = salario;                           // Usar propiedad con validación
        }
        
        // Método para validar formato de nombre
        private bool EsNombreValido(string texto)
        {
            foreach (char c in texto)                    // Recorrer cada carácter
            {
                if (!char.IsLetter(c) && c != ' ' && c != '.')  // Validar caracteres permitidos
                    return false;
            }
            return true;
        }
        
        // Método para mostrar información del empleado
        public void MostrarInfo()
        {
            System.Console.WriteLine($"ID: {Id} - {Nombres} {Apellidos}");
            System.Console.WriteLine($"Salario: {Salario:C}");
        }
    }
    
    // Campos privados del sistema
    private Empleado[] empleados;                        // Arreglo de empleados
    private int contadorEmpleados;                       // Contador de empleados
    
    // Constructor del sistema
    public SistemaGestionExcepciones(int capacidad)
    {
        empleados = new Empleado[capacidad];             // Inicializar arreglo
        contadorEmpleados = 0;                           // Inicializar contador
    }
    
    // Método para ejecutar demostración del sistema
    public void EjecutarDemo()
    {
        System.Console.WriteLine("=== SISTEMA DE GESTIÓN CON MANEJO DE EXCEPCIONES ===");
        
        // Demostración de registros exitosos
        System.Console.WriteLine("\n1. REGISTROS EXITOSOS:");
        try
        {
            RegistrarEmpleado(1, "Luis Alfonso", "Maigua Sisalema", 2500.00m);
            RegistrarEmpleado(2, "María José", "Gonzalez Pérez", 1800.00m);
            RegistrarEmpleado(3, "Carlos Manuel", "Rodríguez López", 3200.00m);
            System.Console.WriteLine("Registros exitosos completados.");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error inesperado: {ex.Message}");
        }
        
        // Demostración de manejo de excepciones
        System.Console.WriteLine("\n2. MANEJO DE EXCEPCIONES:");
        
        // Intentar registrar con ID inválido
        try
        {
            RegistrarEmpleado(-1, "Ana", "García", 500.00m);
        }
        catch (ArgumentException ex)
        {
            System.Console.WriteLine($"Error de argumento: {ex.Message}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error inesperado: {ex.Message}");
        }
        
        // Intentar registrar con nombre inválido
        try
        {
            RegistrarEmpleado(4, "Juan123", "Pérez", 800.00m);
        }
        catch (ArgumentException ex)
        {
            System.Console.WriteLine($"Error de argumento: {ex.Message}");
        }
        
        // Intentar registrar con salario inválido
        try
        {
            RegistrarEmpleado(5, "Pedro", "López", 300.00m);
        }
        catch (ArgumentException ex)
        {
            System.Console.WriteLine($"Error de argumento: {ex.Message}");
        }
        
        // Intentar registrar con nombres vacíos
        try
        {
            RegistrarEmpleado(6, "", "Martínez", 1500.00m);
        }
        catch (ArgumentException ex)
        {
            System.Console.WriteLine($"Error de argumento: {ex.Message}");
        }
        
        // Intentar exceder capacidad del sistema
        try
        {
            RegistrarEmpleado(7, "Laura", "Díaz", 2000.00m);
            RegistrarEmpleado(8, "Miguel", "Torres", 1700.00m);
            RegistrarEmpleado(9, "Sofía", "Vargas", 2100.00m); // Debería fallar
        }
        catch (InvalidOperationException ex)
        {
            System.Console.WriteLine($"Error de operación: {ex.Message}");
        }
        
        // Mostrar empleados registrados exitosamente
        System.Console.WriteLine("\n3. EMPLEADOS REGISTRADOS EXITOSAMENTE:");
        MostrarEmpleados();
        
        // Demostración de búsqueda con manejo de errores
        System.Console.WriteLine("\n4. BÚSQUEDA DE EMPLEADOS:");
        BuscarEmpleadoPorId(1);    // Existente
        BuscarEmpleadoPorId(100);  // No existente
        
        // Demostración de cálculo de nómina con validación
        System.Console.WriteLine("\n5. CÁLCULO DE NÓMINA:");
        CalcularNomina();
    }
    
    // Método para registrar empleado con manejo de excepciones
    public void RegistrarEmpleado(int id, string nombres, string apellidos, decimal salario)
    {
        try
        {
            if (contadorEmpleados >= empleados.Length)   // Validar capacidad
                throw new InvalidOperationException("Capacidad máxima de empleados alcanzada");
            
            // Crear nuevo empleado (las validaciones se hacen en el constructor)
            Empleado nuevoEmpleado = new Empleado(id, nombres, apellidos, salario);
            
            // Verificar si el ID ya existe
            for (int i = 0; i < contadorEmpleados; i++)
            {
                if (empleados[i].Id == id)
                    throw new ArgumentException($"El ID {id} ya está registrado");
            }
            
            // Agregar empleado al arreglo
            empleados[contadorEmpleados] = nuevoEmpleado;
            contadorEmpleados++;
            
            System.Console.WriteLine($"Empleado registrado: {nombres} {apellidos}");
        }
        catch (ArgumentException ex)
        {
            // Relanzar excepción para que el llamador pueda manejarla
            throw new ArgumentException($"Error al registrar empleado: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            // Encapsular excepción genérica
            throw new InvalidOperationException($"Error inesperado al registrar empleado: {ex.Message}", ex);
        }
    }
    
    // Método para mostrar todos los empleados
    public void MostrarEmpleados()
    {
        if (contadorEmpleados == 0)
        {
            System.Console.WriteLine("No hay empleados registrados.");
            return;
        }
        
        for (int i = 0; i < contadorEmpleados; i++)
        {
            empleados[i].MostrarInfo();
            System.Console.WriteLine("---");
        }
    }
    
    // Método para buscar empleado por ID con manejo de excepciones
    public void BuscarEmpleadoPorId(int id)
    {
        try
        {
            if (id <= 0)                                // Validar ID
                throw new ArgumentException("ID debe ser positivo");
            
            bool encontrado = false;
            for (int i = 0; i < contadorEmpleados; i++)
            {
                if (empleados[i].Id == id)
                {
                    System.Console.WriteLine("Empleado encontrado:");
                    empleados[i].MostrarInfo();
                    encontrado = true;
                    break;
                }
            }
            
            if (!encontrado)
                throw new KeyNotFoundException($"Empleado con ID {id} no encontrado");
        }
        catch (ArgumentException ex)
        {
            System.Console.WriteLine($"Error en búsqueda: {ex.Message}");
        }
        catch (KeyNotFoundException ex)
        {
            System.Console.WriteLine($"Búsqueda sin resultados: {ex.Message}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error inesperado en búsqueda: {ex.Message}");
        }
    }
    
    // Método para calcular nómina con validaciones
    public void CalcularNomina()
    {
        try
        {
            if (contadorEmpleados == 0)
                throw new InvalidOperationException("No hay empleados para calcular nómina");
            
            decimal totalNomina = 0;
            System.Console.WriteLine("=== CÁLCULO DE NÓMINA ===");
            
            for (int i = 0; i < contadorEmpleados; i++)
            {
                decimal salario = empleados[i].Salario;
                decimal iess = salario * 0.0945m;       // 9.45% para IESS
                decimal neto = salario - iess;
                
                System.Console.WriteLine($"{empleados[i].Nombres}: {salario:C} - IESS: {iess:C} - Neto: {neto:C}");
                totalNomina += salario;
            }
            
            System.Console.WriteLine($"TOTAL NÓMINA: {totalNomina:C}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error al calcular nómina: {ex.Message}");
        }
    }
    
    // Método para validar entrada numérica con reintentos
    public static int ValidarEntradaNumerica(string mensaje, int intentosMaximos = 3)
    {
        int intentos = 0;
        while (intentos < intentosMaximos)
        {
            try
            {
                System.Console.Write(mensaje);
                string entrada = System.Console.ReadLine();
                
                if (string.IsNullOrEmpty(entrada))
                    throw new ArgumentException("La entrada no puede estar vacía");
                
                int valor = int.Parse(entrada);
                return valor;
            }
            catch (FormatException)
            {
                intentos++;
                System.Console.WriteLine("Error: Debe ingresar un número válido.");
                System.Console.WriteLine($"Intentos restantes: {intentosMaximos - intentos}");
            }
            catch (ArgumentException ex)
            {
                intentos++;
                System.Console.WriteLine($"Error: {ex.Message}");
                System.Console.WriteLine($"Intentos restantes: {intentosMaximos - intentos}");
            }
        }
        
        throw new InvalidOperationException("Demasiados intentos fallidos. Operación cancelada.");
    }
}