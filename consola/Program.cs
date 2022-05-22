using Proyecto__02;
List<Astro> listaAstros = new List<Astro>();
listaAstros.Add(new Astro(2,9,"001","Alejo",Destinos.LaHabana,30,3));
listaAstros.Add(new Astro(1,10,"002","Pedro",Destinos.Cienfuegos,20,1));
listaAstros.Add(new Astro(3,11,"003","Nilo",Destinos.Pinar,25,2));
listaAstros.Add(new Astro(1,1,"004","Toño",Destinos.Granma,15,2));

List<Turismo> listaTurismo = new List<Turismo>();
listaTurismo.Add(new Turismo(11,"005","Juan",Destinos.Santiago,50,3));
listaTurismo.Add(new Turismo(12,"006","Pepe",Destinos.LaHabana,35,2));
listaTurismo.Add(new Turismo(8,"007","Antonio",Destinos.Granma,45,1));
listaTurismo.Add(new Turismo(5,"008","Roberto",Destinos.Cienfuegos,40,3));

List<PasajerosListaOficial> listaOficial = new List<PasajerosListaOficial>();
listaOficial.Add(new PasajerosListaOficial("01",Destinos.Cienfuegos,2));
listaOficial.Add(new PasajerosListaOficial("02",Destinos.LaHabana,1));
listaOficial.Add(new PasajerosListaOficial("03",Destinos.Granma,1));
listaOficial.Add(new PasajerosListaOficial("04",Destinos.LaHabana,3));
listaOficial.Add(new PasajerosListaOficial("05",Destinos.LaHabana,3));
listaOficial.Add(new PasajerosListaOficial("06",Destinos.Granma,2));
listaOficial.Add(new PasajerosListaOficial("07",Destinos.Santiago,1));
listaOficial.Add(new PasajerosListaOficial("08",Destinos.Santiago,1));
listaOficial.Add(new PasajerosListaOficial("09",Destinos.Pinar,2));

List<PasajerosListaEspera> listaEspera = new List<PasajerosListaEspera>();
listaEspera.Add(new PasajerosListaEspera("11",new Destinos[] {Destinos.Cienfuegos,Destinos.LaHabana,Destinos.Granma}));
listaEspera.Add(new PasajerosListaEspera("12",new Destinos[] {Destinos.Pinar,Destinos.LaHabana,Destinos.Granma}));
listaEspera.Add(new PasajerosListaEspera("13",new Destinos[] {Destinos.Pinar,Destinos.Santiago,Destinos.Granma}));
listaEspera.Add(new PasajerosListaEspera("14",new Destinos[] {Destinos.Pinar,Destinos.LaHabana,Destinos.Santiago}));
listaEspera.Add(new PasajerosListaEspera("15",new Destinos[] {Destinos.Pinar,Destinos.LaHabana,Destinos.Santiago}));
listaEspera.Add(new PasajerosListaEspera("16",new Destinos[] {Destinos.Cienfuegos,Destinos.Pinar,Destinos.Santiago}));
listaEspera.Add(new PasajerosListaEspera("17",new Destinos[] {Destinos.Cienfuegos,Destinos.Santiago,Destinos.Granma}));
listaEspera.Add(new PasajerosListaEspera("18",new Destinos[] {Destinos.Cienfuegos,Destinos.LaHabana,Destinos.Santiago}));
listaEspera.Add(new PasajerosListaEspera("19",new Destinos[] {Destinos.Cienfuegos,Destinos.LaHabana,Destinos.Granma}));

