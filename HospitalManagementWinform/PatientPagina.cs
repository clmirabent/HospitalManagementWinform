using HospitalManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementWinform
{
    
    public partial class PatientPagina: Form
    {
        private Hospital _hospital;
        private BindingSource _patientsSource = new BindingSource();

        public PatientPagina(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;

            // Patient list bindign setup
            _patientsSource.DataSource = _hospital.Patients;
            patientsList.DataSource = _patientsSource;

            patientsCount.Text = _hospital.Patients.Count.ToString();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            PatientForm form = new PatientForm(null, _hospital.Doctors, patient =>
            {
                _hospital.TryAddPatient((Person)patient, patient.DoctorAssigned, out string error);
                _patientsSource.ResetBindings(false);
           
            });
            form.ShowDialog();
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            Patient selectedPatient = (Patient)patientsList.SelectedItem;
            Doctor doctorAssigned = selectedPatient.DoctorAssigned;

            if (selectedPatient is null)
            {
                return;
            }

            if (!_hospital.TryRemovePatient(selectedPatient, out doctorAssigned, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _patientsSource.ResetBindings(false);
        }

        }
    }
