public static class CampaniaVacunacion
{
    public static void run()
    {
        System.Console.WriteLine("=== Campaña de Vacunación COVID-19 ===");

        // Conjunto de 500 ciudadanos ficticios (IDs del 1 al 500)
        var ciudadanos = new System.Collections.Generic.HashSet<int>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add(i);
        }

        // Conjunto de 75 vacunados con Pfizer (IDs 1–75)
        var pfizer = new System.Collections.Generic.HashSet<int>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add(i);
        }

        // Conjunto de 75 vacunados con AstraZeneca (IDs 50–124 para generar intersección)
        var astrazeneca = new System.Collections.Generic.HashSet<int>();
        for (int i = 50; i <= 124; i++)
        {
            astrazeneca.Add(i);
        }

        // 1. Ciudadanos no vacunados
        var vacunados = new System.Collections.Generic.HashSet<int>(pfizer);
        vacunados.UnionWith(astrazeneca); // Pfizer ∪ AstraZeneca
        var noVacunados = new System.Collections.Generic.HashSet<int>(ciudadanos);
        noVacunados.ExceptWith(vacunados); // ciudadanos - vacunados

        // 2. Ciudadanos con ambas dosis (Pfizer ∩ AstraZeneca)
        var ambasDosis = new System.Collections.Generic.HashSet<int>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        // 3. Solo Pfizer
        var soloPfizer = new System.Collections.Generic.HashSet<int>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        // 4. Solo AstraZeneca
        var soloAstraZeneca = new System.Collections.Generic.HashSet<int>(astrazeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        // Mostrar resultados
        System.Console.WriteLine($"\nTotal ciudadanos: {ciudadanos.Count}");
        System.Console.WriteLine($"No vacunados: {noVacunados.Count}");
        System.Console.WriteLine($"Ambas dosis (Pfizer + AstraZeneca): {ambasDosis.Count}");
        System.Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
        System.Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");

        // Listado detallado (opcional)
        System.Console.WriteLine("\n--- Listado de resultados ---");
        System.Console.WriteLine("No vacunados: " + string.Join(", ", noVacunados));
        System.Console.WriteLine("\nAmbas dosis: " + string.Join(", ", ambasDosis));
        System.Console.WriteLine("\nSolo Pfizer: " + string.Join(", ", soloPfizer));
        System.Console.WriteLine("\nSolo AstraZeneca: " + string.Join(", ", soloAstraZeneca));
    }
}
