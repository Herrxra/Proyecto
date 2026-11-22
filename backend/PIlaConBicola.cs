namespace MiPrograma;
public class PilaConBicola<T>
{
    //Aqui puse el atributo para usar la bicola como pila
    private Bicola<T> bicola;
    public PilaConBicola()
    {
        bicola = new Bicola<T>();
    }
    public bool Apilar(T valor)
    {
        return bicola.InsertarAlFrente(valor);
    }
    public T? Desapilar()
    {
        return bicola.ExtraerAlFinal();
    }
    public T? VerTope()
    {
        return bicola.Fondo();
    }
    public int Cantidad()
    {
        return bicola.Tamanio();
    }
    public bool EstaVacia()
    {
        return bicola.Vacia();
    }
    public void RecorrerPila()
    {
        bicola.RecorrerInversa();
    }
}