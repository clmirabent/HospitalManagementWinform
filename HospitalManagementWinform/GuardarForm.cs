﻿using System;
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
    public partial class GuardarForm : Form
    {
        public GuardarForm()
        {
            InitializeComponent();
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPagina doctor = new DoctorPagina(nameBox.Text, ageBox.Text, dniBox.Text, specialityBox.Text, numberBox.Text );
        }
    }
}
