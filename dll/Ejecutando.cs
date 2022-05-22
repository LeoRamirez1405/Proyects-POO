namespace Proyecto__02;

public class Ejecuta
{
    ICollection<Astro>? listaAstros;
    ICollection<Turismo>? listaTurismo;
    ICollection<PasajerosListaEspera>? listaEspera;
    ICollection<PasajerosListaOficial>? listaOficial;
    public Ejecuta(ICollection<Astro> listaAstros,ICollection<Turismo> listaTurismo,
                   ICollection<PasajerosListaEspera> listaEspera,
                   ICollection<PasajerosListaOficial> listaOficial)
    {
        this.listaAstros = listaAstros;
        this.listaTurismo = listaTurismo;
        this.listaEspera = listaEspera;
        this.listaOficial = listaOficial;
        OrdenandoPorDiaYHora();
    }

    void OrdenandoPorDiaYHora()
    {
        for (int i = 0; i < this.listaAstros?.Count; i++)
        {
            for (int j = i+1; j < listaAstros.Count-1; j++)
            {
                if(listaAstros[i].DiaDeSalida > listaAstros[j].DiaDeSalida ||
                  (listaAstros[i].HoraDeSalida > listaAstros[j].HoraDeSalida && 
                  listaAstros[i].DiaDeSalida == listaAstros[j].DiaDeSalida))
                {
                    var aux = listaAstros[i];
                    listaAstros[i] = listaAstros[j];
                    listaAstros[j] = aux;
                }
            }
        }
        for (int i = 0; i < listaTurismo?.Count; i++)
        {
            for (int j = i+1; j < listaTurismo.Count-1; j++)
            {
                if(listaTurismo[i].HoraDeLlegada > listaTurismo[j].HoraDeLlegada)
                {
                    var aux = listaTurismo[i];
                    listaTurismo[i] = listaTurismo[j];
                    listaTurismo[j] = aux;
                }
            }
        }
    }
    
    

}