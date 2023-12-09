using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace Core.Domain
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        //[ForeignKey("PatientID")]
        //public Patient patients { get; set; }
        ////ForeignKey from doctor's table
    
        //[ForeignKey("DoctorID")]
        //public Doctor Doctors { get; set; }

        [Required]
        public DayOfWeek Day { get; set; }

        public DateAndTime DateAndTime { get; set; }

        [ForeignKey("DiscountCodeId")]
        public DiscountCodeCoupoun DiscountCodeCoupoun { get; set; }

        public float Price { get; set; }

    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DayOfWeek
    {
        Saturday,
        Sunday,
        Monday ,
        Tuesday,
        Wednsday,
        Thursday,
        Friday,
    }
}
