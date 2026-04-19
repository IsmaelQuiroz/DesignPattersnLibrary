// See https://aka.ms/new-console-template for more information

using DesignPatterns.E01_RepositoryPattern;
using DesignPatterns.E02_ISpecificationPattern;
using DesignPatterns.E02_ISpecificationPattern.DemoE02;
using DesignPatterns.E03_ISpecificationPattern.Demo;
using System.Linq;

//Execution of exercises
/*----E03 Specification Pattern: Validación de Reglas de Negocion----------------------*/ 

DemoSpecification.Run();


/*--- E02 uso de la implementación del patron repository con Specification */

DemoISpecification.correr();


/*--------------Excercise01_PatronRepository - Implementation par avalidar fecha en rango de fechas */

ISpecification<DateTime> validador = new ValidaFechaSpecification();
DateTime fechaActual = DateTime.Now;

bool isvalid = validador.IsValidaFecha(fechaActual);

Console.WriteLine($"\nFecha a Evaluar: {fechaActual}");
Console.WriteLine($"Rango: 2001-01-01 hasta < 2026-05-01");
Console.WriteLine($"¿Es válida? {isvalid}");
