using HospitalManagementWinform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementWinform
{
    public partial class AppointmentForm: Form
    {
        private Action<Appointment> _onSaveAction;

        public AppointmentForm(Appointment appointment, List<Patient> patientsAvailable, List<Doctor> doctorsAvailable, Action<Appointment> onSaveAction)
        {
            InitializeComponent();
            patientSelector.DataSource = patientsAvailable;
            doctorSelector.DataSource = doctorsAvailable;
            if(appointment != null)
            {
                patientSelector.SelectedItem = appointment.patient.Name;
                 doctorSelector.SelectedItem = appointment.patient.DoctorAssigned;
                dateBox.Value = appointment.Date;
            }
            _onSaveAction = onSaveAction;

        }

     
    }
}
