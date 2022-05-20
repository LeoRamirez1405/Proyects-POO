namespace Proyecto__02;

public interface IPrecioPasaje
{
    float PrecioPasaje(float km);
}
public interface ILlega
{
    void Operaciones(ICollection pasajeros);
}

interface ICollection
{
    public object this[int index] {get;set;}
    int Count { get; }
}

public abstract class Omnibus
{
    protected string Chapa;
    protected string Chofer;
    protected string Destino;
    protected float Km;
    protected float Asientos;

    public Omnibus(string chapa,string chofer, string destino, float km, int asientos)
    {
        this.Chapa = chapa;
        this.Chofer = chofer;
        this.Destino = destino;
        this.Km = km;
        this.Asientos = asientos;
    }
}