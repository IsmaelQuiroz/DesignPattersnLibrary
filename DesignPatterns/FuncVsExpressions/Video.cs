using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FuncVsExpressions
{
    public class Video
    {
        public string Nombre { get; set; }
       
        public static void funcT()
        {
            var videos = new List<Video>
            {
                new Video { Nombre ="matrix"},
                new Video { Nombre = "mad max"},
                new Video { Nombre = "avatar"}
            };

            Func<Video, string> selector = (video) => "Pelicula:" + video.Nombre;

            IEnumerable<string> videoTitulos = videos.Select(selector);
            foreach(string titulos in videoTitulos)
            {
                Console.WriteLine(titulos);
            }
        }
    }
}
