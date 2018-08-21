using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BankApplicationTellers
{
    public partial class TellerMainMenuFrm : Form
    {
        #region Variables

        bool isFullscreen;

        #endregion

        #region OnLoad
        public TellerMainMenuFrm()
        {
            InitializeComponent();
            isFullscreen = false;
        }
        #endregion

        #region Window State
        private void windowStateImg_Click(object sender, EventArgs e)
        {
            if (!isFullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                isFullscreen = true;
                windowStateImg.Image = BankApplicationTellers.Properties.Resources.icons8_collapse_filled_50;
            }
            else if (isFullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                isFullscreen = false;
                windowStateImg.Image = BankApplicationTellers.Properties.Resources.icons8_fit_to_width_filled_50;
            }
        }
        #endregion

        #region Exit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            File.Delete("temp.md");
            Application.Exit();
        }
        #endregion

        #region Information Button
        private void infoBttnImg_Click(object sender, EventArgs e)
        {
            new InfoFrm().Show();
        }
        #endregion

        #region Account Management Button
        private void accountManagementBttn_Click(object sender, EventArgs e)
        {
            new AccountManagementFrm().Show();
            Close();
        }
        #endregion

        #region Balance Management Button
        private void balanceManagementBttn_Click(object sender, EventArgs e)
        {
            new BalanceManagementFrm().Show();
            Close();
        }
        #endregion

        #region Staff Management Button
        private void staffManagementBttn_Click(object sender, EventArgs e)
        {
            string path = "temp.md";

            string[] lines = File.ReadLines(path).ToArray();
            int currentUserLevel = Convert.ToInt32(lines[3]);

            if (currentUserLevel < 4)
            {
                MessageBox.Show
                    ("You do not have the required clearance level to access this funtion.",
                    "Clearance Level Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                MessageBox.Show
                    ("This feature has not yet been implemented.",
                    "Unknown File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                Close();
            }
        }
        #endregion


        #region View Customer Button
        private void viewCustomerBttn_Click(object sender, EventArgs e)
        {
            new ViewCustomerFrm().Show();
            Hide();
        }
        #endregion

        #region View This Accoount Button
        private void thisAccountBttnImg_Click(object sender, EventArgs e)
        {
            new LoggedInAccountFrm().ShowDialog();
        }

        #endregion

    }
}
