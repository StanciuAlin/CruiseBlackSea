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
    public partial class Login : Form
    {
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();
        private Thread threadCurrentUserForm;
        private String message = "Welcome ";

        string connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

        

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogInLoginForm_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                
                try
                {
                    using (LogInModel logInModel = new LogInModel())
                    {
                        var query = from obj in logInModel.AppUsers
                                    where obj.user_name_app == tbxUserName.Text && obj.password_user == tbxPassword.Text
                                    select obj;
                        if (query.SingleOrDefault() != null)
                        {
                            MessageBox.Show("Successfully log in! ");
                            
                            this.message = this.message + tbxUserName.Text;
                            //Create a new thread with a new form
                            this.Close();
                            threadCurrentUserForm = new Thread(openLoginForm);
                            threadCurrentUserForm.SetApartmentState(ApartmentState.STA);
                            threadCurrentUserForm.Start();
                        }
                        else
                        {
                            MessageBox.Show("User name or pasword is incorrect!!!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                connection.Close();
            }
            Console.ReadLine();
        }

        private int getCurrentUserType()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    //Console.WriteLine(this.tbxUserName.Text + "hhhhhh");
                    using (LogInModel logInModel = new LogInModel())
                    {

                        //Sql command to get type of user
                        string sqlCommand = "SELECT grant_user FROM AppUser WHERE user_name_app LIKE 'pop_user'";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);
                        Console.WriteLine(tbxUserName.Text);
                        command.Parameters.Add("@UserName", SqlDbType.VarChar, 100).Value = tbxUserName.Text;
                        command.Parameters.Add("@PasswordUser", SqlDbType.VarChar, 100).Value = tbxPassword.Text;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                        DataTable dataTable = new DataTable();
                        DataSet dataSet = new DataSet();

                        dataSet.Reset();
                        dataAdapter.Fill(dataSet);
                        dataTable = dataSet.Tables[0];

                        DataRow row = dataTable.Rows[0];
                        Console.WriteLine();
                        string message = "Welcome n " + tbxUserName.Top;

                        if (row["grant_user"].ToString() == "0")
                        {
                            return 0; //current user is normal user
                        }
                        else if (row["grant_user"].ToString() == "1")
                        {
                            return 1; //current user is admin user
                        }
                        else
                        {
                            MessageBox.Show("Impossible to connect!");
                            return -1;
                        }
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

        private void openLoginForm()
        {
            if(getCurrentUserType() == 0)
            {
                Application.Run(new CurrentUserForm(message, 0));
            }
            else if(getCurrentUserType() == 1)
            {
                Application.Run(new CurrentUserForm(message, 1));
            }
        }
    }
}
