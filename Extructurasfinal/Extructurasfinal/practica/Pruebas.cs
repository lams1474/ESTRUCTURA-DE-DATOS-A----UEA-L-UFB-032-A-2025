
public static class Prueba
{
    public static void run()
    {
        System.Console.WriteLine("===== Traductor Español → Inglés =====");

        System.Collections.Generic.Dictionary<string, string> diccionario =
        new System.Collections.Generic.Dictionary<string, string>();

        // palabras iniciales 
        diccionario.Add("Hola", "Hello");
        diccionario.Add("Tiempo", "Time");
        diccionario.Add("año", "year");
        diccionario.Add("camino", "way");
        diccionario.Add("día", "day");
        diccionario.Add("cosa", "thing");
        diccionario.Add("hombre", "man");
        diccionario.Add("mundo", "world");
        diccionario.Add("vida", "life");
        diccionario.Add("mano", "hand");
        diccionario.Add("parte", "part");
        diccionario.Add("niño", "child");

        // declarar una variable
        int opcion = -1;

        // menu interactivo
        do
        {
            System.Console.WriteLine("\n====== Menu Lams ======");
            System.Console.WriteLine("1. Traducir una frase");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opcion");

            try
            {
                opcion = int.Parse(System.Console.ReadLine());
            }
            catch
            {
                opcion = -1;
            }

            if (opcion == 1)
            {

                // traducir frace
                System.Console.Write("\nIngrese una frase en español: ");
                string frase = System.Console.ReadLine().ToLower();

                string[] palabras = frase.Split(" ");
                string resultado = "";

                foreach (string palabra in palabras)
                {
                    if (diccionario.ContainsKey(palabra))
                    {
                        resultado += diccionario[palabra] + " ";
                    }

                    else
                    {
                        resultado += palabra + " ";
                    }
                }

                System.Console.WriteLine("\nTraduccion: " + resultado);

            }
            else if (opcion == 2)
            {
                System.Console.Write("\ningrese palabras en español: ");
                string espanol = System.Console.ReadLine().ToLower();

                System.Console.Write("Ingrese su traduccion al ingles: ");
                string ingles = System.Console.ReadLine().ToLower();

                if (!diccionario.ContainsKey(espanol))
                {
                    diccionario.Add(espanol, ingles);
                    System.Console.WriteLine("Palabra agregada correctamente.");
                }
                else
                {
                    System.Console.WriteLine("La palabra ya existe en el diccionario.");
                }

            }
        } while (opcion != 0);

        System.Console.WriteLine("\nGracias por usar el traductor.");


    }
}