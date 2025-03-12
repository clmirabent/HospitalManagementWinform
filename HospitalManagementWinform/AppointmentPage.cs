using HospitalManagement;
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
    public partial class AppointmentPage: Form
    {
        private Hospital _hospital;
        private BindingSource _appointmentSource = new BindingSource();

        public AppointmentPage(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;

            // Appointment list bindign setup
            _appointmentSource.DataSource = _hospital.GetAppointments();
            appointmentList.DataSource = _appointmentSource;
        }

        private void addButtonAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm form = new AppointmentForm(null, _hospital.Patients, _hospital.Doctors, appointment =>
            {
                _hospital.TryAddAppointment(appointment.Patient, appointment);
                _appointmentSource.ResetBindings(false);
            });
            form.ShowDialog();
        }
    }
}
