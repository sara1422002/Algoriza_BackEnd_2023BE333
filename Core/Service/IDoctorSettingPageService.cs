using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Service
{
    public interface IDoctorSettingPageService
    {
        Task<Appointment> CreateAppointment(Appointment appointment);
        public Appointment DeleteAppointment(int id);
        public Appointment UpdateAppointment(Appointment updateAppointment);
    }
}
