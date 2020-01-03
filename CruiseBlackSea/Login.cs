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
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();

        private Thread _threadCurrentUserForm;

        private String _messageCurrentUser = "Welcome ";

        private string _user = "";
        private string _password = "";

        private string _connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

        //public static int idCurrentUserLogged = 0;

        static public int IdCurrentUserLogged { get; private set; }

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogInLoginForm_Click(object sender, EventArgs e)
        {
            _user = tbxUserName.Text;
            _password = tbxPassword.Text;

            using (SqlConnection connection = new SqlConnection(_connString))
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
                            
                            this._messageCurrentUser = this._messageCurrentUser + tbxUserName.Text;
                            //Create a new thread with a new form
                            this.Close();
                            _threadCurrentUserForm = new Thread(openLoginForm);
                            _threadCurrentUserForm.SetApartmentState(ApartmentState.STA);
                            _threadCurrentUserForm.Start();
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
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                try
                {
                    connection.Open();

                    using (LogInModel logInModel = new LogInModel())
                    {
                        // Sql command to get type of _user
                        string sqlCommand = "SELECT grant_user, ID_user FROM AppUser WHERE user_name_app=@UserName AND password_user=@PasswordUser";
                        SqlCommand command = new SqlCommand(sqlCommand, connection);
                        
                        command.Parameters.Add("@UserName", SqlDbType.VarChar, 100).Value = _user;
                        command.Parameters.Add("@PasswordUser", SqlDbType.VarChar, 100).Value = _password;
                        command.ExecuteNonQuery();

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        DataSet dataSet = new DataSet();

                        dataSet.Reset();
                        dataAdapter.Fill(dataSet);
                        dataTable = dataSet.Tables[0];

                        DataRow row = dataTable.Rows[0];
                        IdCurrentUserLogged = Convert.ToInt32(row["ID_user"]);

                        if (row["grant_user"].ToString() == "0")
                        {
                            return 0; //current _user is normal _user -> Tourist
                        }
                        else if (row["grant_user"].ToString() == "1")
                        {
                            return 1; //current _user is admin _user -> Admin
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
            CurrentUserManager currentUserManager = new CurrentUserManager();
            if(getCurrentUserType() == 0)
            {
                currentUserManager.SetCurrentUser(_messageCurrentUser, 0);
            }
            else if(getCurrentUserType() == 1)
            {
                currentUserManager.SetCurrentUser(_messageCurrentUser, 1);
            }
        }

    }
}
