using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement;

namespace HospitalManagementWinform
{
    public partial class HospitalPagina : Form
    {
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }
        public List<AdminStaff> AdminStaffs { get; set; }

        public HospitalPagina()
        {
            InitializeComponent();
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            AdminStaffs = new List<AdminStaff>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
       

        private void label1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPagina form2 = new DoctorPagina();
            form2.Show();
        }
    }
}
