namespace Proyecto__02;
public abstract class Omnibus
{
    public Destinos Destino{get;}
    public string Chapa{get;}
    public string Chofer{get;}
    public float Km{get;}
    public float Asientos;

    public Omnibus(string chapa,string chofer, Destinos destino, float km, int asientos)
    {
        this.Chapa = chapa;
        this.Chofer = chofer;
        this.Destino = destino;
        this.Km = km;
        this.Asientos = asientos;
    }
}