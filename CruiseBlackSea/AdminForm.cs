using Combinatorics.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    public partial class AdminForm : Form
    {
        private Thread _threadUpdateDistance;
        private Thread _threadListCruises;

        private bool _flagEndCreateCruise = false;
        HashSet<int> _harbours = new HashSet<int>();

        private string _connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

        public AdminForm(string messageWelcome)
        {
            InitializeComponent();

            CheckOneDayElapsed();

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

            // algo to generate random cruises
            //now, I generate all cruises with 4 harbours, but if the customer want more, we can increase the number of harbours ( to implement)

            gbxCruisesCurrentUser.Enabled = true;

            int[] inputCruises = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Combinations<int> combinations = new Combinations<int>(inputCruises, 4);
            string cformat = "Combinations of Cruises choose 4: size = {0}";
            Console.WriteLine(String.Format(cformat, combinations.Count));
            int counter = 0;

            IList<int>[] comb = new IList<int>[combinations.Count];
            foreach (IList<int> c in combinations)
            {
                //Console.WriteLine(String.Format("Cruise {0}: {1} {2} {3} {4}", counter, c[0], c[1], c[2], c[3]));
                comb.SetValue(c, counter);
                counter++;
            }

            List<string> cruises = new List<string>();
            string currentCruise = "";
            foreach(IList<int> c in combinations)
            {
                currentCruise = currentCruise + c[0] + " " + c[1] + " " + c[2] + " " + c[3];
                cruises.Add(currentCruise);
                currentCruise = "";
            }

            Console.WriteLine(comb[0][0].ToString() + comb[0][1].ToString() + comb[0][2].ToString() + comb[0][3].ToString());

            for (int i = 0; i < 10; i++)
            {
                InsertCruise(cruises[i]);
            }

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\Projects VS\CruiseBlackSea\CruiseBlackSea\log.txt"))
                {
                    file.WriteLine(DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            btnGenerateCruises.Enabled = false;

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
            toolStripStatusLabelCoordinates.Text = "";
            pbBlackSea.Enabled = false;
        }

        #endregion

        #region Utilities

        private void CheckOneDayElapsed()
        {
            String logDate = "";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    logDate = sr.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            if ((DateTime.Now - Convert.ToDateTime(logDate)).TotalDays >= 1)
            {
                DeleteCruisesGeneratedOverrated();
            }

        }

        private void DeleteCruisesGeneratedOverrated()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {
                        //Sql command to get cruises conditioned by period of cruise, selected by _user

                        //string sqlCommand = "TRUNCATE TABLE cruise.dbo.Cruise";
                        string sqlCommand = "DELETE FROM cruise.dbo.Cruise WHERE user_id_cruise IS NULL";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        
                        //command.Parameters.Add("@user_id_cruise", SqlDbType.Int, 100, "user_id_cruise").Value = null;
                        command.ExecuteNonQuery();
                        //retain data with data adapter, add data in data set, and show the table in data grid view

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void InsertCruise(string cruise)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {
                        //Sql command to get cruises conditioned by period of cruise, selected by _user

                        string sqlCommand = "INSERT INTO Cruise.dbo.Cruise (type_cruise, harbour_list, date_start, date_end, price, number_passengers) VALUES (@type_cruise, @harbour_list, @date_start, @date_end, @price, @number_passengers);";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        var today = DateTime.Now;
                        var tomorrow = today.AddDays(1);
                        var yesterday = today.AddDays(-1);

                        //add period of cruise selected by _user
                        command.Parameters.Add("@type_cruise", SqlDbType.Int, 100, "type_cruise").Value = 3;
                        command.Parameters.Add("@harbour_list", SqlDbType.VarChar, 100, "harbour_list").Value = cruise;
                        command.Parameters.Add("@date_start", SqlDbType.Date, 100, "date_start").Value = DateTime.Now;
                        command.Parameters.Add("@date_end", SqlDbType.Date, 100, "date_end").Value = DateTime.Now.AddDays(3);
                        command.Parameters.Add("@price", SqlDbType.Real, 100).Value = Convert.ToString(2 * 100);
                        command.Parameters.Add("@number_passengers", SqlDbType.Int, 100, "number_passengers").Value = 2;
                        //command.Parameters.Add("@user_id_cruise", SqlDbType.Int, 100, "user_id_cruise").Value = Login.IdCurrentUserLogged;
                        command.ExecuteNonQuery();
                        //retain data with data adapter, add data in data set, and show the table in data grid view

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

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
