//Se crea primer interfas con el nombre "IPrestmoLibro"
public interface IPrestamoLibro
{
    // Se define métodos específicos relacionados con el préstamo y devolución de libros
    void PrestarLibro();
    
    void DevolverLibro();
}
//Se crea segunda interfas con el nombre "IPrestmoDVD"
public interface IPrestamoDVD
{ 
    // Se define métodos específicos relacionados con el préstamo y devolución de DVD
    void PrestarDVD();
    void DevolverDVD();
}