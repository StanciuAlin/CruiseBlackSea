using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    public partial class ListCruisesForm : Form
    {
        string _connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

        static public String CurrentCruise { get; private set; }

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
                    MessageBox.Show("There are no records.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
