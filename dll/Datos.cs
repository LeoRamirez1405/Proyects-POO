namespace Proyecto__02;

public class Datos
{
    public int Dia{get;}
    public Dictionary<string,Omnibus> listaPasajeros_omnibus = new Dictionary<string, Omnibus>();
    public float DineroRecaudado;
    public List<Omnibus> OmnibusEnElDia = new List<Omnibus>();
    Dictionary<Destinos,int> destinoFrecuencia;
    public Destinos DestinoMasFrecuente{get;}
    
    public Datos(int dia,ICollection<Destinos> destinos)
    {
        this.Dia = dia;
        destinoFrecuencia = CreandoDic(destinos);
    }
    public void CalculaDestino(Destinos destino)
    {
        destinoFrecuencia[destino] ++;
    }
    public Dictionary<Destinos,int> CreandoDic(ICollection<Destinos> destinos)
    {
        Dictionary<Destinos,int> result = new Dictionary<Destinos, int>();
        for (int i = 0; i < destinos.Count; i++)
        {
            result.Add(destinos[i],1);
        }
        return result;
    }
    public Destinos CalculaMasFrecuente(Dictionary<Destinos,int> destinosFrec)
    {
        return destinosFrec.OrderByDescending(x => x.Value).FirstOrDefault().Key;
    }
    static string OmnibusTo(Destinos destinos,ICollection<Omnibus> omnibus)
    {
        string result = "";
        for (int i = 0; i < omnibus.Count; i++)
        {
            if(omnibus[i].Destino == destinos)
            result+=  "Ïnformación del Omnibus:\n"+
                        "Chapa: "+omnibus[i].Chapa +"\n"+
                        "Chofer: "+omnibus[i].Chofer+"\n"+
                      "Kilometros:"+omnibus[i].Km+"\n"+
                      "Asientos: "+omnibus[i].Asientos +" \n\n";   
        }
        return result;
    }
    static string OmnibusOut(ICollection<Astro> astro,ICollection<Turismo> turismo)
    {
        return $"Astro: {astro.Count} Turismo: {turismo.Count}";
    }
}