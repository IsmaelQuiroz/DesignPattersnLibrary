// See https://aka.ms/new-console-template for more information

//Execution of exercises

/*--------------Excercise01_PatronRepository - Implementation par avalidar fecha en rango de fechas */
using DesignPatterns.E01_RepositoryPattern;
using DesignPatterns.E02_ISpecificationPattern;
using System.Linq;

ISpecification<DateTime> validador = new ValidaFechaSpecification();
DateTime fechaActual = DateTime.Now;

bool isvalid = validador.IsValidaFecha(fechaActual);

Console.WriteLine($"Fecha a Evaluar: {fechaActual}");
Console.WriteLine($"Rango: 2001-01-01 hasta < 2026-05-01");
Console.WriteLine($"¿Es válida? {isvalid}");


/*------------- E02 uso de la implementación del patron repository con Specification
 
Instanciar repositorio*/
//IRepository<Evento> repo = new EventoRepository();
var repo = new EventoRepository();

//Definir la especificación (evaluar si hoy está en el rango)
var specRango = new FechaRangoSpecification(DateTime.Now);
var specNombre = new SpecificationNombre("Evento");


//Ejecutar Consultas
//var eventosVigentes = repo.FindByDate(specRango).Where(x => specNombre.IsValidName(x));

var eventosVigentes = repo.FindByDate(specRango); //Evento Actual
var eventosByNombre = repo.FindByName(specNombre); //Evento Actual, Evento Ismael Futuro
var eventosVigentesByNombre = repo.FindByDateAndName(specRango, specNombre);//Evento Ismael Futuro


foreach (var e in eventosVigentes)
{
    Console.WriteLine($"Eventos Vigentes: {e.Nombre}");
}

foreach (var e in eventosByNombre)
{
    Console.WriteLine($"Eventos por Nombre: {e.Nombre}");
}

foreach (var e in eventosVigentesByNombre)
{
    Console.WriteLine($"Eventos vigentes y por Nombre: {e.Nombre}");
}


