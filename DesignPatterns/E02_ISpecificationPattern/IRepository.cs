using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern
{
    //Patrón Repository Genérico
    public interface IRepository<T>
    {
        //retornar la lista de eventos vigentes de acuerdo a la especificacion del rango
        IEnumerable<T> FindByDate(ISpecificationFechaRango<T> spec);

        //busca por nombre 
        IEnumerable<T> FindByName(ISpecificationNombre<T> spec);

        //retornar la lista de eventos que cumplen con el nombre parametro
        IEnumerable<T> FindByDateAndName(ISpecificationFechaRango<Evento>  spec1, ISpecificationNombre<T> spec2);
    }

    public class EventoRepository : IRepository<Evento>
    {
        //Simulación de la BD
        private readonly List<Evento> listaDeEventos;

        public EventoRepository()
        {
            //Datos de ejemplo
            listaDeEventos = new List<Evento>
            {
                new Evento { Nombre="Evento Hija Futuro", fechaInicio = DateTime.Now.AddDays(22), fechaFin = DateTime.Now.AddDays(23) },
                new Evento { Nombre="Cumpleaños Bebé Pasado", fechaInicio=DateTime.Now.AddDays(-10), fechaFin = DateTime.Now.AddDays(-5) },
                new Evento { Nombre="Evento Actual", fechaInicio=DateTime.Now.AddDays(-5), fechaFin = DateTime.Now.AddDays(5)},
                new Evento { Nombre="Ismael Futuro", fechaInicio=DateTime.Now.AddDays(-3), fechaFin = DateTime.Now.AddDays(7)}
            };
        }

        //Busca eventos aun vigentes
        public IEnumerable<Evento> FindByDate(ISpecificationFechaRango<Evento> spec)
        {
            return listaDeEventos.Where(evento => spec.IsValidDate(evento));
        }

        //Busca eventos que concuerden con el nombre
        //public IEnumerable<Evento> FindByName(ISpecificationNombre<Evento> spec)
        //{
        //    return listaDeEventos.Where(evento => spec.IsValidName(evento));
        //}

        //Busca por nombre 
        public IEnumerable<Evento> FindByName(ISpecificationNombre<Evento> spec)
        {
            return listaDeEventos.Where(evento => spec.IsValidName(evento));
        }

        //Busca por vigencia y nombre
        public IEnumerable<Evento> FindByDateAndName(ISpecificationFechaRango<Evento> spec1, ISpecificationNombre<Evento> spec2)
        {
            return listaDeEventos.Where(evento => spec1.IsValidDate(evento)).Where(evento => spec2.IsValidName(evento));
        }

    }
}
