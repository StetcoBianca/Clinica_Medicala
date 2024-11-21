using System.ComponentModel.DataAnnotations;

namespace Clinica_Medicala.Models
{
    public class Programare
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataProgramare { get; set; }

        [Required]
        public TimeSpan OraProgramare { get; set; }

        public string Observatii { get; set; }

        public int PacientId { get; set; }
        public Pacient Pacient { get; set; }

        public int MedicId { get; set; }
        public Medic Medic { get; set; }
    }
}
