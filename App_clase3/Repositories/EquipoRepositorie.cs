using App_clase3.Models;

namespace App_clase3.Repositories
{
    public class EquipoRepositorie
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
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
                id = 2,
                nombre = "Barcelona",
                partidosJugados = 10,
                partidosGanados = 8,
                partidosEmpatados = 1,
                partidosPerdidos = 1///gola munod
            };
            equipos.Add(Barcelona);
            return equipos;


        }
    }
}
