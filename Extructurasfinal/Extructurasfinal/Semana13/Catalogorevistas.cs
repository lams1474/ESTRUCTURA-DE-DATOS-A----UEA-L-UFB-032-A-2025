public static class CatalogoRevistas
{
    public static void run()
    {
        System.Console.WriteLine("=== Catálogo de Revistas ===");

        // Catálogo implementado como lista (ordenado alfabéticamente para búsqueda binaria)
        var revistas = new System.Collections.Generic.List<string>
        {
            "Chasqui",
            "Oconos",
            "Ecuador debate",
            "Revista amazónica",
            "Letras verdes",
            "Lex",
            "Yuyay",
            "Vogue",
            "Elle",
            "Glamour",
            "Vistazo"
        };

        // Ordenamos para aplicar búsqueda binaria
        revistas.Sort();

        while (true)
        {
            System.Console.WriteLine("\n===== MENÚ =====");
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("2. Mostrar catálogo");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opción: ");

            var opcion = System.Console.ReadLine();
            System.Console.WriteLine();

            if (opcion == "0") break;
            if (opcion == "1")
            {
                BuscarRevista(revistas);
            }
            else if (opcion == "2")
            {
                MostrarCatalogo(revistas);
            }
            else
            {
                System.Console.WriteLine("Opción no válida.");
            }
        }
    }

    private static void MostrarCatalogo(System.Collections.Generic.List<string> revistas)
    {
        System.Console.WriteLine("Catálogo de revistas:");
        foreach (var revista in revistas)
        {
            System.Console.WriteLine(" - " + revista);
        }
        System.Console.WriteLine();
    }

    private static void BuscarRevista(System.Collections.Generic.List<string> revistas)
    {
        System.Console.Write("Ingrese el título de la revista a buscar: ");
        var titulo = System.Console.ReadLine();

        if (string.IsNullOrWhiteSpace(titulo))
        {
            System.Console.WriteLine("Debe ingresar un título válido.\n");
            return;
        }

        bool encontrado = BusquedaBinariaRecursiva(revistas, titulo, 0, revistas.Count - 1);

        if (encontrado)
            System.Console.WriteLine("Encontrado\n");
        else
            System.Console.WriteLine("No encontrado\n");
    }

    // Método de búsqueda binaria recursiva
    private static bool BusquedaBinariaRecursiva(System.Collections.Generic.List<string> lista, string objetivo, int inicio, int fin)
    {
        if (inicio > fin) return false; // Caso base: no encontrado

        int medio = (inicio + fin) / 2;
        int comparacion = string.Compare(objetivo, lista[medio], ignoreCase: true);

        if (comparacion == 0) return true; // Encontrado
        else if (comparacion < 0)
            return BusquedaBinariaRecursiva(lista, objetivo, inicio, medio - 1); // Buscar en la izquierda
        else
            return BusquedaBinariaRecursiva(lista, objetivo, medio + 1, fin);   // Buscar en la derecha
    }
}
