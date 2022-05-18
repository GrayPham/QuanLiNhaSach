using DBMS_FORM.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM
{
    public partial class TurnoverCheckForm : Form
    {
        public TurnoverCheckForm()
        {
            InitializeComponent();
        }
        ManagerBLL mBLL = new ManagerBLL();
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int type = checkTypeTurnOver();
            if (type != 0)
            {
                DVGTurnOver.DataSource =mBLL.GetTurnOver(type);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int checkTypeTurnOver()
        {
            if (radioButtonDay.Checked)
                return 1;
            if (radioButtonMouth.Checked)
                return 2;
            if (radioButtonYear.Checked)
                return 3;
            return 0;
        }
    }
}
