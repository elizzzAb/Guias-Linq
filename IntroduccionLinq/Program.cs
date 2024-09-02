// See https://aka.ms/new-console-template for more information
using IntroduccionLinq;

//Console.WriteLine("Hello, World!");

//LinQ
#region ListaModelos
List<Casa> ListaCasas = new List<Casa>();
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion 
//----------------------------------------------------------------
#region listaCasa
ListaCasas.Add(new Casa
{
    Id = 1,
    Direccion = "3 av Norte ArcanCity",
    Ciudad = "Gothan City",
    numeroHabitaciones = 20,
});
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
ListaCasas.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion
//----------------------------------------------------------------
#region ListaHabitante
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Bruno Diaz",
    Edad = 36,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 36,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 36,
    IdCasa = 1
});
#endregion
//----------------------------------------------------------------
#region SentenciasLinQ
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional //indica el inicio de la consulta LinQ
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40  //es una clausula de sección que nos filtra las filas seleccionadas a partir de una condición booleana. 
                                   select ObjetoProvicional;

foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}


//Estructura básica de un 'Join':
//El Join buscara donde las llaves sean iguales,
//al cumplirse la condición inicia la revisión de la clausula where. 

IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad == "Gothan City"
                                         select objetoTemporalHabitante;
Console.WriteLine("----------------------------------------------------------------------------------------------");
foreach (Habitante h in listaCasaGothan)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion
//----------------------------------------------------------------
#region FirsthAndFirsthOrDefault

//Console.WriteLine("----------------------------------------------------------------------------------------------");
//var primeraCasa = ListaCasas.First(); //esto no es linQ es  una fucnin de los Ienumarable
//Console.WriteLine(primeraCasa.dameDatosCasa());

//Habitante personaEdad = (from variableTemporalHabitante
//in ListaHabitantes
//                         where variableTemporalHabitante.Edad > 25
//                         select variableTemporalHabitante).First();
//Console.WriteLine(personaEdad.datosHabitante());

////Mismo pero con Lambda:
//var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad > 25);
//Console.WriteLine(Habitante1.datosHabitante());

//Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
//if (CasaConFirsthOrDedault == null)
//{
//    Console.WriteLine("No existe !No hay!");
//    return;
//}
//Console.WriteLine("existe !Si existe!");
#endregion
//----------------------------------------------------------------
#region Last
Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);
Console.WriteLine(ultimaCasa.dameDatosCasa());
Console.WriteLine("_____________________________________________________");
var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante)
    .LastOrDefault();
if (h1 == null)
{
    Console.WriteLine("Algo fallo");
    return;
}
Console.WriteLine(h1.datosHabitante());
#endregion
//----------------------------------------------------------------




