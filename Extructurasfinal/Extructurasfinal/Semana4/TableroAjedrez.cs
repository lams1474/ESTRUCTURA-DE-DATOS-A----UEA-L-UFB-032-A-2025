public class TableroAjedrez
{
    public static void Run()
    {
        // Crear instancia de tablero de ajedrez estándar (8x8)
        TableroAjedrez tablero = new TableroAjedrez(8, 8);
        
        // Mostrar tablero vacío
        System.Console.WriteLine("=== TABLERO DE AJEDREZ VACÍO ===");
        tablero.MostrarTablero();
        
        // Colocar algunas piezas en el tablero
        tablero.ColocarPieza(0, 0, "Torre");      // Torre en A1
        tablero.ColocarPieza(0, 1, "Caballo");    // Caballo en B1
        tablero.ColocarPieza(0, 2, "Alfil");      // Alfil en C1
        tablero.ColocarPieza(0, 3, "Reina");      // Reina en D1
        tablero.ColocarPieza(0, 4, "Rey");        // Rey en E1
        tablero.ColocarPieza(7, 0, "Torre");      // Torre en A8
        
        // Mostrar tablero con piezas
        System.Console.WriteLine("\n=== TABLERO CON PIEZAS ===");
        tablero.MostrarTablero();
        
        // Mover una pieza en el tablero
        System.Console.WriteLine("\n=== MOVIMIENTO DE PIEZA ===");
        tablero.MoverPieza(0, 1, 2, 2);  // Mueve caballo de B1 a C3
        tablero.MostrarTablero();
    }
    
    private string[,] tablero;  // Matriz para representar el tablero
    private int filas;          // Cantidad de filas del tablero
    private int columnas;       // Cantidad de columnas del tablero
    
    public TableroAjedrez(int numFilas, int numColumnas)
    {
        filas = numFilas;       // Asigna número de filas
        columnas = numColumnas; // Asigna número de columnas
        tablero = new string[filas, columnas];  // Crea matriz del tablero
        
        // Inicializar tablero vacío
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                tablero[i, j] = "---";  // Casilla vacía
            }
        }
    }
    
    public void ColocarPieza(int fila, int columna, string pieza)
    {
        if (fila >= 0 && fila < filas && columna >= 0 && columna < columnas)
        {
            tablero[fila, columna] = pieza.Substring(0, 3);  // Usa primeras 3 letras
        }
    }
    
    public void MoverPieza(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        if (filaOrigen >= 0 && filaOrigen < filas && columnaOrigen >= 0 && columnaOrigen < columnas &&
            filaDestino >= 0 && filaDestino < filas && columnaDestino >= 0 && columnaDestino < columnas)
        {
            string pieza = tablero[filaOrigen, columnaOrigen];  // Guarda pieza
            tablero[filaOrigen, columnaOrigen] = "---";         // Limpia casilla origen
            tablero[filaDestino, columnaDestino] = pieza;       // Coloca en destino
        }
    }
    
    public void MostrarTablero()
    {
        System.Console.Write("   ");  // Espacio para números de columna
        for (int j = 0; j < columnas; j++)
        {
            System.Console.Write(" " + (char)('A' + j) + "  ");  // Letras de columnas
        }
        System.Console.WriteLine();
        
        for (int i = 0; i < filas; i++)
        {
            System.Console.Write((8 - i) + " ");  // Números de fila
            for (int j = 0; j < columnas; j++)
            {
                System.Console.Write(tablero[i, j] + " ");  // Contenido de casilla
            }
            System.Console.WriteLine();
        }
    }
}