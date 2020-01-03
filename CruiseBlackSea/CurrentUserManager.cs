using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    class CurrentUserManager
    {
        private int _typeUser = -1;

        private Thread _threadAdminForm;
        private Thread _threadTouristForm;

        private string _messageWelcome = "";

        public CurrentUserManager()
        {
            //empty ctor
        }

        public void SetCurrentUser(string messageWelcome, int flag)
        {
            this._messageWelcome = messageWelcome;
            this._typeUser = flag;

            if (_typeUser == 0)
            {
                //Create a new Tourist form
                _threadTouristForm = new Thread(OpenTouristForm);
                _threadTouristForm.SetApartmentState(ApartmentState.STA);
                _threadTouristForm.Start();

            }
            else if (_typeUser == 1)
            {
                //Create a new Admin form
                _threadAdminForm = new Thread(OpenAdminForm);
                _threadAdminForm.SetApartmentState(ApartmentState.STA);
                _threadAdminForm.Start();
            }
            else
            {
                MessageBox.Show("Incorrect _user selected!", "User Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenTouristForm()
        {
            Application.Run(new TouristForm(this._messageWelcome));

        }

        private void OpenAdminForm()
        {
            Application.Run(new AdminForm(this._messageWelcome));

        }

    }
}
