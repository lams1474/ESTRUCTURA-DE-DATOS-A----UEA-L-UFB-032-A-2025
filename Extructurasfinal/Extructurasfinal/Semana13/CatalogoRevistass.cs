// Creacion de una clase 

public static class CatalogoRevistass
{
    public static void run()
    {
        System.Console.WriteLine("=== Catálogo de Revistas ===");   // Búsqueda Binaria Recursiva

        // Catálogo inicial
        System.Collections.Generic.List<string> revistas =
            new System.Collections.Generic.List<string>
            {
                "Chasqui",
                "Oconos",
                "Ecuador debate",
                "lams",
                "Letras verdes",
                "Lex",
                "Yuyay",
                "Vogue",
                "Elle",
                "Glamour",
                "Vistazo"
            };

        
        // Menú interactivo
        int opcion = -1;
        do
        {
            System.Console.WriteLine("===== MENÚ CATÁLOGO DE REVISTAS =====");
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("2. Mostrar catálogo");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opción: ");

            string? entrada = System.Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                opcion = -1; // entrada inválida
            }

            if (opcion == 1)
            {
                BuscarRevista(revistas);
            }
            else if (opcion == 2)
            {
                MostrarCatalogo(revistas);
            }
            else if (opcion != 0)
            {
                System.Console.WriteLine("Opción no válida.");
            }

        } while (opcion != 0);

        System.Console.WriteLine("Gracias por usar el catálogo.");
    }

    // Indica todas las revistas del catálogo
    private static void MostrarCatalogo(System.Collections.Generic.List<string> revistas)
    {
        System.Console.WriteLine("Catálogo completo de revistas (ordenado):");
        foreach (var revista in revistas)
        {
            System.Console.WriteLine(" - " + revista);
        }
    }

    // Solicita un título y realiza la búsqueda binaria recursiva
    private static void BuscarRevista(System.Collections.Generic.List<string> revistas)
    {
        System.Console.Write("Ingrese el título de la revista a buscar: ");
        string? entrada = System.Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            System.Console.WriteLine("Debe ingresar un título válido.");
            return;
        }

        string objetivo = entrada.Trim();

        bool encontrado = BusquedaBinariaRecursiva(revistas, objetivo, 0, revistas.Count - 1);

        if (encontrado)
            System.Console.WriteLine(" Encontrado\n");
        else
            System.Console.WriteLine(" No encontrado");
    }

    // búsqueda binaria recursiva 
    private static bool BusquedaBinariaRecursiva(System.Collections.Generic.List<string> lista, string objetivo, int inicio, int fin)
    {
        if (inicio > fin) return false; 

        int medio = inicio + (fin - inicio) / 2; 
        int comparacion = string.Compare(objetivo, lista[medio], System.StringComparison.OrdinalIgnoreCase);

        if (comparacion == 0) return true;                // encontrado
        else if (comparacion < 0)                          
            return BusquedaBinariaRecursiva(lista, objetivo, inicio, medio - 1);
        else                                               
            return BusquedaBinariaRecursiva(lista, objetivo, medio + 1, fin);
    }
}
