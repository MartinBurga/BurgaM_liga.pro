using App_clase3.Models;
using App_clase3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_clase3.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepositorie _repository;
        public EquipoController()
        {
            _re = new EquipoRepositorie();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            equipos = equipos.OrderBy(item => item.partidosGanados);
            //equipos = equipos.Where(item => item.nombre == "Liga de Quito");
            return View(equipos);


        }
        public ActionResult Create()
        {
            return View();
        }

        /*public ActionResult Edit(int id)
        {
            Equipo ldu = new Equipo
            {
                id = 1,
                nombre = "Liga de Quito",
                partidosGanados = 3,
                partidosPerdidos = 2,
                partidosEmpatados = 5,
                partidosJugados = 9
            };
            return View(ldu);
        }
        */

        //Funcion que ayuda a devolver el equipo por ID//

        public ActionResult Edit(int id)
        {
            var equipo = _repository.DevuelveEquipoPorID(id);
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int id, Equipo equipo)
        {
            //Proceso de guardar la informacion
            try
            {
                EquipoRepositorie repository = new EquipoRepositorie();
                repository.ActualizarEquipo(id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }


    }
}
