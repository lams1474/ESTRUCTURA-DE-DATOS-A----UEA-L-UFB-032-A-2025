public class ValidacionUsuario
{
    public static void Run()
    {
        // Datos del usuario
        int edad = 17;
        bool tieneIdentificacion = true;
        bool esMiembro = false;
        
        // Validaciones con operadores combinados
        bool puedeEntrar = (edad >= 18) && tieneIdentificacion;
        bool accesoEspecial = (edad >= 16) && esMiembro;
        bool accesoTotal = puedeEntrar || accesoEspecial;
        
        // Mostrar resultados
        System.Console.WriteLine("¿Puede entrar normalmente?: " + puedeEntrar);
        System.Console.WriteLine("¿Tiene acceso especial?: " + accesoEspecial);
        System.Console.WriteLine("¿Acceso total permitido?: " + accesoTotal);
    }
}