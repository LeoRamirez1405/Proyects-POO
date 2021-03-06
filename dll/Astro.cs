namespace Proyecto__02;
public class Astro:Omnibus,IPrecioPasaje
{
    public int DiaDeSalida{get;}
    public int HoraDeSalida{get;}
    float precioPasaje;
    public Astro(int DiaDeSalida,int HoraDeSalida,string chapa,string chofer,
                Destinos destino,float km, int asientos):
                base(chapa, chofer,destino,km, asientos)
    {
        this.DiaDeSalida = DiaDeSalida;
        this.HoraDeSalida = HoraDeSalida;
        this.precioPasaje = PrecioPasaje(km);
    }
    public float PrecioPasaje(float km) => km*4;
    
    public void Operaciones(ICollection<PasajerosListaOficial> oficial,ICollection<PasajerosListaEspera> espera)
    {
        for (int i = 0; i < oficial.Count; i++)
        {
            if (this.Asientos == 0) break;
            if(oficial[i].Destino == this.Destino)
            {
                this.Asientos--;
                PrecioPasaje(Km);
            }
        }

        if(Asientos>0)
        {
            for (int i = 0; i < espera.Count; i++)
            {
                if (this.Asientos == 0) break;
                if(espera[i].Destinos[0] == Destino ||
                   espera[i].Destinos[1] == Destino ||
                   espera[i].Destinos[2] == Destino)
                   {
                       this.Asientos--;
                   }
            }
        }
    }
}