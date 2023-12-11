class Program
{
    //En el método Main, se crea una instancia de Usuario.
    static void Main()
    {
        // Ejemplo de uso
        Usuario usuario = new Usuario();

        // Operaciones con libros
        usuario.PrestarLibro();
        usuario.DevolverLibro();

        // Operaciones con DVDs
        usuario.PrestarDVD();
        usuario.DevolverDVD();
    }
}