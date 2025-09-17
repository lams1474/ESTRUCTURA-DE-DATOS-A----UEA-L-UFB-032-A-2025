public class ListaNumerosAleatorios
{
    public static void Run()
    {
        ListaNumerosAleatorios sistema = new ListaNumerosAleatorios();
        sistema.Ejecutar();
    }

    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Siguiente { get; set; }
    }

    private Nodo cabeza;
    private Random random = new Random();

    private void Ejecutar()
    {
        CrearListaAleatoria();
        
        Console.WriteLine("LISTA DE NÚMEROS ALEATORIOS");
        Console.WriteLine("============================");
        MostrarLista();

        Console.WriteLine("\nELIMINAR NODOS FUERA DE RANGO");
        Console.WriteLine("=============================");
        
        Console.Write("Ingrese el valor mínimo del rango: ");
        string minInput = Console.ReadLine();
        if (!int.TryParse(minInput, out int min))
        {
            Console.WriteLine("Valor mínimo no válido. Usando 1 por defecto.");
            min = 1;
        }
        
        Console.Write("Ingrese el valor máximo del rango: ");
        string maxInput = Console.ReadLine();
        if (!int.TryParse(maxInput, out int max))
        {
            Console.WriteLine("Valor máximo no válido. Usando 999 por defecto.");
            max = 999;
        }

        EliminarFueraDeRango(min, max);
        
        Console.WriteLine("\nLISTA DESPUÉS DE ELIMINAR FUERA DE RANGO");
        Console.WriteLine("========================================");
        MostrarLista();
        
        Console.WriteLine("\nPresione ENTER para salir...");
        LeerLineaSegura();
    }

    private void LeerLineaSegura()
    {
        try
        {
            Console.ReadLine();
        }
        catch (InvalidOperationException)
        {
            Thread.Sleep(1000);
        }
    }

    private void CrearListaAleatoria()
    {
        for (int i = 0; i < 50; i++)
        {
            Nodo nuevo = new Nodo
            {
                Valor = random.Next(1, 1000),
                Siguiente = cabeza
            };
            cabeza = nuevo;
        }
    }

    private void EliminarFueraDeRango(int min, int max)
    {
        Nodo actual = cabeza;
        Nodo anterior = null;

        while (actual != null)
        {
            if (actual.Valor < min || actual.Valor > max)
            {
                if (anterior == null)
                {
                    cabeza = actual.Siguiente;
                }
                else
                {
                    anterior.Siguiente = actual.Siguiente;
                }
            }
            else
            {
                anterior = actual;
            }
            actual = actual.Siguiente;
        }
    }

    private void MostrarLista()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        int contador = 0;

        Console.WriteLine("Números en la lista:");
        while (actual != null)
        {
            Console.Write($"{actual.Valor,4}");
            contador++;
            
            if (contador % 10 == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
            
            actual = actual.Siguiente;
        }
        
        if (contador % 10 != 0)
        {
            Console.WriteLine();
        }
    }
}