using HospitalManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementWinform
{
    public partial class GuardarForm : Form
    {
        private Action<Doctor> _addDoctorToHospital;

        public GuardarForm(Action<Doctor> addDoctorToHospital)
        {
            InitializeComponent();
            _addDoctorToHospital = addDoctorToHospital;
        }

        private void onSaveDoctor(object sender, EventArgs args)
        {
            bool isValidated = true;
            Regex dniRegex = new Regex(@"^[0-9]{8}\d[A-Z]$");

            if (nameBox.Text == string.Empty)
            {
                nameBox.Focus();
                nameErrorProvider.SetError(nameBox, "Provide a name");
                isValidated = false;
            }
         
            if ((int)ageBox.Value > 120 && ageBox.Value < 0)
            {
                ageBox.Focus();
                ageErrorProvider.SetError(ageBox, "Age between 0 and 100");
                isValidated = false;
            }

            if (!(dniRegex.IsMatch(dniBox.Text)))
            {
                dniBox.Focus();
                dniErrorProvider.SetError(dniBox, "Enter a valid DNI");
                isValidated = false;
            }
            if (numberBox.Text == string.Empty)
            {
                numberBox.Focus();
                collegeNumberErrorProvider.SetError(numberBox, "This field can't be empty");
                isValidated = false;
            }
            if (specialityBox.Text == string.Empty)
            {
                specialityBox.Focus();
                specialityErrorProvider.SetError(specialityBox, "This field can't be empty");
                isValidated = false;
            }
            if (isValidated)
            {
                Doctor newDoctor = new Doctor(nameBox.Text, (int)ageBox.Value, dniBox.Text, specialityBox.Text, numberBox.Text);
                _addDoctorToHospital(newDoctor);
                MessageBox.Show("Doctor " + nameBox.Text + " created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                Close();
            }
         
        }
    }
}
