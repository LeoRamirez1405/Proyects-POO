namespace Proyecto__02;
public class PasajerosListaEspera:Pasajeros
{
    string[] Destinos = new string[3];
    public PasajerosListaEspera(string CI,string[] destinos):base(CI)
    {
        this.Destinos = destinos;
    }
}