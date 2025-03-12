using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HospitalManagement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementWinform
{
    public partial class HospitalPage : Form
    {
        private Hospital _hospital;

        public HospitalPage()
        {
            InitializeComponent();
            _hospital = new Hospital();
            _hospital.AddDoctor(new Doctor($"Julio", 61, "DNI: 123456789T", "Specialty: Pediatria", "44356765"));
            _hospital.AddDoctor(new Doctor($"Name: Marta", 38, "DNI: 987654321U", "Speciality: Terapia", "College Number: 0556795"));
            _hospital.AddDoctor(new Doctor($"Name: Eduardo", 55, "DNI: 086660987U", "Speciality: Traumatologia", "College Number: 0556795"));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  

 

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPage form2 = new DoctorPage(_hospital);
            form2.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            PatientPage form3 = new PatientPage(_hospital);
            form3.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminPage form4 = new AdminPage(_hospital);
            form4.Show();
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentPage form5 = new AppointmentPage(_hospital);
            form5.Show();
        }
    }
}
