using Core.Domain;

namespace Algoriza_BE_333.Dto
{
    public class DoctorDto 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int SpecializationID { get; set; }
        public ICollection<Appointment> appointments { get; set; }
    }
}
