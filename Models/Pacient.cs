using System.ComponentModel.DataAnnotations;

namespace Clinica_Medicala.Models
{
    public class Pacient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNasterii { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string CNP { get; set; }

        public string Adresa { get; set; }

        [Phone]
        public string Telefon { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Programare> Programari { get; set; }
    }
}
