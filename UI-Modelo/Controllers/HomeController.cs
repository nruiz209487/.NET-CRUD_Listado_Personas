using CRUD_Personas.VM;
using ENT_Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CRUD_Personas.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            List<ClsPersona> listado;
            try
            {
                listado = ClsPersonaVM.ObtenerListadoPersonas();
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Error));
            }
            return View(listado);
        }
        public ActionResult Error() { 
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            int idpersona = id;
            ClsPersonaVM objVm = new ClsPersonaVM();
            ClsPersona obj = objVm.SelecionarPersona(id);
            return View("Details", obj);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClsPersonaVM model)
        {
            ClsPersonaVM obj = new ClsPersonaVM();
            try
            {
                obj.Id = model.Id;
                obj.Nombre = model.Nombre;
                obj.Apellido = model.Apellido;
                obj.fechaNac = model.fechaNac;
                obj.fechaNac = model.fechaNac;
                obj.direccion = model.direccion;
                obj.telefono = model.telefono;
                obj.AnyadirPersona(obj.Id, obj.Nombre, obj.Apellido, obj.fechaNac, model.direccion, obj.telefono);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            ClsPersonaVM obj = new ClsPersonaVM();
            ClsPersona objVM = obj.SelecionarPersona(id);
                obj.Id = objVM.id;
                obj.Nombre = objVM.nombre;
                obj.Apellido = objVM.apellidos;
                obj.fechaNac = objVM.fechaNac;
                obj.direccion = objVM.direccion;
                obj.telefono = objVM.telefono;
                return View(obj);
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClsPersonaVM model)
        {
            ClsPersonaVM obj = new ClsPersonaVM();
            try
            {
                obj.Id = model.Id;
                obj.Nombre = model.Nombre;
                obj.Apellido = model.Apellido;
                obj.fechaNac = model.fechaNac;
                obj.direccion = model.direccion;
                obj.telefono = model.telefono;
                obj.EditarPersona(id, obj.Nombre, obj.Apellido, obj.fechaNac, model.direccion, obj.telefono);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            ClsPersonaVM vm = new ClsPersonaVM();
            ClsPersona obj = vm.SelecionarPersona(id);
            return View(obj);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClsPersonaVM model)
        {
            ClsPersonaVM vm = new ClsPersonaVM();
            try
            {
                vm.EliminarPersona(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
