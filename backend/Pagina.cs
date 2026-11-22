using System.Drawing;

public class Pagina
{
    public int Numero;
    public Imagen? Imagen;
    public string Descripcion;

    public Pagina(){}
    public Pagina(int numero ,Imagen? imagen,string descripcion )
    {
        Numero = numero;
        Imagen = imagen;
        Descripcion = descripcion;
    }
}