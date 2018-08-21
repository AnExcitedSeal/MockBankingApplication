using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BankApplicationTellers
{
    public partial class DeleteCustomerAccountFrm : Form
    {
        #region Variables
        private SQLiteConnection db = new SQLiteConnection("Data Source = CustomerDatabase.sqlite; Version=3;");
        #endregion

        #region On Load
        public DeleteCustomerAccountFrm()
        {
            InitializeComponent();
            db.Open();
        }
        #endregion

        #region Exit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Submit Button
        private void submitBttn_Click(object sender, EventArgs e)
        {
            int accountNO = int.Parse(accountNoTxtBox.Text);
            DeleteAccount(accountNO);
        }
        #endregion

        #region Delete Account
        private void DeleteAccount(int accountNO)
        {
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Customers WHERE AccountNO = @accountNO", db);
            command.Parameters.AddWithValue("@accountNO", accountNO);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer successfully deleted from the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToMainMenu();
        }
        #endregion

        #region Main Menu Button
        private void mainMenuBttn_Click(object sender, EventArgs e)
        {
            GoToMainMenu();
        }
        #endregion

        #region Go To Main Menu
        private void GoToMainMenu()
        {
            db.Close();
            TellerMainMenuFrm frm = new TellerMainMenuFrm();
            frm.Show();
            this.Close();
        }
        #endregion
    }
}
