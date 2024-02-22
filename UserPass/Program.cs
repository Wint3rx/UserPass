using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();

            // Intento de autenticación
            AutenticarUsuario(nombreUsuario, contraseña);

            Console.WriteLine("¡Acceso permitido!");
        }
        catch (CredencialesIncorrectasException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }

    static void AutenticarUsuario(string usuario, string contraseña)
    {
        if (usuario != "Frank" || contraseña != "123")
        {
            throw new CredencialesIncorrectasException("Usuario o contraseña incorrectos");
        }
    }
}

class CredencialesIncorrectasException : Exception
{
    public CredencialesIncorrectasException(string message) : base(message)
    {
    }
}

