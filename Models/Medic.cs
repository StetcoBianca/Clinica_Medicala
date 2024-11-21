using System.ComponentModel.DataAnnotations;

namespace Clinica_Medicala.Models
{
    public class Medic
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }

        [Required]
        public string Specializare { get; set; }

        [Phone]
        public string Telefon { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Programare> Programari { get; set; }
    }
}
