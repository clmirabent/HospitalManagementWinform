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
using HospitalManagement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementWinform
{
    public partial class DoctorPagina : Form
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Dni { get; set; }
        public string Specialty { get; set; }
        public string CollegedNumber { get; set; }
        public List<Patient> Patient { get; set; }

        public DoctorPagina(string name, string age, string dni, string specialty, string collegedNumber)
        {
            InitializeComponent();
            Name = name;
            Age = age;
            Dni = dni;
            Specialty = specialty;
            CollegedNumber = collegedNumber;
            Patient = new List<Patient>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            GuardarForm form = new GuardarForm();
            form.ShowDialog();
          


        }
    }
}
