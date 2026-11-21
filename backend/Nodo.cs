

namespace MiPrograma;

class Nodo<T>
{
    public T Dato;
    public Nodo<T>? Sig;
    public Nodo<T>? Ant;
    public Nodo (T dato)
    {
        Dato = dato;
        Sig = null;
        Ant = null;
    }
}