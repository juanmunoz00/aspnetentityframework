using BlogCore.AccesoDatos.Data.Repository.IRepository;
using BlogCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticulosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public ArticulosController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Llamadas a la API

        [HttpGet]
        public IActionResult GetAll()
        {
            //Opcion 1
            return Json(new { data = _contenedorTrabajo.Articulo.GetAll() });
        }

        /*
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.Categoria.Get(id);

            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error borrando categoría" });
            }

            _contenedorTrabajo.Categoria.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Categoría borrada exitosamente" });



        }
        */
        #endregion

    }
}
