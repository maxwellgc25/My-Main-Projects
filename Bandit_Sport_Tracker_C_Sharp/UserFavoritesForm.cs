using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_project_i_brownie_bandits
{
    public partial class UserFavoritesForm : Form
    {
        private string user1;
        public UserFavoritesForm(String username)
        {
            InitializeComponent();
            user1 = username;
        }

        private void userFavesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userFavesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void UserFavoritesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.UserFaves' table. You can move, or remove it, as needed.
            this.userFavesTableAdapter.Fill(this.usersDataSet.UserFaves);
            this.userFavesTableAdapter.FilterUsername1(this.usersDataSet.UserFaves, user1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
