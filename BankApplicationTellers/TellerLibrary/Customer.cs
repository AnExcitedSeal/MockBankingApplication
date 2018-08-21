namespace BankApplicationTellers
{
    public class Customer
    {
        #region Variables
        private int accountNO;
        private string firstName;
        private string lastName;
        private string dob;
        private string address;
        private bool overdraft;
        private decimal currentBalance;
        private int pin;
        #endregion

        #region Constructors

        #region Customer Constructor
        public Customer(int accountNO = 0, string firstName = "", string lastName = "", string dob = "", string address = "", bool overdraft = false, decimal currentBalance = 0, int pin = 0000)
        {
            this.accountNO = accountNO;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.address = address;
            this.overdraft = overdraft;
            this.currentBalance = currentBalance;
            this.pin = pin;
        }
        #endregion

        #region AccountNO
        public int AccountNO
        {
            get { return accountNO; }
            set { accountNO = value; }
        }
        #endregion

        #region FirstName
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        #endregion

        #region LastName
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region DOB
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        #endregion

        #region Address
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Overdraft
        public bool Overdraft
        {
            get { return overdraft; }
            set { overdraft = value; }
        }
        #endregion

        #region Current Balance
        public decimal CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }
        #endregion

        #region PIN
        public int PIN
        {
            get { return pin; }
            set { pin = value; }
        }
        #endregion

        #endregion
    }
}