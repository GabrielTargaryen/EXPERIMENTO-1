//La clase Libro implementan la interfaz IPrestamoLibro
public class Libro : IPrestamoLibro
{
    //La clase contiene métodos específicos para prestar y devolver el elemento libro.
    public void DevolverLibro()
    {
        Console.WriteLine("Libro Devuelto");
    }

    public void PrestarLibro()
    {
        Console.WriteLine("Libro Prestado");
    }
}
//La clase DVD implementan la interfaz IPrestamoDVD
public class DVD : IPrestamoDVD
{
    //La clase contiene métodos específicos para prestar y devolver el elemento DVD.
    public void DevolverDVD()
    {
        Console.WriteLine("DVD Devuelto");
    }

    public void PrestarDVD()
    {
        Console.WriteLine("DVD Prestado");
    }
}
