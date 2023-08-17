using BlogCore.AccesoDatos.Data.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace BlogCore.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        //private readonly ApplicationDbContext _context;

        //public CategoriasController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        public UsuariosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
            //_context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Opción 1: Obtener todos los usuarios
            // return View( _contenedorTrabajo.Usuario.GetAll() );

            // Opción 2: Permite obtener todos los usuarios menos el que esté autenticado.
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            return View(_contenedorTrabajo.Usuario.GetAll( u => u.Id != usuarioActual.Value ));

        }

        [HttpGet]
        public IActionResult Bloquear(string Id) { 
            if(Id == null)
            {
                return NotFound();

            }

            _contenedorTrabajo.Usuario.BloquearUsuario(Id);
            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public IActionResult Desbloquear(string Id)
        {
            if (Id == null)
            {
                return NotFound();

            }

            _contenedorTrabajo.Usuario.DesbloquearUsuario(Id);
            return RedirectToAction(nameof(Index));

        }
    }
}
