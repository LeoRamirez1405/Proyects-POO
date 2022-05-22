namespace Proyecto__02;
public class PasajerosListaOficial:Pasajeros
{
    public Destinos Destino{get;}
    public int DiaDeSalida{get;}
    public PasajerosListaOficial(string CI, Destinos Destino, int DiaDeSalida):base(CI)
    {
        this.Destino = Destino;
        this.DiaDeSalida = DiaDeSalida;
    }
}