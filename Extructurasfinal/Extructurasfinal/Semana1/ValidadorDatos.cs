public class ValidadorDatos
{
    public static void run()
    {
        // datos de ejemplos para validar 
        string nombre = "Lams1474";
        int edad = 51;
        double precio = -50.75;
        char codigo = 'L';
        bool esValido = false;

        // validacion complejas
        bool nombreValido = ValidarNombre(nombre);
        bool edadValida = ValidarEdad(edad);
        bool precioValido = ValidarPrecio(precio);
        bool codigoValido = ValidarCodigo(codigo);

        // validacion final )operacion logica compuesta)
        esValido = nombreValido && edadValida && precioValido && codigoValido;

        // mostrar reporte de validacion
        System.Console.WriteLine("==== REPORTE DE VALIDACION ====");
        System.Console.WriteLine("Nombre valido: " + nombreValido);
        System.Console.WriteLine("Edad valida: " + edadValida);
        System.Console.WriteLine("Precio valido: " + precioValido);
        System.Console.WriteLine("Codigo Valido: " + codigoValido);
        System.Console.WriteLine("=== VALIDACION GENERAL: " + esValido + " ===");

    }
    // METODO DE VALIDACION 
    private static bool ValidarNombre(string nombre)
    {

        // verifica que el nombre solo contenga letras
        foreach (char c in nombre)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }

    private static bool ValidarEdad(int edad)
    {
        // verifa que la edad este entre 18 y 65
        return edad >= 18 && edad <= 65;
    }

    private static bool ValidarPrecio(double precio)
    {
        // verifica que el precio sea positivo
        return precio > 0;
    }

    private static bool ValidarCodigo(char codigo)
    {

        // verifica que el codigo sea A, B o C
        return codigo == 'A' || codigo == 'B' || codigo == 'C';
    }
}
