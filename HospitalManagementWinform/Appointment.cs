using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementWinform
{
    public class Appointment
    {
       public Patient patient { get; set; }
       public DateTime Date { get; set; }
       public Doctor doctor { get; set; }

        public Appointment (Patient patient, Appointment appointment)
        {
            this.doctor = doctor;
            this.patient = patient;

        }
    }
}