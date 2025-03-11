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
    public partial class AdminPage: Form
    {
        private Hospital _hospital;
        private BindingSource _adminSource = new BindingSource();
        public AdminPage(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;

            // Admin staff list bindign setup
            _adminSource.DataSource = _hospital.AdminStaffs;
            adminList.DataSource = _adminSource;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm(null, admin =>
            {
                _hospital.AddAdmin_staff(admin);
               
                _adminSource.ResetBindings(false);

            });
            form.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AdminStaff selectedAdmin = (AdminStaff)adminList.SelectedItem;

            if (selectedAdmin is null)
            {
                return;
            }

            AdminForm form = new AdminForm(selectedAdmin, admin =>
            {
                if (!_hospital.TryModifyAdmin(selectedAdmin.Dni, admin, out AdminStaff modifiedAdmin, out string error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _adminSource.ResetBindings(false);
            });

            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            AdminStaff selectedAdmin = (AdminStaff)adminList.SelectedItem;
            if (selectedAdmin is null)
            {
                return;
            }


            if (!_hospital.TryRemoveAdmin(selectedAdmin.Dni, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _adminSource.ResetBindings(false);
        }
    }
    }
    
 

