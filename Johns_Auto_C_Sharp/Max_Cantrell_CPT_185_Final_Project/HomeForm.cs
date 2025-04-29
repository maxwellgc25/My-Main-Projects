using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max_Cantrell_CPT_185_Final_Project
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        public string displayName;
        public void HomeForm_Load(object sender, EventArgs e)
        {
            dispUserLabel.Text = "User: " + displayName;
        }

        
        

        private void submitCarButton_Click(object sender, EventArgs e)
        {
            ServiceInForm SubInForm = new ServiceInForm();
            SubInForm.ShowDialog();
        }

        private void submitCustButton_Click(object sender, EventArgs e)
        {
            ServiceInCustForm SubInCustForm = new ServiceInCustForm();
            SubInCustForm.ShowDialog();
        }

        private void partsOrderButton_Click(object sender, EventArgs e)
        {
            PartsOrderForm OrderParts = new PartsOrderForm();
            OrderParts.ShowDialog();
        }

        private void workCarButton_Click(object sender, EventArgs e)
        {
            ProgressForm ProgressCar = new ProgressForm();
            ProgressCar.ShowDialog();
        }

        private void upcomingApptButton_Click(object sender, EventArgs e)
        {
            UpcomingForm UpcomingPage = new UpcomingForm();
            UpcomingPage.ShowDialog();
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {
            UserInfoForm UserPage = new UserInfoForm();
            UserPage.ShowDialog();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            CalendarForm CalPage = new CalendarForm();
            CalPage.ShowDialog();
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
            ContactsForm ContactPage = new ContactsForm();
            ContactPage.ShowDialog();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            ManageForm ManagePage = new ManageForm();
            ManagePage.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
