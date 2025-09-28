//Nueva consola Estructura de datos 2025
//Console.WriteLine("===== Universidad Estatal Amazonica =====");
//System.Console.WriteLine("===== ESTRUCTURA DE DATOS (A) =====");
//Console.WriteLine("===== Tercer Semestre =====");
//Console.WriteLine("===== Luis Alfonso Maigua Sisalema =====\n");

Console.WriteLine("===== Universidad Estatal Amazónica =====");
Console.WriteLine("===== ESTRUCTURA DE DATOS (A) =====");
Console.WriteLine("===== Tercer Semestre =====");
Console.WriteLine("===== Luis Alfonso Maigua Sisalema =====\n");  // Salto de línea para mejor formato

bool continuar = true;
while (continuar)
{
    //Console.Clear(); // Limpia la pantalla en cada iteración (mejora visual)
    Console.WriteLine("=== MENÚ PRINCIPAL ===");
    Console.WriteLine("1. VacunasCovid");
    Console.WriteLine("2. TraductorEspanolIngles");
    Console.WriteLine("3. TorneoFutbol");
    Console.WriteLine("4. CatalogoRevistass");
    Console.WriteLine("5. Salir");
    Console.Write("\nSelecciona una opción: "); 
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            VacunasCovid.run();
            break;
        case "2":
            TraductorEspanolIngles.run(); 
            break;
        case "3":
            TorneoFutbol.run(); 
            break;
        case "4":
            CatalogoRevistass.run();
            break;
        case "5":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false; // Termina el bucle
            break;
        default:
            Console.WriteLine("Opción inválida. selecciona una opción del 1 al 5.");
            break;
    }

        // Pausa solo si NO se está saliendo
    if (continuar)
    {
        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
        // Console.ReadKey(); // Espera una tecla (mejora usabilidad)
    }
}










