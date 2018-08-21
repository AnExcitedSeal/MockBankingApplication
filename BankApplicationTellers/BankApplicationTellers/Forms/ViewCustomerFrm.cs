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
    public partial class ViewCustomerFrm : Form
    {
        #region Variables
        private SQLiteConnection db = new SQLiteConnection("Data Source = CustomerDatabase.sqlite; Version=3;");
        #endregion

        public ViewCustomerFrm()
        {
            InitializeComponent();
            db.Open();
        }

        #region Exit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void submitBttn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            string account = accountNOTxtBox.Text;

            SQLiteCommand command = new SQLiteCommand("SELECT * From Customers WHERE AccountNO= @account", db);
            command.Parameters.AddWithValue("@account", account);
            SQLiteDataReader dr = command.ExecuteReader();
            
            while (dr.Read())
            {

                c.AccountNO = Convert.ToInt32(dr[0]);
                c.FirstName = Convert.ToString(dr[1]);
                c.LastName = Convert.ToString(dr[2]);
                c.DOB = Convert.ToString(dr[3]);
                c.Address = Convert.ToString(dr[4]);
                c.Overdraft = Convert.ToBoolean(dr[5]);
                c.CurrentBalance = Convert.ToDecimal(dr[6]);
                c.PIN = Convert.ToInt32(dr[7]);

            };

            FillData(c);
        }
        private void FillData(Customer c)
        {
            firstNameLbl.Text = c.FirstName;
            lastNameLbl.Text = c.LastName;
            dobLbl.Text = c.DOB;
            addressLbl.Text = c.Address;
            overdraftLbl.Text = c.Overdraft.ToString();
            currrentBalLbl.Text = c.CurrentBalance.ToString();
            pinLbl.Text = c.PIN.ToString();

        }

        private void staffManagementBttn_Click(object sender, EventArgs e)
        {

            db.Close();
            new TellerMainMenuFrm().Show();
            Close();
        }
    }
}

