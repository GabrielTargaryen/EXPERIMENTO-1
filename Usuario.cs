//La clase Usuario implementa ambas interfaces (IPrestamoLibro e IPrestamoDVD).
public class Usuario : IPrestamoLibro, IPrestamoDVD
{
    //Contiene métodos específicos para prestar y devolver libros
    public void DevolverLibro()
    {
      Console.WriteLine("Libro Devuelto");
    }

    public void PrestarLibro()
    {
        Console.WriteLine("Libro Prestado");
    }
    //Contiene métodos específicos para prestar y devolver DVDs.
    public void PrestarDVD()
    {
        Console.WriteLine("DVD Prestado");
    }

    public void DevolverDVD()
    {
        Console.WriteLine("DVD Devuelto");
    }
}
