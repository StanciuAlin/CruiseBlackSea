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
        string connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=companie;Integrated Security=True";


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
                            //Create a new thread with a new form
                            this.Close();
                            string str = "fvsf";
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

        private void openLoginForm()
        {

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                try
                {
                    using (LogInModel logInModel = new LogInModel())
                    {
                        var query = from obj in logInModel.AppUsers
                                    select obj;
                        if (query.SingleOrDefault() != null)
                        {
                            //if grant is 1
                            //if grant is 0

                        }
                        else
                        {
                            MessageBox.Show("Impossible to connect!");
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

            Application.Run(new CurrentUserForm());
        }
    }
}
