using App_clase3.Models;

namespace App_clase3.Repositories
{
    public class EquipoRepositorie
    {
        public List<Equipo> Equipos;
        /*public EquipoRepositorie()
        {
            EquipoRepositorie() = DevuelveListadoEquipos();
        }*/
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                puntaje = 0,
                id = 1,
                nombre = "Liga de Quito",
                partidosJugados = 10,
                partidosGanados = 10,
                partidosEmpatados = 0,
                partidosPerdidos = 0
            };
            equipos.Add(ldu);

            Equipo Barcelona = new Equipo
            {
                puntaje = 0,
                id = 2,
                nombre = "Barcelona",
                partidosJugados = 10,
                partidosGanados = 8,
                partidosEmpatados = 1,
                partidosPerdidos = 1
            };
            calcularPuntaje();
            equipos.Add(Barcelona);
            return equipos;


        }

        /* public Equipo DevuelveEquipoPorID(int id)
        {
            Equipo equipo = new Equipo
            {
                id = 1,
                nombre = "Liga de Quito",
                partidosJugados = 10,
                partidosGanados = 10,
                partidosEmpatados = 0,
                partidosPerdidos = 0
            };
            return equipo;
        } */

        public Equipo DevuelveEquipoPorID(int id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.FirstOrDefault(e => e.id == id);
            return equipo;
        }

        public void calcularPuntaje()
        {
            foreach (var item in Equipos)
            {
                item.puntaje = (item.partidosGanados * 3) + (item.partidosEmpatados * 1);
            }
        }

        public bool ActualizarEquipo(int id, Equipo equipo)
        {
            return true;
        }

    }
}
