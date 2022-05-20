namespace Proyecto__02;

public class Turismo:Omnibus,IPrecioPasaje
{
    int HoraDeLlegada;
    float precioPasaje;
    public Turismo(int HoraDeLlegada,string chapa,string chofer,
                string destino,float km, int asientos):
                base(chapa, chofer,destino,km, asientos)
    {
        this.HoraDeLlegada = HoraDeLlegada;
        this.precioPasaje = PrecioPasaje(km);
    }

    public float PrecioPasaje(float km)
    {
        if(km<=100.0f) return 10;
        if(km>100.0f && km<=200.0f) return 20;
        return 30.0f;
    }
}