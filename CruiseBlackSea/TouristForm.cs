using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private Thread _threadFinalCruise;
        private Thread _threadReturnToLoginCruise;

        private string _connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

        public TouristForm(string messageWelcome)
        {
            InitializeComponent();

            toolStripStatusLblDateTime.Alignment = ToolStripItemAlignment.Left;

            System.Windows.Forms.Timer timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);
            timerDateTime.Enabled = true;

            lblTitle.Text += "Welcome " + messageWelcome + " tourist";
        }

        #region Tourist form management

        private void TouristForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //Sql command to get cruises conditioned by period of cruise, selected by _user

                        string sqlCommand = "SELECT ID_cruise, harbour_list, date_start, date_end, price, number_passengers FROM Cruise WHERE type_cruise=3";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //add period of cruise selected by _user
                        //retain data with data adapter, add data in data set, and show the table in data grid view

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        DataSet dataSet = new DataSet();

                        dataSet.Reset();
                        dataAdapter.Fill(dataSet);
                        dataTable = dataSet.Tables[0];

                        //set column header for data showed
                        dataTable.Columns[0].ColumnName = "ID";
                        dataTable.Columns[1].ColumnName = "Circuit";
                        dataTable.Columns[2].ColumnName = "Date Start";
                        dataTable.Columns[3].ColumnName = "Date End";
                        dataTable.Columns[4].ColumnName = "Price";
                        dataTable.Columns[5].ColumnName = "Passengers";

                        //set data grid source to table
                        dgvListCruises.DataSource = dataTable;
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
        private void cbxSelectCruisePeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //Sql command to get cruises conditioned by period of cruise, selected by _user

                        string sqlCommand = "SELECT ID_cruise, harbour_list, date_start, date_end, price, number_passengers FROM Cruise WHERE type_cruise=@type_cruise";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //add period of cruise selected by _user
                        command.Parameters.Add("@type_cruise", SqlDbType.Int, 100, "type_cruise").Value = Convert.ToString(cbxSelectCruisePeriod.SelectedItem.ToString()[0]);

                        //retain data with data adapter, add data in data set, and show the table in data grid view
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        DataSet dataSet = new DataSet();

                        dataSet.Reset();
                        dataAdapter.Fill(dataSet);
                        dataTable = dataSet.Tables[0];

                        //set column header for data showed
                        dataTable.Columns[0].ColumnName = "ID";
                        dataTable.Columns[1].ColumnName = "Circuit";
                        dataTable.Columns[2].ColumnName = "Date Start";
                        dataTable.Columns[3].ColumnName = "Date End";
                        dataTable.Columns[4].ColumnName = "Price";
                        dataTable.Columns[5].ColumnName = "Passengers";

                        //set data grid source to table
                        dgvListCruises.DataSource = dataTable;
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

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            //start a new thread in order to show final circuit for cruise
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        /// de rezolvat ori inserare, ori update la o croaziera facuta,
                        /// si apoi adaug datele din formular

                        //Sql command to get cruises conditioned by period of cruise, selected by _user

                        string sqlCommand = "INSERT INTO Cruise.dbo.Cruise (type_cruise, harbour_list, date_start, date_end, price, number_passengers) VALUES (@type_cruise, @harbour_list, @date_start, @date_end, @price, @number_passengers);";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //add period of cruise selected by _user
                        command.Parameters.Add("@type_cruise", SqlDbType.Int, 100, "type_cruise").Value = Convert.ToString(cbxSelectCruisePeriod.SelectedItem.ToString()[0]);
                        command.Parameters.Add("@harbour_list", SqlDbType.VarChar, 100, "harbour_list").Value = "1 3 5 7";
                        command.Parameters.Add("@date_start", SqlDbType.Date, 100, "date_start").Value = Convert.ToString(dTPStartPeriodTourist.Value.ToString());
                        command.Parameters.Add("@date_end", SqlDbType.Date, 100, "date_end").Value = Convert.ToString(dTPEndPeriodTourist.Value.ToString());
                        command.Parameters.Add("@price", SqlDbType.Real, 100).Value = Convert.ToString((GetCruisePrice("1 3 5 7") * 100) * Convert.ToInt16(tbxDistanceBetweenHarboursUpdateDistanceForm.Text.ToString()));
                        command.Parameters.Add("@number_passengers", SqlDbType.Int, 100, "number_passengers").Value = Convert.ToString(tbxDistanceBetweenHarboursUpdateDistanceForm.Text.ToString());
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

            _threadFinalCruise = new Thread(openFinalCruiseTourist);
            _threadFinalCruise.SetApartmentState(ApartmentState.STA);
            _threadFinalCruise.Start();

            cbxSelectCruisePeriod.Enabled = false;
            dTPStartPeriodTourist.Enabled = false;
            dTPEndPeriodTourist.Enabled = false;
            tbxDistanceBetweenHarboursUpdateDistanceForm.Enabled = false;
            btnBuyTicket.Enabled = false;
            //this.Close();
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

        private void openFinalCruiseTourist()
        {
            Application.Run(new CruiseForm());

        }

        private void openReturnToLoginCruise()
        {
            Application.Run(new Login());

        }

        private short GetCruisePrice(string cruiseString)
        {
            return Convert.ToInt16(cruiseString.Length / 2 + 1);
        }

        #endregion

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            _threadReturnToLoginCruise = new Thread(openReturnToLoginCruise);
            _threadReturnToLoginCruise.SetApartmentState(ApartmentState.STA);
            _threadReturnToLoginCruise.Start();

            this.Close();
        }
    }
}
