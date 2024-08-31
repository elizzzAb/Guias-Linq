// See https://aka.ms/new-console-template for more information
using IntroduccionLinq;

//Console.WriteLine("Hello, World!");

//LinQ
#region ListaModelos
List<Casa> listaCasa = new List<Casa>();
List<Habitante> listaHabitante = new List<Habitante>();
#endregion 

#region Casa
listaCasa.Add(new Casa
{
    Id = 1,
    Direccion = "3 av Norte ArcanCity",
    Ciudad = "Gothan City",
    numeroHabitaciones = 20,
});
listaCasa.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
listaCasa.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion

#region



//#region ListaHabitante
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 1,
//    Nombre = "Bruno Diaz",
//    Edad = 36,
//    IdCasa = 1
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 2,
//    Nombre = "Clark Kent.",
//    Edad = 40,
//    IdCasa = 2
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 3,
//    Nombre = "Peter Parker",
//    Edad = 25,
//    IdCasa = 3
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 3,
//    Nombre = "Tia Mey",
//    Edad = 85,
//    IdCasa = 3
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 2,
//    Nombre = "Luise Lain",
//    Edad = 40,
//    IdCasa = 2
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 1,
//    Nombre = "Selina Kyle",
//    Edad = 30,
//    IdCasa = 1
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 1,
//    Nombre = "Alfred",
//    Edad = 36,
//    IdCasa = 1
//});
//listaHabitante.Add(new Habitante
//{
//    IdHabitante = 1,
//    Nombre = "Nathan Drake",
//    Edad = 36,
//    IdCasa = 1
//});
#endregion

