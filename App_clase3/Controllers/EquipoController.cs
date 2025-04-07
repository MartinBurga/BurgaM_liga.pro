using App_clase3.Models;
using App_clase3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_clase3.Controllers
{
    public class EquipoController : Controller
    {

        public ActionResult List()
        {
            EquipoRepositorie repository = new EquipoRepositorie();
            var equipos = repository.DevuelveListadoEquipos();
            equipos = equipos.OrderBy(item => item.partidosGanados);
            //equipos = equipos.Where(item => item.nombre == "Liga de Quito");
            return View(equipos);

            
        }
    }
}
