using Core.Domain;
using Microsoft.VisualBasic;
namespace Algoriza_BE_333.Dto
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public DayOfWeek Day { get; set; }
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

}
