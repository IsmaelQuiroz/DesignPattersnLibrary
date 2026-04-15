// See https://aka.ms/new-console-template for more information

//Execution of exercises

//Excercise01_PatronRepository - Implementation par avalidar fecha en rango de fechas
using DesignPatterns.Exercise01_PatronRepository;

ISpecification<DateTime> validador = new ValidaFechaSpecification();
DateTime fechaActual = DateTime.Now;

bool isvalid = validador.IsValidaFecha(fechaActual);

Console.WriteLine($"Fecha a Evaluar: {fechaActual}");
Console.WriteLine($"Rango: 2001-01-01 hasta < 2026-05-01");
Console.WriteLine($"¿Es válida? {isvalid}");
