using App_clase3.Models;

namespace App_clase3.Repositories
{
    public class EquipoRepositorie
    {
        public static List<Equipo> Equipos = new List<Equipo>();
        public EquipoRepositorie()
        {
            if (!Equipos.Any())
            {
                Equipos = DevuelveListadoEquipos().ToList();
            }
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                descripcion = "Campeon de libertadores, sudamericana y recopa",
                id = 1,
                nombre = "Liga de Quito",
                partidosJugados = 10,
                partidosGanados = 10,
                partidosEmpatados = 0,
                partidosPerdidos = 0
            }
            ;
            calcularPuntaje(ldu);
            equipos.Add(ldu);

            Equipo Barcelona = new Equipo
            {

                descripcion = "Idolo del Ecuador",
                id = 2,
                nombre = "Barcelona",
                partidosJugados = 10,
                partidosGanados = 8,
                partidosEmpatados = 1,
                partidosPerdidos = 1
            };
            calcularPuntaje(Barcelona);
            equipos.Add(Barcelona);

            Equipo IndependienteDelValle = new Equipo
            {
                descripcion = "Campeon de la Sudamericana 2019 y 2022",
                id = 3,
                nombre = "Independiente del Valle",
                partidosJugados = 10,
                partidosGanados = 7,
                partidosEmpatados = 2,
                partidosPerdidos = 1
            };
            calcularPuntaje(IndependienteDelValle);
            equipos.Add(IndependienteDelValle);

            Equipo Emelec = new Equipo
            {
                descripcion = "Multicampeon nacional, finalista de Libertadores 1995",
                id = 4,
                nombre = "Emelec",
                partidosJugados = 10,
                partidosGanados = 5,
                partidosEmpatados = 3,
                partidosPerdidos = 2
            };
            calcularPuntaje(Emelec);
            equipos.Add(Emelec);

            Equipo ElNacional = new Equipo
            {
                descripcion = "Equipo de las Fuerzas Armadas, tricampeon",
                id = 5,
                nombre = "El Nacional",
                partidosJugados = 10,
                partidosGanados = 4,
                partidosEmpatados = 4,
                partidosPerdidos = 2
            };
            calcularPuntaje(ElNacional);
            equipos.Add(ElNacional);

            Equipo DeportivoCuenca = new Equipo
            {
                descripcion = "Campeon del 2004",
                id = 6,
                nombre = "Deportivo Cuenca",
                partidosJugados = 10,
                partidosGanados = 3,
                partidosEmpatados = 3,
                partidosPerdidos = 4
            };
            calcularPuntaje(DeportivoCuenca);
            equipos.Add(DeportivoCuenca);

            Equipo Aucas = new Equipo
            {
                descripcion = "Campeon 2022 de liga pro",
                id = 7,
                nombre = "Aucas",
                partidosJugados = 10,
                partidosGanados = 6,
                partidosEmpatados = 1,
                partidosPerdidos = 3
            };
            calcularPuntaje(Aucas);
            equipos.Add(Aucas);

            Equipo UniversidadCatolica = new Equipo
            {
                descripcion = "Equipo capitalino",
                id = 8,
                nombre = "Universidad Catolica",
                partidosJugados = 10,
                partidosGanados = 4,
                partidosEmpatados = 3,
                partidosPerdidos = 3
            };
            calcularPuntaje(UniversidadCatolica);
            equipos.Add(UniversidadCatolica);

            Equipo Orense = new Equipo
            {
                descripcion = "Equipo oriundo de Machala",
                id = 9,
                nombre = "Orense",
                partidosJugados = 10,
                partidosGanados = 2,
                partidosEmpatados = 5,
                partidosPerdidos = 3
            };
            calcularPuntaje(Orense);
            equipos.Add(Orense);

            Equipo Delfin = new Equipo
            {
                descripcion = "Campeon 2019",
                id = 10,
                nombre = "Delfín",
                partidosJugados = 10,
                partidosGanados = 3,
                partidosEmpatados = 2,
                partidosPerdidos = 5
            };
            calcularPuntaje(Delfin);
            equipos.Add(Delfin);

            Equipo TecnicoUniversitario = new Equipo
            {
                descripcion = "Equipo de Ambato",
                id = 11,
                nombre = "Tecnico Universitario",
                partidosJugados = 10,
                partidosGanados = 2,
                partidosEmpatados = 4,
                partidosPerdidos = 4
            };
            calcularPuntaje(TecnicoUniversitario);
            equipos.Add(TecnicoUniversitario);

            Equipo MushucRuna = new Equipo
            {
                descripcion = "Equipo indígena",
                id = 12,
                nombre = "Mushuc Runa",
                partidosJugados = 10,
                partidosGanados = 3,
                partidosEmpatados = 2,
                partidosPerdidos = 5
            };
            calcularPuntaje(MushucRuna);
            equipos.Add(MushucRuna);

            Equipo Imbabura = new Equipo
            {
                descripcion = "Equipo de Ibarra",
                id = 14,
                nombre = "Imbabura",
                partidosJugados = 10,
                partidosGanados = 2,
                partidosEmpatados = 3,
                partidosPerdidos = 5
            };
            calcularPuntaje(Imbabura);
            equipos.Add(Imbabura);
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



        public bool ActualizarEquipo(int id, Equipo equipo)
        {
            var equipoActual = Equipos.FirstOrDefault(e => e.id == id);
            if (equipoActual == null)
            {
                return false;
            }
            equipoActual.nombre = equipo.nombre;
            equipoActual.descripcion = equipo.descripcion;
            equipoActual.partidosJugados = equipo.partidosJugados;
            equipoActual.partidosGanados = equipo.partidosGanados;
            equipoActual.partidosPerdidos = equipo.partidosPerdidos;

            calcularPuntaje(equipoActual);

            return true;
        }

        public int calcularPuntaje(Equipo equipo)
        {

            return (equipo.partidosGanados * 3) + equipo.partidosEmpatados;
        }

    }
}
