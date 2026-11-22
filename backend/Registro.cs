public class Registro
{
    private int id;
    private int canal;
    private string payload;
    private string operacion;

    public int Id
    {
        get {return id;}
        set {id = value;}
    }
    public int Canal
    {
        get{return canal;}
        set
        {
            canal = value;
        }
    }
    public string Payload
    {
        get{return payload;}
        set{payload = value;}
    }
    public string Operacion
    {
        get{return operacion;}
        set{operacion = value;}
    }
    public Registro() { }
    public Registro(int Id, int Canal , string Payload, string Operacion)
    {
        id = Id;
        canal = Canal;
        payload = Payload;
        operacion = Operacion;
    }
    public bool CanalValido()
    {
        if(canal < 1 || canal > 3)
        {
            return false;
        }
        return true;
    }
}