using Biblioteca.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers 
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController: ControllerBase
    {
        [HttpGet]

        public ActionResult<List<Entidades.Libro>> Get()
        {
            return new List<Libro>()
            {
                new Libro() { Id_libro=1,Nombre_libro="Gone girl"},
                new Libro() {Id_libro=2, Nombre_libro="Cazadores de sonbras"}





            };
        }




    }
}
