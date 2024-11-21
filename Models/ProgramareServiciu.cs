namespace Clinica_Medicala.Models
{
    public class ProgramareServiciu
    {
        public int ProgramareId { get; set; }
        public Programare Programare { get; set; }

        public int ServiciuMedicalId { get; set; }
        public ServiciuMedical ServiciuMedical { get; set; }
    }
}
