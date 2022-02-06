using Microsoft.AspNetCore.Mvc;
using RepasoClase.Models;
//using NombreProyecto.Models

namespace RepasoClase.Controllers
{
    //Establecer ruta del controlador
    //Acceder a esta clase ,directo del navegador
    [Route("api/[controller]")]
    public class LibrosController : Controller
    {
        //Libro 1
        Libro Libro1;

        //Constructor Controller
        public LibrosController()
        {
            Libro1 = new Libro()
            {
                Nombre = "El Túnel",
                Autor = "Ernesto Sábato",
                NumeroPaginas = 100,
                Editorial = "Pearson"
            };
        }

        public void Index()
        {
            
        }
        [Route("Nombre")]
        public string ObtenerNombre()
        {
            return Libro1.Nombre;
        }
        [Route("Paginas")]
        public int ObtenerNumeroPaginas()
        {
            return CalcularPaginas();
        }
        [Route("Info")]
        public Libro ObtenerInformacionLibro()
        {
            return Libro1;
        }

        private int CalcularPaginas()
        {
            return new Random().Next();
        }
    }
}
