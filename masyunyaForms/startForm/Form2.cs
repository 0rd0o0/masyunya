﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using masyunyaForms;

namespace startForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            masyunyaForms.Program.Main();
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WebMasyunya.MvcApplication.Application_Start();
        }
    }
}
