using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App_clase3.Models
{
    public class Equipo
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        public string nombre { get; set; }
        [Range(0, 100)]
        public int partidosJugados { get; set; }
        public int partidosGanados { get; set; }
        public int partidosPerdidos { get; set; }
        public int partidosEmpatados { get; set; }

    }
}
