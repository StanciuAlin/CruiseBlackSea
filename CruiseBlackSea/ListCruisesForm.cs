using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    public partial class ListCruisesForm : Form
    {
        public ListCruisesForm()
        {
            InitializeComponent();

            toolStripStatusLblDateTime.Alignment = ToolStripItemAlignment.Left;

            Timer timerDateTime = new Timer();
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

        private void UpdateDistanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerDateTime.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
