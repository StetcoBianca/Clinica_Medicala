using System.ComponentModel.DataAnnotations;

namespace Clinica_Medicala.Models
{
    public class ServiciuMedical
    {
        public int Id { get; set; }

        [Required]
        public string Denumire { get; set; }

        public string Descriere { get; set; }

        [Required]
        public decimal Pret { get; set; }
    }
}
