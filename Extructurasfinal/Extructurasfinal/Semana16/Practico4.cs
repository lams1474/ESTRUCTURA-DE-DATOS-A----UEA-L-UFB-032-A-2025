using System;
using System.Collections.Generic;
using System.Diagnostics;

public class CentralidadGrafos
{
    public static void run()
    {
        Console.WriteLine("==== PRACTICO: MÉTRICAS DE CENTRALIDAD ====");
        Stopwatch timer = new Stopwatch();
        timer.Start();

        CentralidadGrafos grafo = new CentralidadGrafos(5);
        grafo.AgregarArista(0, 1);
        grafo.AgregarArista(0, 2);
        grafo.AgregarArista(1, 3);
        grafo.AgregarArista(2, 3);
        grafo.AgregarArista(3, 4);

        grafo.CentralidadGrado();
        grafo.CentralidadCercania();
        grafo.CentralidadIntermediacion();

        timer.Stop();
        Console.WriteLine($"\nTiempo de ejecución: {timer.ElapsedMilliseconds} ms");
    }

    // =====================
    // Atributos
    // =====================
    private Dictionary<int, List<int>> grafo;

    // =====================
    // Constructor
    // =====================
    public CentralidadGrafos(int vertices)
    {
        grafo = new Dictionary<int, List<int>>();
        for (int i = 0; i < vertices; i++)
        {
            grafo[i] = new List<int>();
        }
    }

    // =====================
    // Métodos de lógica
    // =====================
    public void AgregarArista(int origen, int destino)
    {
        grafo[origen].Add(destino);
        grafo[destino].Add(origen); // grafo no dirigido
    }

    // 1. Centralidad de Grado
    public void CentralidadGrado()
    {
        Console.WriteLine("\nCentralidad de Grado:");
        foreach (var nodo in grafo)
        {
            Console.WriteLine($"Nodo {nodo.Key}: {nodo.Value.Count}");
        }
    }

    // 2. Centralidad de Cercanía
    public void CentralidadCercania()
    {
        Console.WriteLine("\nCentralidad de Cercanía:");
        foreach (var nodo in grafo.Keys)
        {
            int sumaDistancias = 0;
            foreach (var destino in grafo.Keys)
            {
                if (nodo != destino)
                    sumaDistancias += DistanciaMinima(nodo, destino);
            }
            double cercania = (double)(grafo.Count - 1) / sumaDistancias;
            Console.WriteLine($"Nodo {nodo}: {cercania:F2}");
        }
    }

    // 3. Centralidad de Intermediación (simplificada)
    public void CentralidadIntermediacion()
    {
        Console.WriteLine("\nCentralidad de Intermediación:");
        foreach (var nodo in grafo.Keys)
        {
            int contador = 0;
            foreach (var origen in grafo.Keys)
            {
                foreach (var destino in grafo.Keys)
                {
                    if (origen != destino && origen != nodo && destino != nodo)
                    {
                        var camino = CaminoMasCorto(origen, destino);
                        if (camino.Contains(nodo))
                            contador++;
                    }
                }
            }
            Console.WriteLine($"Nodo {nodo}: {contador}");
        }
    }

    // Algoritmo BFS para calcular distancia mínima
    private int DistanciaMinima(int inicio, int fin)
    {
        Queue<int> cola = new Queue<int>();
        Dictionary<int, int> distancias = new Dictionary<int, int>();

        foreach (var nodo in grafo.Keys)
            distancias[nodo] = int.MaxValue;

        distancias[inicio] = 0;
        cola.Enqueue(inicio);

        while (cola.Count > 0)
        {
            int actual = cola.Dequeue();
            foreach (var vecino in grafo[actual])
            {
                if (distancias[vecino] == int.MaxValue)
                {
                    distancias[vecino] = distancias[actual] + 1;
                    cola.Enqueue(vecino);
                }
            }
        }

        return distancias[fin];
    }

    // Camino más corto con BFS
    private List<int> CaminoMasCorto(int inicio, int fin)
    {
        Queue<int> cola = new Queue<int>();
        Dictionary<int, int?> anterior = new Dictionary<int, int?>();

        foreach (var nodo in grafo.Keys)
            anterior[nodo] = null;

        cola.Enqueue(inicio);

        while (cola.Count > 0)
        {
            int actual = cola.Dequeue();
            if (actual == fin) break;

            foreach (var vecino in grafo[actual])
            {
                if (anterior[vecino] == null && vecino != inicio)
                {
                    anterior[vecino] = actual;
                    cola.Enqueue(vecino);
                }
            }
        }

        List<int> camino = new List<int>();
        int? nodoActual = fin;
        while (nodoActual != null)
        {
            camino.Insert(0, nodoActual.Value);
            nodoActual = anterior[nodoActual.Value];
        }

        return camino;
    }
}
