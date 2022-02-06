using Microsoft.AspNetCore.Mvc;
using RepasoClase.Models;
using System.Diagnostics;

namespace RepasoClase.Controllers
{
    public class HomeController : Controller
    {
        //Declarar variables
        Persona persona1;
        Persona persona2;
        Persona persona3;
        List<Persona> ListaPersonas;

        //Constructor
        public HomeController(ILogger<HomeController> logger)
        {
            //Inicializar variables/Objetos
            persona1 = new Persona
            {
                Nombre = "Julio",
                DPI = 123456,
                Profesion = "Auditor"
            };
            persona2 = new Persona
            {
                Nombre = "Erika",
                DPI = 98654321,
                Profesion = "Abogado"
            };
            persona3 = new Persona
            {
                Nombre = "Pedro",
                DPI = 45812369,
                Profesion = "QUimico biologo"
            };
            ListaPersonas = new List<Persona>();
            ListaPersonas.Add(persona1);
            ListaPersonas.Add(persona2);
            ListaPersonas.Add(persona3);
        }

        //Metodo principal - Main
        public List<Persona> Index()
        {
            return ListaPersonas;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}