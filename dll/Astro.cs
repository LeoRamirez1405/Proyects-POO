namespace Proyecto__02;
public class Astro:Omnibus,IPrecioPasaje,ILlega
{
    int DiaDeSalida;
    int HoraDeSalida;
    float precioPasaje;
    public Astro(int DiaDeSalida,int HoraDeSalida,string chapa,string chofer,
                string destino,float km, int asientos):
                base(chapa, chofer,destino,km, asientos)
    {
        this.DiaDeSalida = DiaDeSalida;
        this.HoraDeSalida = HoraDeSalida;
        this.precioPasaje = PrecioPasaje(km);
    }
    public float PrecioPasaje(float km) => km*4;
    
    public void Operaciones(ICollection pasajeros)
    {
        for (int i = 0; i < pasajeros.Count; i++)
        {
            if (this.Asientos == 0) break;
            if(pasajeros[i] == this.Destino)
            {
                this.Asientos--;
            }
        }
    }
}