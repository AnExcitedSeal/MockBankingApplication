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
using System.Data.SQLite;

namespace BankApplicationTellers
{
    public partial class BalanceManagementFrm : Form
    {
        #region Variables
        private SQLiteConnection db = new SQLiteConnection("Data Source = CustomerDatabase.sqlite; Version=3;");
        #endregion

        #region On Load
        public BalanceManagementFrm()
        {
            InitializeComponent();
            db.Open();
        }
        #endregion

        #region Quit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            File.Delete("temp.md");
            Application.Exit();
        }
        #endregion

        #region Submit Button
        private void submitBttn_Click(object sender, EventArgs e)
        {
            int customerNO = Convert.ToInt32(customerIdTxtBox.Text);
            string method = methodDrpDwn.Text;
            if (customerNO.ToString() == String.Empty)
            {
                MessageBox.Show("You cannot leave the account number field blank", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer c = new Customer();
            GetData(customerNO , c);
        }
        #endregion

        #region Get Data From Database
        private void GetData(int ID, Customer c)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Customers WHERE AccountNO = @ID", db);
            command.Parameters.AddWithValue("@ID", ID);
            SQLiteDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                c.AccountNO = ID;
                c.CurrentBalance = Convert.ToDecimal(dr[6]);
            }
            UpdateData(c);

        }
        #endregion

        #region Update The Data
        void UpdateData(Customer c)
        {
            decimal value = amountUpDown.Value;
            c.CurrentBalance += value;
            PushToDatabase(c);
        }
        #endregion

        #region Pushing it Back
        void PushToDatabase(Customer c)
        {
            SQLiteCommand command = new SQLiteCommand("UPDATE Customers SET CurrentBalance = @value WHERE AccountNO = @number", db);
            command.Parameters.AddWithValue("@value", c.CurrentBalance);
            command.Parameters.AddWithValue("@number", c.AccountNO);
            command.ExecuteNonQuery();
            db.Close();
            LoadNextWindow();
        }
        #endregion

        #region Load Next Window
        void LoadNextWindow()
        {
            new TellerMainMenuFrm().Show();
            Close();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            db.Close();
            new TellerMainMenuFrm().Show();
            Close();
        }
    }
}
