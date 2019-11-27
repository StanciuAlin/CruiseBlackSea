﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CruiseBlackSea
{
    public partial class StartApp : Form
    {
        Thread threadLogin;
        public StartApp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Close();
            threadLogin = new Thread(openLoginForm);
            threadLogin.SetApartmentState(ApartmentState.STA);
            threadLogin.Start();
        }

        private void openLoginForm()
        {
            Application.Run(new Login());
        }
    }
}
