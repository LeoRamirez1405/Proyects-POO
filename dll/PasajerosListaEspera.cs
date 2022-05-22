namespace Proyecto__02;
public class PasajerosListaEspera:Pasajeros
{
    public Destinos[] Destinos = new Destinos[3];
    public PasajerosListaEspera(string CI,Destinos[] destinos):base(CI)
    {
        this.Destinos = destinos;
    }
}