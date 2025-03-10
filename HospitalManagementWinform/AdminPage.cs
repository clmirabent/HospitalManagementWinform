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

        }
    }
}
