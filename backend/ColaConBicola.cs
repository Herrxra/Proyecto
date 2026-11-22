namespace MiPrograma;
public class ColaConBicola<T>
{
    //Aqui usamos la bicola para hacer la cola
    private Bicola<T> bicola;

    public ColaConBicola()
    {
        bicola = new Bicola<T>();
    }
    public bool Encolar(T valor)
    {
        return bicola.InsertarAlFinal(valor);
        
    }
    public T? Desencolar()
    {
        return bicola.ExtraerAlFrente();
    }
    public bool EstaVacia()
    {
        return bicola.Vacia(); 
    }
    public T? VerFrente()
    {
        return bicola.esFrente();
    }
    public int Cantidad()
    {
        return bicola.Tamanio();
    }
    public void RecorrerCola()
    {
        bicola.Recorrer();
    }
}