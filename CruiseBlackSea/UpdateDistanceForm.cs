using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    public partial class UpdateDistanceForm : Form
    {
        //DateTime localDate = DateTime.Now;
        //CultureInfo culture = new CultureInfo("ro-RO");
        string connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";


        public UpdateDistanceForm()
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

        private void btnSaveDistance_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //Sql command to update the distance between 2 _harbours which are inserted in current form

                        string sqlCommand = "UPDATE cruise.dbo.Distance SET distance=@distance WHERE ID_harbour_source=@ID_harbour_source AND ID_harbour_dest=@ID_harbour_dest";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);

                        //get selected text from combobox
                        string sourceHarbour = cbxStartHarbourUpdateDistanceForm.SelectedItem.ToString();
                        string destinationHarbour = cbxEndHarbourUpdateDistanceForm.SelectedItem.ToString();
                        //get the index for selected harbour
                        string indexHarbourSource = GetHarbourIndex(sourceHarbour[0].ToString(), sourceHarbour[1].ToString());
                        string indexHarbourDestination = GetHarbourIndex(destinationHarbour[0].ToString(), destinationHarbour[1].ToString());
                        //add value for parameters from query
                        command.Parameters.Add("@ID_harbour_source", SqlDbType.Int, 100).Value = Convert.ToString(indexHarbourSource);
                        command.Parameters.Add("@ID_harbour_dest", SqlDbType.Int, 100).Value = Convert.ToString(indexHarbourDestination);
                        command.Parameters.Add("@distance", SqlDbType.Int, 100).Value = tbxDistanceBetweenHarboursUpdateDistanceForm.Text;

                        command.ExecuteNonQuery();
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

        private string GetHarbourIndex(string c1, string c2)
        { //get the index for one harbour
            if (c2 != " ") //if the harbour index is formed with 2 digits, then return the index concatenated
            {
                return c1 + c2;
            }
            else //else return the index formed only one digit
            {
                return c1;
            }
        }
    }
}
