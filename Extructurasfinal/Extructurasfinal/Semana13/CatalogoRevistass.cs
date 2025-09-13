// Creacion de una clase estática CatalogoRevistass
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class CatalogoRevistass
{
    public static void run()          // Método run sirve como punto de ejecución del catálogo
    {
        System.Console.WriteLine("=== Catalogo de revistas ===");  // Imprime un título inicial en la consola para identificar el programa.

        // Construccion del catálogo -lista de revistas-
        System.Collections.Generic.List<string> revistas =      // Declara una lista de cadenas (List<string>) contendrá los títulos de revistas.
        new System.Collections.Generic.List<string>
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

        // ordenar el catalogo para poder ABB
        revistas.Sort();        // Ordena alfabéticamente la lista para poder aplicar el algoritmo de búsqueda binaria.

        // Menu interactivo
        int opcion = -1;  // declarar una variable para guardar la opción elegida del menú. Inicia en -1 para diferenciar de 0 (salida).
        do     // utilizamos un ciclo do-while que muestra el menú repetidamente hasta que el usuario ingrese 0.
        {
            System.Console.WriteLine("\n=== Menu ===");    // Muestra en pantalla las opciones del menú
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("2. Mostrar catalogo");
            System.Console.WriteLine("0. salir");
            System.Console.Write("seleccione una opcion: ");

            // Captura la opción ingresada por el usuario y la convierte a número 
            try
            {
                opcion = int.Parse(System.Console.ReadLine());
            }

            catch
            {
                opcion = -1; // De haber error en la entrada se reinicia
            }

            // Si el usuario elige 1, llama al método BuscarRevista
            if (opcion == 1)
            {
                BuscarRevista(revistas);
            }

            // Si el usuario elige 2, llama al método MostrarCatalogo
            else if (opcion == 2)
            {
                MostrarCatalogo(revistas);
            }

            // Si no es 0, muestra mensaje de -opción no válida-
            else if (opcion != 0)
            {
                System.Console.WriteLine("Opcion no valida.");
            }

        } while (opcion != 0);

        System.Console.WriteLine("\nGracias por usar el catálogo.");

        {

            // Metodo auxiliar para mostrar el catalogo 
        private static void MostrarCatalogo(System.Configuration.Generic.List<string> revistas)
    {

        System.Console.WriteLine("\nCatalogo de revistas:");
        foreach (var revista in revistas)
        {
            System.Console.WriteLine(" - " + revista);
        }

            // Metodo auxiliar para buscar revistas 
            private static void BuscarRevista(System.Collections.Generic.List<string> revistas)
    {
        System.Console.Write("\nIngrese el titulo a buscar: ");
        string titulo = System.Console.ReadLine();

        // 
        System.Console.WriteLine($"(Simulacion) Usted Busco: {titulo}");
    }

        }
    }



    }

}