public static class TorneoFutbol
{
    public static void run()
    {
        System.Console.WriteLine("=== Torneo de Fútbol ===");

        // Diccionario: Equipo → Conjunto de jugadores
        var equipos = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>>(
            System.StringComparer.OrdinalIgnoreCase);

        while (true)
        {
            System.Console.WriteLine("\n===== MENÚ =====");
            System.Console.WriteLine("1. Registrar equipo y jugadores");
            System.Console.WriteLine("2. Consultar equipos y jugadores");
            System.Console.WriteLine("3. Consultar estadísticas");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opción: ");

            var opcion = System.Console.ReadLine();
            System.Console.WriteLine();

            if (opcion == "0") break;
            if (opcion == "1")
            {
                RegistrarEquipo(equipos);
            }
            else if (opcion == "2")
            {
                ConsultarEquipos(equipos);
            }
            else if (opcion == "3")
            {
                MostrarEstadisticas(equipos);
            }
            else
            {
                System.Console.WriteLine("Opción no válida.");
            }
        }
    }

    private static void RegistrarEquipo(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>> equipos)
    {
        System.Console.Write("Ingrese el nombre del equipo: ");
        var nombreEquipo = System.Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nombreEquipo))
        {
            System.Console.WriteLine("El nombre no puede estar vacío.");
            return;
        }

        if (!equipos.ContainsKey(nombreEquipo))
        {
            equipos[nombreEquipo] = new System.Collections.Generic.HashSet<string>(System.StringComparer.OrdinalIgnoreCase);
            System.Console.WriteLine($"Equipo '{nombreEquipo}' creado.");
        }

        System.Console.WriteLine("Ingrese los jugadores separados por comas:");
        var linea = System.Console.ReadLine();
        if (string.IsNullOrWhiteSpace(linea))
        {
            System.Console.WriteLine("No se ingresaron jugadores.");
            return;
        }

        var jugadores = linea.Split(',');
        int agregados = 0, repetidos = 0;

        foreach (var jugador in jugadores)
        {
            var nombre = jugador.Trim();
            if (string.IsNullOrWhiteSpace(nombre)) continue;
            if (equipos[nombreEquipo].Add(nombre)) agregados++;
            else repetidos++;
        }

        System.Console.WriteLine($"Jugadores agregados: {agregados}, duplicados ignorados: {repetidos}.");
    }

    private static void ConsultarEquipos(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>> equipos)
    {
        if (equipos.Count == 0)
        {
            System.Console.WriteLine("No hay equipos registrados.");
            return;
        }

        foreach (var equipo in equipos)
        {
            System.Console.WriteLine($"Equipo: {equipo.Key}");
            if (equipo.Value.Count == 0)
            {
                System.Console.WriteLine("  (Sin jugadores)");
            }
            else
            {
                foreach (var jugador in equipo.Value)
                {
                    System.Console.WriteLine($"  - {jugador}");
                }
            }
        }
    }

    private static void MostrarEstadisticas(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>> equipos)
    {
        int totalEquipos = equipos.Count;
        int totalJugadores = 0;

        var todos = new System.Collections.Generic.HashSet<string>(System.StringComparer.OrdinalIgnoreCase);

        foreach (var equipo in equipos)
        {
            totalJugadores += equipo.Value.Count;
            todos.UnionWith(equipo.Value);
        }

        System.Console.WriteLine("===== ESTADÍSTICAS =====");
        System.Console.WriteLine($"Total de equipos: {totalEquipos}");
        System.Console.WriteLine($"Total de jugadores (sumando por equipo): {totalJugadores}");
        System.Console.WriteLine($"Jugadores únicos en el torneo: {todos.Count}");
    }
}
