namespace Proyecto__02;
public class PasajerosListaOficial:Pasajeros
{
    string Destino;
    int DiaDeSalida;
    public PasajerosListaOficial(string CI, string Destino, int DiaDeSalida):base(CI)
    {
        this.Destino = Destino;
        this.DiaDeSalida = DiaDeSalida;
    }
}