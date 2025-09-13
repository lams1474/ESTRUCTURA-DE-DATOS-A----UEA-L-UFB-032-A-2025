public static class TraductorEspanolIngles     // Define una clase
{
    public static void run()       // Para ejecutar el traductor
    {
        System.Console.WriteLine("=== Traductor Español → Inglés ===");   // Imprime el encabezado en la consol

        // Diccionario español → inglés
        System.Collections.Generic.Dictionary<string, string> diccionario =      // Función: Crea un diccionario genérico almacenar palabras, clave palabra en español y valor palabra en inglés.
            new System.Collections.Generic.Dictionary<string, string>();

        // Palabras iniciales     
        diccionario.Add("tiempo", "time");       // Función: Añadir un par clave-valor al diccionario.
        diccionario.Add("persona", "person");
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
        diccionario.Add("ojo", "eye");
        diccionario.Add("mujer", "woman");
        diccionario.Add("lugar", "place");
        diccionario.Add("trabajo", "work");
        diccionario.Add("semana", "week");
        diccionario.Add("caso", "case");
        diccionario.Add("punto", "point");
        diccionario.Add("gobierno", "government");
        diccionario.Add("empresa", "company");
        diccionario.Add("hola", "hello");

        int opcion = -1;   // Función: Declarar una variable entera llamada opcion e inicializa en -1, asegura que se ejecuta almenos una vez.

        // Menú interactivo
        do     // Función: Inicia un bucle que se ejecutará al menos una vez y repetira asta q la variable opcion sea igual a cero
        {
            System.Console.WriteLine("\n==================== MENÚ ====================");  // muestra el encabezado en la consola
            System.Console.WriteLine("1. Traducir una frase");          // imprimir la opcion 1
            System.Console.WriteLine("2. Agregar palabra al diccionario");   // imprimir la opcion 2
            System.Console.WriteLine("0. Salir");                          // imprimir la opcion 0
            System.Console.Write("Seleccione una opción: ");             // Solicita al usuario ingrese una opcion del menu

            try           // Función: Intenta leer la entrada del usuario y convertirla a un entero.
            {
                opcion = int.Parse(System.Console.ReadLine());
            }
            catch
            {
                opcion = -1;
            }

            if (opcion == 1)        // Verifica si la opción seleccionada es 1
            {
                // Traducir frase
                System.Console.Write("\nIngrese una frase en español: ");    // Solicita al usuario que ingrese una frase en español que desea traducir.
                string frase = System.Console.ReadLine().ToLower();   // Leer la frase ingresada por el usuario, convierte a minúsculas para que coincida con las claves del diccionario.

                string[] palabras = frase.Split(' ');   // Separa la frase en palabras individuales
                string resultado = "";                  // Inicia una variable "resultado" como una cadena vacía, que usará para ir construyendo la frase traducida.

                foreach (string palabra in palabras)    // Inicia un bucle que recorre cada palabra en el arreglo "palabras"
                {
                    if (diccionario.ContainsKey(palabra))  // Verifica si la palabra actual existe como clave en el diccionario
                    {
                        resultado += diccionario[palabra] + " ";  // Si la palabra existe en el diccionario, añade su traducción al resultado
                    }
                    else                         // Si la palabra no está en el diccionario, agrega tal cual al resultado.
                    {
                        resultado += palabra + " ";
                    }
                }

                System.Console.WriteLine("\nTraducción: " + resultado);    // Muestra en pantalla la frase traducida
            }
            else if (opcion == 2)    // usuario quiere agregar una palabra al diccionario.
            {
                // Agregar palabra nueva
                System.Console.Write("\nIngrese palabra en español: ");  // usuario que ingrese la palabra
                string espanol = System.Console.ReadLine().ToLower();    // Lee la palabra en español y la convierte a minúsculas.

                System.Console.Write("Ingrese su traducción al inglés: ");  // Solicita la traducción al inglés de la palabra
                string ingles = System.Console.ReadLine().ToLower();   // Lee la traducción al inglés y la convierte a minúsculas

                if (!diccionario.ContainsKey(espanol))      // Verifica que la palabra en español no exista ya en el diccionario
                {
                    diccionario.Add(espanol, ingles);      // Si la palabra no existe, la agrega al diccionario con su traducción
                    System.Console.WriteLine("Palabra agregada correctamente.");  // Informa al usuario que la palabra se ha agregado exitosamente
                }
                else
                {
                    System.Console.WriteLine("La palabra ya existe en el diccionario.");  // muestra un mensaje de advertencia
                }
            }

        } while (opcion != 0);    // Cierra el bucle, que se repite hasta que el usuario ingrese 0 para salir

        System.Console.WriteLine("\nGracias por usar el traductor.");  // Muestra un mensaje
    }
}
