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

           
            Func<Video, bool> condition = x => x.Nombre.Contains("m"); // == "matrix";
            Func<Video, string> selector = (video) => "Pelicula:" + video.Nombre;


            IEnumerable<Video> videosFiltered = videos.Where(condition);  //videos.Where(x => x.Nombre == "matrix").Select(selector);
            IEnumerable<string> videosTitulosFiltrados = videosFiltered.Select(selector);

            foreach(string titulos in videosTitulosFiltrados)
            {
                Console.WriteLine(titulos);
            }
        }
    }
}
