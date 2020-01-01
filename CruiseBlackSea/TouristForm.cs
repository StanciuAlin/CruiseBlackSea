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
        Thread threadFinalCruise;

        string connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

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

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //////////////////////de rezolvat ori inserare, ori update la o croaziera facuta,
                        ///si apoi adaug datele din formular


                        //Sql command to get cruises conditioned by period of cruise, selected by user

                        string sqlCommand = "INSERT INTO cruise.dbo.Cruise VALUES (1, 3, '1 5 7 11', '2019-10-10', '2019-11-10', 1000, 2);";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //add period of cruise selected by user
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

            threadFinalCruise = new Thread(openFinalCruiseTourist);
            threadFinalCruise.SetApartmentState(ApartmentState.STA);
            threadFinalCruise.Start();

            cbxSelectCruisePeriod.Enabled = false;
            dTPStartPeriodTourist.Enabled = false;
            dTPEndPeriodTourist.Enabled = false;
            tbxDistanceBetweenHarboursUpdateDistanceForm.Enabled = false;
            btnBuyTicket.Enabled = false;
            //this.Close();
        }

        private void openFinalCruiseTourist()
        {
            Application.Run(new CruiseForm());

        }

        private void TouristForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //Sql command to get cruises conditioned by period of cruise, selected by user

                        string sqlCommand = "SELECT ID_cruise, harbour_list, date_start, date_end, price, number_passengers FROM Cruise WHERE type_cruise=3";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //add period of cruise selected by user
                        //command.Parameters.Add("@type_cruise", SqlDbType.Int, 100, "type_cruise").Value = Convert.ToString(cbxSelectCruisePeriod.SelectedItem.ToString()[0]);

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
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //Sql command to get cruises conditioned by period of cruise, selected by user

                        string sqlCommand = "SELECT ID_cruise, harbour_list, date_start, date_end, price, number_passengers FROM Cruise WHERE type_cruise=@type_cruise";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //add period of cruise selected by user
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
    }
}
