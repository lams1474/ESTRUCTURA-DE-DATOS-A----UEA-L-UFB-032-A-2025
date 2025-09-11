public static class VacunasCovid
{
    public static void run()
    {
        System.Console.WriteLine("=== Campaña de Vacunación COVID-19 ===");

        var random = new System.Random();

        // Conjunto total de ciudadanos
        var todos = new System.Collections.Generic.HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todos.Add("Persona " + i);
        }

        // Pfizer (75 ciudadanos aleatorios)
        var pfizer = new System.Collections.Generic.HashSet<string>();
        for (int i = 0; i < 75; i++)
        {
            pfizer.Add("Persona " + random.Next(1, 501));
        }

        // AstraZeneca (75 ciudadanos aleatorios)
        var astrazeneca = new System.Collections.Generic.HashSet<string>();
        for (int i = 0; i < 75; i++)
        {
            astrazeneca.Add("Persona " + random.Next(1, 501));
        }

        // Solo Pfizer
        var soloPfizer = new System.Collections.Generic.HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        // Solo AstraZeneca
        var soloAstra = new System.Collections.Generic.HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer);

        // Ambas dosis
        var ambas = new System.Collections.Generic.HashSet<string>(pfizer);
        ambas.IntersectWith(astrazeneca);

        // No vacunados
        var vacunados = new System.Collections.Generic.HashSet<string>(pfizer);
        vacunados.UnionWith(astrazeneca);

        var noVacunados = new System.Collections.Generic.HashSet<string>(todos);
        noVacunados.ExceptWith(vacunados);

        // Resultados
        System.Console.WriteLine($"\nVacunados con solo Pfizer: {soloPfizer.Count}");
        System.Console.WriteLine($"Vacunados con solo AstraZeneca: {soloAstra.Count}");
        System.Console.WriteLine($"Vacunados con ambas dosis: {ambas.Count}");
        System.Console.WriteLine($"No vacunados: {noVacunados.Count}");
    }
}
