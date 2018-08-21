using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankApplicationTellers
{
    public partial class AccountManagementFrm : Form
    {
        #region On Load
        public AccountManagementFrm()
        {
            InitializeComponent();
        }
        #endregion

        #region Quit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            File.Delete("temp.md");
            Application.Exit();
        }
        #endregion

        #region Back Button
        private void backBttn_Click(object sender, EventArgs e)
        {
            new TellerMainMenuFrm().Show();
            Close();            
        }
        #endregion

        #region Create Account Button
        private void createAccountBttn_Click(object sender, EventArgs e)
        {
            new CreateCustomerAccountFrm().Show();
            Hide();
        }
        #endregion

        #region Delete Account Button
        private void deleteAccountBttn_Click(object sender, EventArgs e)
        {
            new DeleteCustomerAccountFrm().Show();
            Hide();
        }
        #endregion

        #region Info Button
        private void infoBttnImg_Click(object sender, EventArgs e)
        {
            new InfoFrm().ShowDialog();
        }
        #endregion

        private void deleteAccountBttn_Click_1(object sender, EventArgs e)
        {
            new DeleteCustomerAccountFrm().Show();
            Hide();
        }
    }
}
