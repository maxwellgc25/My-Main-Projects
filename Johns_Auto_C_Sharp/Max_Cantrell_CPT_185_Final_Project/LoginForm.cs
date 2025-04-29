using System.Diagnostics.Eventing.Reader;
using System.Web;

namespace Max_Cantrell_CPT_185_Final_Project
{
    public partial class LoginForm : Form
    {
        //Max Cantrell
        //CPT 185 A80H
        //Final Project
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ReadUser(ref string[,] userArray)
        {

            try
            {
                int index = 0;
                int user = 0;
                int thefields = 0;
                string rawLine = "";
                char[] delim = { ',' };

                //open login file
                StreamReader inputFile;
                inputFile = File.OpenText("logInfo.txt");

                while (index < userArray.Length && !inputFile.EndOfStream)
                {
                    while (thefields < 5)
                    {
                        rawLine = inputFile.ReadLine();
                        string[] tokens = rawLine.Split(delim);
                        foreach (string i in tokens)
                        {
                            userArray[user, thefields] = i;
                        }
                        thefields++;
                    }
                    user++;
                    //userArray[user,thefields]= inputFile.ReadLine();
                    //inputFile.ReadLine()
                }

            }
            catch
            {
                MessageBox.Show("Error reading Files");
            }


        }

        private String UserInfo(string user, string password)
        {
            if (user == "")
                return "";
            else if (user == "CThompson" && password == "12345")
                return "Charles";
            else if (user == "JSmith" && password == "12345")
                return "John";
            else if (user == "CSmith" && password == "12345")
                return "Carol";
            else if (user == "DGlenn" && password == "12345")
                return "David";
            else
                return "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //create variables to receive input
            string userIn;
            string pass;
            string authorized;

            //read user input
            userIn = userInTextBox.Text;
            pass = passInTextBox.Text;

            //test user input
            authorized = UserInfo(userIn, pass);


            if (authorized != "")
            {
                userInTextBox.Text = "";
                passInTextBox.Text = "";
                HomeForm HomePage = new HomeForm();
                HomePage.displayName = authorized;
                HomePage.ShowDialog();
            }
            else
            {
                MessageBox.Show("User or Password is Incorrect");
            }

            /*
            //create array to hold authorized user/pass info
            string[,] userArray = new string[10,5];

            //get user/pass info from file to array
            ReadUser(ref userArray);

            MessageBox.Show("File Read");

            //validate user login info
            */

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
