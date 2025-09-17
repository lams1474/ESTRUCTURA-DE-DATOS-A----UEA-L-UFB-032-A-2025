public class SistemaAportes
{
    public static void Run()
    {
        // Crear instancia del sistema de aportes con capacidad para 10 miembros
        SistemaAportes sistema = new SistemaAportes(10);
        
        // Registrar miembros en la asociación
        sistema.RegistrarMiembro(1, "Luis Alfonso", "Maigua Sisalema", "0996813865", "Calle Rafael Morales");
        sistema.RegistrarMiembro(2, "María José", "Gonzalez Pérez", "0987654321", "Av. Amazonas 123");
        sistema.RegistrarMiembro(3, "Carlos Manuel", "Rodríguez López", "0976543210", "Calle Juan León Mera");
        
        // Registrar aportes de los miembros
        sistema.RegistrarAporte(1, 2024, 1, 50.00m);  // Luis Alfonso - Enero 2024
        sistema.RegistrarAporte(1, 2024, 2, 50.00m);  // Luis Alfonso - Febrero 2024
        sistema.RegistrarAporte(2, 2024, 1, 75.00m);  // María José - Enero 2024
        sistema.RegistrarAporte(3, 2024, 1, 100.00m); // Carlos Manuel - Enero 2024
        sistema.RegistrarAporte(1, 2024, 3, 60.00m);  // Luis Alfonso - Marzo 2024
        
        // Mostrar menú principal del sistema
        sistema.MostrarMenuPrincipal();
    }
    
    // Clase interna para representar un miembro de la asociación
    private class Miembro
    {
        public int Id { get; set; }                      // Identificador único del miembro
        public string Nombres { get; set; }              // Nombres del miembro
        public string Apellidos { get; set; }            // Apellidos del miembro
        public string Telefono { get; set; }             // Teléfono de contacto
        public string Direccion { get; set; }            // Dirección residencial
        public decimal[,] Aportes { get; set; }          // Matriz de aportes [años, meses]
        
        public Miembro(int id, string nombres, string apellidos, string telefono, string direccion)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Aportes = new decimal[10, 12];  // Matriz para 10 años y 12 meses
        }
    }
    
    // Campos privados del sistema
    private Miembro[] miembros;                          // Arreglo de miembros
    private int contadorMiembros;                        // Contador de miembros registrados
    private const int MAX_ANIOS = 10;                    // Máximo años de registro
    private const int MAX_MESES = 12;                    // 12 meses por año
    
    // Constructor del sistema
    public SistemaAportes(int capacidadMaxima)
    {
        miembros = new Miembro[capacidadMaxima];         // Inicializa arreglo de miembros
        contadorMiembros = 0;                            // Inicializa contador en cero
    }
    
    // Método para registrar un nuevo miembro en la asociación
    public void RegistrarMiembro(int id, string nombres, string apellidos, string telefono, string direccion)
    {
        if (contadorMiembros < miembros.Length)          // Verifica si hay capacidad
        {
            miembros[contadorMiembros] = new Miembro(id, nombres, apellidos, telefono, direccion);
            contadorMiembros++;                          // Incrementa contador
            System.Console.WriteLine("Miembro registrado: " + nombres + " " + apellidos);
        }
        else
        {
            System.Console.WriteLine("Capacidad máxima alcanzada. No se pueden registrar más miembros.");
        }
    }
    
    // Método para registrar un aporte de un miembro
    public void RegistrarAporte(int idMiembro, int anio, int mes, decimal monto)
    {
        Miembro miembro = BuscarMiembroPorId(idMiembro); // Busca el miembro por ID
        if (miembro != null && mes >= 1 && mes <= 12 && anio >= 2020 && anio <= 2029)
        {
            int indexAnio = anio - 2020;                 // Calcula índice del año
            miembro.Aportes[indexAnio, mes - 1] = monto; // Registra aporte en matriz
            System.Console.WriteLine("Aporte registrado: " + monto.ToString("C") + 
                                   " para " + miembro.Nombres + " - " + mes + "/" + anio);
        }
        else
        {
            System.Console.WriteLine("Error: No se pudo registrar el aporte. Verifique los datos.");
        }
    }
    
    // Método para buscar miembro por ID
    private Miembro BuscarMiembroPorId(int id)
    {
        for (int i = 0; i < contadorMiembros; i++)       // Recorre todos los miembros
        {
            if (miembros[i].Id == id)                    // Compara ID
            {
                return miembros[i];                      // Retorna miembro encontrado
            }
        }
        return null;                                     // Retorna null si no encuentra
    }
    
    // Método para mostrar el menú principal del sistema
    public void MostrarMenuPrincipal()
    {
        bool continuar = true;
        while (continuar)
        {
            System.Console.WriteLine("\n=== SISTEMA DE REGISTRO DE APORTES ===");
            System.Console.WriteLine("1. Visualizar todos los miembros");
            System.Console.WriteLine("2. Consultar aportes de un miembro");
            System.Console.WriteLine("3. Ver reporte general de aportes");
            System.Console.WriteLine("4. Buscar miembro por nombre");
            System.Console.WriteLine("5. Salir");
            System.Console.Write("Seleccione una opción: ");
            
            string opcion = System.Console.ReadLine();   // Lee opción del usuario
            
            switch (opcion)
            {
                case "1":
                    VisualizarTodosLosMiembros();        // Opción 1: Ver todos los miembros
                    break;
                case "2":
                    ConsultarAportesMiembro();           // Opción 2: Consultar aportes
                    break;
                case "3":
                    GenerarReporteGeneral();             // Opción 3: Reporte general
                    break;
                case "4":
                    BuscarMiembroPorNombre();            // Opción 4: Buscar por nombre
                    break;
                case "5":
                    continuar = false;                   // Opción 5: Salir
                    System.Console.WriteLine("¡Gracias por usar el sistema!");
                    break;
                default:
                    System.Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }
    
    // Método para visualizar todos los miembros registrados
    public void VisualizarTodosLosMiembros()
    {
        System.Console.WriteLine("\n=== LISTA DE TODOS LOS MIEMBROS ===");
        if (contadorMiembros == 0)
        {
            System.Console.WriteLine("No hay miembros registrados.");
            return;
        }
        
        for (int i = 0; i < contadorMiembros; i++)       // Recorre todos los miembros
        {
            Miembro m = miembros[i];
            System.Console.WriteLine($"ID: {m.Id} - {m.Nombres} {m.Apellidos}");
            System.Console.WriteLine($"   Teléfono: {m.Telefono}");
            System.Console.WriteLine($"   Dirección: {m.Direccion}");
            System.Console.WriteLine("   ---");
        }
    }
    
    // Método para consultar los aportes de un miembro específico
    public void ConsultarAportesMiembro()
    {
        System.Console.Write("Ingrese el ID del miembro: ");
        if (int.TryParse(System.Console.ReadLine(), out int id))
        {
            Miembro miembro = BuscarMiembroPorId(id);    // Busca miembro por ID
            if (miembro != null)
            {
                System.Console.WriteLine($"\n=== APORTES DE {miembro.Nombres} {miembro.Apellidos} ===");
                
                decimal totalGeneral = 0;
                for (int anio = 0; anio < MAX_ANIOS; anio++)  // Recorre años
                {
                    decimal totalAnual = 0;
                    bool tieneAportes = false;
                    
                    for (int mes = 0; mes < MAX_MESES; mes++)  // Recorre meses
                    {
                        if (miembro.Aportes[anio, mes] > 0)    // Si tiene aporte
                        {
                            if (!tieneAportes)
                            {
                                System.Console.WriteLine($"Año {2020 + anio}:");
                                tieneAportes = true;
                            }
                            System.Console.WriteLine($"   Mes {mes + 1}: {miembro.Aportes[anio, mes]:C}");
                            totalAnual += miembro.Aportes[anio, mes];
                        }
                    }
                    
                    if (tieneAportes)
                    {
                        System.Console.WriteLine($"   Total {2020 + anio}: {totalAnual:C}");
                        totalGeneral += totalAnual;
                    }
                }
                
                System.Console.WriteLine($"TOTAL GENERAL: {totalGeneral:C}");
            }
            else
            {
                System.Console.WriteLine("Miembro no encontrado.");
            }
        }
        else
        {
            System.Console.WriteLine("ID inválido.");
        }
    }
    
    // Método para generar reporte general de todos los aportes
    public void GenerarReporteGeneral()
    {
        System.Console.WriteLine("\n=== REPORTE GENERAL DE APORTES ===");
        
        decimal totalGeneral = 0;
        for (int i = 0; i < contadorMiembros; i++)       // Recorre miembros
        {
            Miembro m = miembros[i];
            decimal totalMiembro = 0;
            
            for (int anio = 0; anio < MAX_ANIOS; anio++)  // Recorre años
            {
                for (int mes = 0; mes < MAX_MESES; mes++)  // Recorre meses
                {
                    totalMiembro += m.Aportes[anio, mes]; // Suma aportes del miembro
                }
            }
            
            System.Console.WriteLine($"{m.Nombres} {m.Apellidos}: {totalMiembro:C}");
            totalGeneral += totalMiembro;                // Acumula total general
        }
        
        System.Console.WriteLine("-------------------------------");
        System.Console.WriteLine($"TOTAL RECAUDADO: {totalGeneral:C}");
        System.Console.WriteLine($"TOTAL DE MIEMBROS: {contadorMiembros}");
    }
    
    // Método para buscar miembros por nombre
    public void BuscarMiembroPorNombre()
    {
        System.Console.Write("Ingrese el nombre a buscar: ");
        string nombreBusqueda = System.Console.ReadLine().ToLower();  // Convertir a minúsculas
        
        System.Console.WriteLine("\n=== RESULTADOS DE BÚSQUEDA ===");
        bool encontrado = false;
        
        for (int i = 0; i < contadorMiembros; i++)       // Recorre miembros
        {
            Miembro m = miembros[i];
            if (m.Nombres.ToLower().Contains(nombreBusqueda) || 
                m.Apellidos.ToLower().Contains(nombreBusqueda))
            {
                System.Console.WriteLine($"ID: {m.Id} - {m.Nombres} {m.Apellidos}");
                System.Console.WriteLine($"   Teléfono: {m.Telefono}");
                encontrado = true;
            }
        }
        
        if (!encontrado)
        {
            System.Console.WriteLine("No se encontraron miembros con ese nombre.");
        }
    }
}