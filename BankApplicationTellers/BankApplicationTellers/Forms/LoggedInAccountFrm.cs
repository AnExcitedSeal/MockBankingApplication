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
    public partial class LoggedInAccountFrm : Form
    {
        #region OnLoad
        public LoggedInAccountFrm()
        {
            InitializeComponent();
            ReadFile();
        }
        #endregion

        #region Exit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion

        #region Read File
        void ReadFile()
        {
            string path = "temp.md";

            string[] lines = File.ReadLines(path).ToArray();
            UpdateLabels(lines);

        }
        #endregion

        #region Update Form Labels
        void UpdateLabels(string[] lines)
        {
            try
            {
                employeeNoLbl.Text = lines[0].ToString();
                firstNameLbl.Text = lines[1];
                lastNameLbl.Text = lines[2];
                clearanceLevelLbl.Text = lines[3].ToString();
            }
            catch
            {
                MessageBox.Show
                    ("The current user could not be detected",
                    "User Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        #endregion
    }
}
