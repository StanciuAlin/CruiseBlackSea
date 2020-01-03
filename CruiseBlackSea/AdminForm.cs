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
    public partial class AdminForm : Form
    {
        private Thread _threadUpdateDistance;
        private Thread _threadListCruises;

        private bool _flagEndCreateCruise = false;
        HashSet<int> _harbours = new HashSet<int>();

        public AdminForm(string messageWelcome)
        {
            InitializeComponent();

            // label to show application software version
            toolStripStatusLabelVersion.Text = "Version 1.0";
            toolStripStatusLblDateTime.Alignment = ToolStripItemAlignment.Left;
            toolStripStatusLabelVersion.Alignment = ToolStripItemAlignment.Right;

            // timer to show the local time
            System.Windows.Forms.Timer timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);
            timerDateTime.Enabled = true;

            lblWelcomeCurrentUserForm.Text += messageWelcome;

            pbBlackSea.Enabled = false;
        }   

        #region HarboursButtons
        /*
         * add the desired harbours for cruise
         */
        private void btnConstanta_Click(object sender, EventArgs e)
        {
            _harbours.Add(1);
        }

        private void btnVarna_Click(object sender, EventArgs e)
        {
            _harbours.Add(2);
        }

        private void brnBurgas_Click(object sender, EventArgs e)
        {
            _harbours.Add(3);
        }

        private void btnIstanbul_Click(object sender, EventArgs e)
        {
            _harbours.Add(4);
        }

        private void btnKozlu_Click(object sender, EventArgs e)
        {
            _harbours.Add(5);
        }

        private void btnSamsun_Click(object sender, EventArgs e)
        {
            _harbours.Add(6);
        }

        private void btnBatumi_Click(object sender, EventArgs e)
        {
            _harbours.Add(7);
        }

        private void btnSokhumi_Click(object sender, EventArgs e)
        {
            _harbours.Add(8);
        }

        private void btnSochi_Click(object sender, EventArgs e)
        {
            _harbours.Add(9);

        }

        private void btnAnapa_Click(object sender, EventArgs e)
        {
            _harbours.Add(10);
        }

        private void btnIalta_Click(object sender, EventArgs e)
        {
            _harbours.Add(11);
        }

        private void btnSevastopol_Click(object sender, EventArgs e)
        {
            _harbours.Add(12);
        }

        private void btnOdessa_Click(object sender, EventArgs e)
        {
            _harbours.Add(13);
        }
        #endregion

        #region Cruise Management


        private void btnInitAll_Click(object sender, EventArgs e)
        {
            btnUpdateDistances.Enabled = true;
            btnGenerateCruises.Enabled = true;
            btnListCruises.Enabled = true;
        }


        #region Thread for Update form
        private void btnUpdateDistances_Click(object sender, EventArgs e)
        {
            btnInitAll.Enabled = false;

            //start a new Thread for Update form and a SQL query
            _threadUpdateDistance = new Thread(openUpdateDistanceForm);
            _threadUpdateDistance.SetApartmentState(ApartmentState.STA);
            _threadUpdateDistance.Start();

        }

        private void openUpdateDistanceForm()
        {
            Application.Run(new UpdateDistanceForm());
        }

        #endregion


        private void btnGenerateCruises_Click(object sender, EventArgs e)
        {
            gbxCruisesCurrentUser.Enabled = true;
            // algo to generate random cruises
        }

        private void btnListCruises_Click(object sender, EventArgs e)
        {
            _threadListCruises = new Thread(openListCruisesForm);
            _threadListCruises.SetApartmentState(ApartmentState.STA);
            _threadListCruises.Start();
        }

        private void openListCruisesForm()
        {
            Application.Run(new ListCruisesForm());
        }


        #endregion

        #region Create custom cruises


        private void btnCreateCruiseCurrentUserForm_Click(object sender, EventArgs e)
        {
            pbBlackSea.Enabled = true;
            MessageBox.Show("Please select the _harbours (with red circle on map) for your desired cruise in order from Black Sea map", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //enable all buttons to select a cruise
            EnableAllButtonsForCruise();

            if (!_flagEndCreateCruise)
            {
                pbBlackSea.Click += new EventHandler(pbBlackSea_Click);
            }
        }

        private void btnFinishCruiseCurrentUserForm_Click(object sender, EventArgs e)
        {
            _flagEndCreateCruise = true;
            pbBlackSea.Enabled = false;
        }

        #endregion

        #region Utilities

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(delegate
            {
                toolStripStatusLblDateTime.Text = "Romanian Date && Time format: " + DateTime.Now.ToString();
            }));
        }

        private void EnableAllButtonsForCruise()
        {
            btnAnapa.Enabled = true;
            btnBatumi.Enabled = true;
            btnConstanta.Enabled = true;
            btnIalta.Enabled = true;
            btnIstanbul.Enabled = true;
            btnKozlu.Enabled = true;
            btnOdessa.Enabled = true;
            btnSamsun.Enabled = true;
            btnSevastopol.Enabled = true;
            btnSochi.Enabled = true;
            btnSokhumi.Enabled = true;
            btnVarna.Enabled = true;
            brnBurgas.Enabled = true;
        }

        private void pbBlackSea_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            toolStripStatusLabelCoordinates.Text = "Coordinates X = " + coordinates.X.ToString() + "; Y = " + coordinates.Y.ToString();
        }

        #endregion

    }
}
