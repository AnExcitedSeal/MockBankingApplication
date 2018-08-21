using System;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace BankApplicationTellers
{
    public partial class LoginFrm : Form
    {
        #region Variables

        SQLiteConnection db = new SQLiteConnection("Data Source = StaffDatabase.sqlite; Version=3;");
        private string[] admin = new string[] { "Admin11", "Admin" };
        private int count;

        #endregion

        #region OnLoad
        public LoginFrm()
        {
            InitializeComponent();
            count = 0;
        }
        #endregion

        #region SubmitButton
        private void SubmitBttn_Click(object sender, EventArgs e)
        {
            CheckCount();
            CheckInput();
        }
        #endregion

        #region Check User Input
        private void CheckInput()
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            if (username == admin[0])
            {
                if (password == admin[1])
                {
                    Employee admin = new Employee(0, "Admin", "Admin", "N/A", 5, "Admin11", "Admin");
                    WriteToTextFile(admin);
                    LoadNextWindow();
                }
            }

            Employee user = new Employee();

            ConnectToDB(user, username);

            if (username == user.Username)
            {
                if (password == user.Password)
                {
                    WriteToTextFile(user);
                    LoadNextWindow();
                }
            }
            else
            {
                ++count;
                ClearEntries();
                UpdateTriesLabel();
            }

        }
        #endregion

        #region Check Count
        private void CheckCount()
        {
            if (count == 5)
            {
                MessageBox.Show
                    ("You have ran out of attempts, please try again later - A manager has been contacted",
                    "Attempt Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                File.Delete(@"C:\Users\Rhys\Desktop\temp.md");
                Application.Exit();

            }
        }
        #endregion

        #region Connect to DB

        private void ConnectToDB(Employee user, string username)
        {
            db.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Staff WHERE Username = @username", db);
            command.Parameters.AddWithValue("@username", username);
            SQLiteDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                user.EmployeeNO = Convert.ToInt32(dr[0]);
                user.FirstName = Convert.ToString(dr[1]);
                user.LastName = Convert.ToString(dr[2]);
                user.DOB = Convert.ToString(dr[3]);
                user.ClearanceLevel = Convert.ToInt32(dr[4]);
                user.Username = Convert.ToString(dr[5]);
                user.Password = Convert.ToString(dr[6]);
            }
        }

        #endregion

        #region Write Current User To TextFile
        private void WriteToTextFile(Employee user)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(user.EmployeeNO.ToString());
            sb.AppendLine(user.FirstName);
            sb.AppendLine(user.LastName);
            sb.AppendLine(user.ClearanceLevel.ToString());

            string path = "temp.md";

            if (File.Exists(path))
                File.Delete(path);


            File.WriteAllText(path, sb.ToString());
            File.SetAttributes(path, FileAttributes.Hidden);
        }
        #endregion

        #region Caps Lock Check (Username TextBox)
        private void usernameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock))
                capsLockLbl.Visible = true;
            else
                capsLockLbl.Visible = false;
        }
        #endregion

        #region Caps Lock Check (Password TextBox)
        private void passwordTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock))
                capsLockLbl.Visible = true;
            else
                capsLockLbl.Visible = false;
        }
        #endregion

        #region Refreshes The Tries Label

        private void UpdateTriesLabel()
        {
            countLbl.Text = $"Tries {count}/5";
        }

        #endregion

        #region Clear Entries
        private void ClearEntries()
        {
            usernameTxtBox.Clear();
            passwordTxtBox.Clear();
        }
        #endregion


        #region Exit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            File.Delete("temp.md");
            Application.Exit();
        }
        #endregion

        #region Load Next Window

        private void LoadNextWindow()
        {
            new TellerMainMenuFrm().Show();
            Hide();
        }

        #endregion
    }
}