namespace Proyecto__02;
public interface IPrecioPasaje
{
    public float PrecioPasaje(float km);
}
public interface ICollection<T>
{
    public T this[int index] {get;set;}
    public int Count { get; }
}

public enum Destinos{
    LaHabana,
    Santiago,
    Pinar,
    Cienfuegos,
    Granma
}