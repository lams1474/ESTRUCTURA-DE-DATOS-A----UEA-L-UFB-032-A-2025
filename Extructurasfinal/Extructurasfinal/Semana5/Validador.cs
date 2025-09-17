public class ProgramaPrincipal
{
    public static void Run()
    {
        System.Console.WriteLine("=== SISTEMA DE GESTIÓN CON MANEJO DE EXCEPCIONES ===");
        System.Console.WriteLine("=== SEMANA 5 - VALIDACIÓN Y MANEJO DE ERRORES ===");
        System.Console.WriteLine("");
        
        try
        {
            SistemaGestionExcepciones.Run();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"ERROR CRÍTICO DEL SISTEMA: {ex.Message}");
            System.Console.WriteLine("Detalles técnicos: " + ex.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("\n=== EJECUCIÓN FINALIZADA ===");
            System.Console.WriteLine("Sistema de gestión cerrado correctamente.");
        }
    }
}