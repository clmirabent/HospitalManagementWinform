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
    public partial class HospitalPagina : Form
    {
        private Hospital _hospital;

        public HospitalPagina()
        {
            InitializeComponent();
            _hospital = new Hospital();
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
            DoctorPagina form2 = new DoctorPagina(_hospital);
            form2.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            PatientPagina form3 = new PatientPagina();
            form3.Show();
        }

    }
}
