using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplicationTellers
{
    public partial class InfoFrm : Form
    {
        #region OnLoad
        public InfoFrm()
        {
            InitializeComponent();
        }
        #endregion

        #region Exit Button
        private void CloseBttnImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
