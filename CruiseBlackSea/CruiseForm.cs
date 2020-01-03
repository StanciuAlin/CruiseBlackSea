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
    public partial class CruiseForm : Form
    {

        // adaug un label cu traseul scris

        public CruiseForm()
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

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawLine(
        //    new Pen(Color.Red, 7f),
        //    new Point(0, 0),
        //    new Point(200, 27));

        //    e.Graphics.DrawLine(
        //    new Pen(Color.Red, 7f),
        //    new Point(200, 27),
        //    new Point(115, 464));

        //    e.Graphics.DrawEllipse(
        //        new Pen(Color.Red, 2f),
        //        0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);
        //}
    }
}
