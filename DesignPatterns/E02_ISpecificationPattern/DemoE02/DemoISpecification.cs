using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern.DemoE02
{
    public class DemoISpecification
    {
        public static void correr()
        {
            /*--- E02 uso de la implementacin del patron repository con Specification
            Instanciar repositorio*/
            //IRepository<Evento> repo = new EventoRepository();

            //var repo = new EventoRepository();
            EventoRepository repo = new();

            //Definir la especificación (evaluar si hoy está en el rango)
            //var specRango = new FechaRangoSpecification(DateTime.Now);
            FechaRangoSpecification specRango = new FechaRangoSpecification(DateTime.Now);
            //var specNombre = new SpecificationNombre("Evento");
            SpecificationNombre specNombre = new SpecificationNombre("Evento");

            //Ejecutar Consultas
            //var eventosVigentes = repo.FindByDate(specRango).Where(x => specNombre.IsValidName(x));

            IEnumerable<Evento> eventosVigentes = repo.FindByDate(specRango); //Evento Actual
            IEnumerable<Evento> eventosByNombre = repo.FindByName(specNombre); //Evento Actual, Evento Ismael Futuro
            IEnumerable<Evento> eventosVigentesByNombre = repo.FindByDateAndName(specRango, specNombre);//Evento Ismael Futuro


            Console.WriteLine("\nEventos Vigentes:");
            printFilteredEvents(eventosVigentes);

            //foreach (var e in eventosVigentes)
            //{
            //    Console.WriteLine($"\nEventos Vigentes:");
            //}

            Console.WriteLine("\nEventos por Nombre:");
            printFilteredEvents(eventosByNombre);

            //foreach (var e in eventosByNombre)
            //{
            //    Console.WriteLine($"Eventos por Nombre: {e.Nombre}");
            //}


            Console.WriteLine("\nEventos vigentes y por Nombre:");
            printFilteredEvents(eventosVigentesByNombre);
            //foreach (var e in eventosVigentesByNombre)
            //{
            //    Console.WriteLine($"Eventos vigentes y por Nombre: {e.Nombre}");
            //}
        }

        public static void printFilteredEvents(IEnumerable<Evento> filteredEvents)
        {
            foreach (Evento evento in filteredEvents)
            {
                Console.WriteLine($"{evento.Nombre}");
            }
        }
            
            


    }
}
