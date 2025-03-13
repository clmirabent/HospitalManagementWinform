using HospitalManagementWinform;
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
    public partial class DoctorPage : Form
    {
        private Hospital _hospital;
        private BindingSource _doctorsSource = new BindingSource();

        public DoctorPage(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;

            // Doctor list bindign setup
            _doctorsSource.DataSource = _hospital.Doctors;
            doctorList.DataSource = _doctorsSource;

            doctorsCount.Text = _hospital.Doctors.Count.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Doctor selectedDoctor = (Doctor)doctorList.SelectedItem;
            if(selectedDoctor is null)
            {
                return;
            }

            
            if(!_hospital.TryRemoveDoctor(selectedDoctor.Dni, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _doctorsSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorForm form = new DoctorForm(null, doctor =>
            {
                _hospital.AddDoctor(doctor);
                _doctorsSource.ResetBindings(false);

                doctorsCount.Text = _hospital.Doctors.Count.ToString();
            });
            form.ShowDialog();
        }

        private void onEditDoctor_click(object sender, EventArgs args)
        {
            Doctor selectedDoctor = (Doctor)doctorList.SelectedItem;

            if (selectedDoctor is null)
            {
                return;
            }

            DoctorForm form = new DoctorForm(selectedDoctor, doctor =>
            {
                if(!_hospital.TryModifyDoctor(selectedDoctor.Dni, doctor, out Doctor modifiedDoctor, out string error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _doctorsSource.ResetBindings(false);
            });

            form.ShowDialog();
        }               
    }
}
