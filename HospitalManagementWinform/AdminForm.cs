﻿using HospitalManagement;
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
    public partial class AdminForm: Form
    {
        private Action<AdminStaff> _onSaveAction;
        public AdminForm(AdminStaff admin, Action<AdminStaff> onSaveAction)
        {
            InitializeComponent();
            if (admin != null)
            {
                nameBox.Text = admin.Name;
                ageBox.Value = admin.Age;
                dniBox.Text = admin.Dni;
                departmentBox.Text = admin.Departament;
                positionBox.Text = admin.Position;
               
            }
            _onSaveAction = onSaveAction;
        }

        private void saveButton_Click(object sender, EventArgs e)
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

            if (departmentBox.Text == string.Empty)
            {
                departmentBox.Focus();
                departmentErrorProvider.SetError(departmentBox, "This field can't be empty");
                isValidated = false;
            }
            if (positionBox.Text == string.Empty)
            {
                positionBox.Focus();
                positionErrorProvider.SetError(positionBox, "This field can't be empty");
                isValidated = false;
            }
            if (isValidated)
            {
                AdminStaff newAdmin = new AdminStaff(nameBox.Text, (int)ageBox.Value, dniBox.Text, departmentBox.Text, positionBox.Text);
                _onSaveAction(newAdmin);
                MessageBox.Show("Admin " + nameBox.Text + " created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
