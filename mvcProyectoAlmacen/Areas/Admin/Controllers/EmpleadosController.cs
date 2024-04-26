using Microsoft.AspNetCore.Mvc;
using mvcProyectoAlmacen.Data.Repository.IRepository;
using mvcProyectoAlmacen.Models;

namespace mvcProyectoAlmacen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpleadosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public EmpleadosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                //logica para guardar en bd
                _contenedorTrabajo.Empleado.Add(empleado);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));

            }
            return View(empleado);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Empleado empleado = new Empleado();
            empleado = _contenedorTrabajo.Empleado.Get(id);
            if (empleado == null)
            {
                return NotFound();

            }
            return View(empleado);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Empleado empleado)
        {

            if (ModelState.IsValid)
            {
                _contenedorTrabajo.Empleado.Update(empleado);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }
        #region llamadas a la api
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Empleado.GetAll() });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.Empleado.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error borrando empleado" });
            }
            _contenedorTrabajo.Empleado.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Se borro el empleado" });
        }
        #endregion
    }
}
