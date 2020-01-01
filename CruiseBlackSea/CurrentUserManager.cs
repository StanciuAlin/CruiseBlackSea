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
        private int typeUser = -1;

        Thread threadAdminForm;
        Thread threadTouristForm;

        private string messageWelcome = "";

        public CurrentUserManager()
        {
            //empty ctor
        }

        public void SetCurrentUser(string messageWelcome, int flag)
        {
            this.messageWelcome = messageWelcome;
            this.typeUser = flag;

            if (typeUser == 0)
            {
                //Create a new Tourist form
                //start a new thread for update form
                threadTouristForm = new Thread(OpenTouristForm);
                threadTouristForm.SetApartmentState(ApartmentState.STA);
                threadTouristForm.Start();

            }
            else if (typeUser == 1)
            {
                //Create a new Admin form
                threadAdminForm = new Thread(OpenAdminForm);
                threadAdminForm.SetApartmentState(ApartmentState.STA);
                threadAdminForm.Start();
            }
            else
            {
                MessageBox.Show("Incorrect user selected!", "User Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenTouristForm()
        {
            Application.Run(new TouristForm(this.messageWelcome));

        }

        private void OpenAdminForm()
        {
            Application.Run(new AdminForm(this.messageWelcome));

        }

    }
}
