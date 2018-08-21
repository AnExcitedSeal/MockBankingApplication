using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationTellers
{
    public class Employee
    {
        #region Private Variables

        private int employeeNO;
        private string firstName;
        private string lastName;
        private string dob;
        private int clearanceLevel;
        private string username;
        private string password;

        #endregion

        #region Constructors 

        #region Employee Constructor
        public Employee(int employeeNO = 0, string firstName = "", string lastName = "", string dob = "", int clearanceLevel = 0, string username = "", string password = "")
        {
            this.employeeNO = employeeNO;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.clearanceLevel = clearanceLevel;
            this.username = username;
            this.password = password;
        }
        #endregion

        #region EmployeeNO
        public int EmployeeNO
        {
            get { return employeeNO; }
            set { employeeNO = value; }
        }
        #endregion

        #region First Name
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        #endregion

        #region Last Name
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region Date of Birth
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        #endregion

        #region Clearance Level 
        public int ClearanceLevel
        {
            get { return clearanceLevel; }
            set { clearanceLevel = value; }
        }
        #endregion

        #region Username
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        #endregion

        #region Password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #endregion
    }
}
