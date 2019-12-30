using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    public partial class TouristForm : Form
    {
        Thread threadFinalCruise;

        public TouristForm()
        {
            InitializeComponent();

            toolStripStatusLblDateTime.Alignment = ToolStripItemAlignment.Left;

            System.Windows.Forms.Timer timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);
            timerDateTime.Enabled = true;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(delegate
            {
                toolStripStatusLblDateTime.Text = "Romanian Date && Time format: " + DateTime.Now.ToString();
            }));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            //start a new thread in order to show final circuit for cruise
            threadFinalCruise = new Thread(openFinalCruiseTourist);
            threadFinalCruise.SetApartmentState(ApartmentState.STA);
            threadFinalCruise.Start();

            //this.Close();
        }

        private void openFinalCruiseTourist()
        {
            Application.Run(new CruiseForm());

        }
    }
}
