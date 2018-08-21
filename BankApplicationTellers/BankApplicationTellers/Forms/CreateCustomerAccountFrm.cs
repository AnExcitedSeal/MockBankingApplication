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
    public partial class CreateCustomerAccountFrm : Form
    {
        #region Variables
        private SQLiteConnection db = new SQLiteConnection("Data Source = CustomerDatabase.sqlite; Version=3;");
        #endregion

        #region On Load
        public CreateCustomerAccountFrm()
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

        #region Main Menu Button
        private void mainMenuBttn_Click(object sender, EventArgs e)
        {
            GoToMainMenu();
        }
        #endregion

        #region Submit Button
        private void submitBttn_Click(object sender, EventArgs e)
        {
            GenerateRandomDetails();
        }
        #endregion

        #region Generate Random Details (Pin + Account Number)
        private void GenerateRandomDetails()
        {
            bool done = false;
            Random r = new Random();

            while (!done)
            {
                int pin = r.Next(999, 9999);
                int accountNO = r.Next();
                if (CheckAgainstDatabase(accountNO))
                {
                    done = true;
                    CollectData(pin, accountNO);
                }
            }
        }
        #endregion

        #region Check Data Against Database
        private bool CheckAgainstDatabase(int accountNO)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Customers WHERE AccountNO = @accountNO", db);
            command.Parameters.AddWithValue("@accountNO", accountNO);
            SQLiteDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Group All Data Together
        private void CollectData(int pin, int accountNO)
        {
            Customer c = new Customer
            {
                AccountNO = accountNO,
                FirstName = firstNameTxtBox.Text,
                LastName = lastNameTxtBox.Text,
                DOB = dobTxtBox.Text,
                Address = addressTxtBox.Text,
                Overdraft = overdraftCheckBox.Checked,
                CurrentBalance = 0,
                PIN = pin
            };
            PushToDB(c);
        }
        #endregion

        #region Push To Database
        private void PushToDB(Customer c)
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO Customers(AccountNO, FirstName, LastName, DOB, Address, Overdraft, CurrentBalance, PIN) VALUES (@accountNO, @firstname, @lastname, @DOB, @Address, @Overdraft, @CurrentBalance, @Pin)", db);
            command.Parameters.AddWithValue("@accountNO", c.AccountNO);
            command.Parameters.AddWithValue("@firstname", c.FirstName);
            command.Parameters.AddWithValue("@lastname", c.LastName);
            command.Parameters.AddWithValue("@DOB", c.DOB);
            command.Parameters.AddWithValue("@Address", c.Address);
            command.Parameters.AddWithValue("@Overdraft", c.Overdraft.ToString());
            command.Parameters.AddWithValue("@CurrentBalance", c.CurrentBalance);
            command.Parameters.AddWithValue("@Pin", c.PIN);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer successfully added to the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToMainMenu();
        }
        #endregion

        #region Go To Main Menu
        private void GoToMainMenu()
        {
            db.Close();
            Close();
            new TellerMainMenuFrm().Show();
        }
        #endregion

    }
}
