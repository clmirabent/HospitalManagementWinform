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
    public partial class DoctorPagina : Form
    {
        private Hospital _hospital;
        private BindingSource _doctorsSource = new BindingSource();

        public DoctorPagina(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;

            // Doctor list bindign setup
            _doctorsSource.DataSource = _hospital.Doctors;
            doctorList.DataSource = _doctorsSource;

            doctorsCount.Text = _hospital.Doctors.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarForm form = new GuardarForm(addDoctorToHospitalAndUpdateList);
            form.ShowDialog();
        }

        private void onSelectDoctorIndex(object sender, EventArgs e)
        {

        }

        private void addDoctorToHospitalAndUpdateList(Doctor doctor)
        {
            _hospital.AddDoctor(doctor);
            _doctorsSource.ResetBindings(false);

            doctorsCount.Text = _hospital.Doctors.Count.ToString();
        }
    }
}
