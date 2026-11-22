public class Registro
{
    //Atributos de la clase Registro
    private int id;
    private int canal;
    private string payload;
    private string operacion;

    //Hacemos public por que sera la mausquerramienta misteriosa

    public int Id
    {
        get{return id;}
        set{id = value;}
    }
    public int Canal
    {
        get{return canal;}
        set{canal = value;}
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
    //Constructor Vacio por si acaso
    public Registro() { }
    //Constructor con los parametros
    public Registro(int Id, int Canal , string Payload, string Operacion)
    {
        id = Id;
        canal = Canal;
        payload = Payload;
        operacion = Operacion;
    }
    //Este metodo es para validar si el canal que se va a ingresar es valido
    public bool CanalValido()
    {
        if(canal < 1 || canal > 3)
        {
            return false;
        }
        return true;
    }
}