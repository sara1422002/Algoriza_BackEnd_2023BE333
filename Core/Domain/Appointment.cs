using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey("PatientID")]
        public Patient patients { get; set; }
        //ForeignKey from doctor's table
    
        [ForeignKey("DoctorID")]
        public Doctor Doctors { get; set; }

        [Required]
        public DayOfWeek Day { get; set; }
    }
    public enum DayOfWeek
    {
        Saturday = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednsday = 4,
        Thursday = 5,
        Friday = 6,
    }
}
