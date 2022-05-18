using DBMS_FORM.BLL;
using DBMS_FORM.Object;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Login lg = new Login();
        private void loginbtn_Click(object sender, EventArgs e)
        {
			string username = txtUsename.Text;
			string password = txtPassword.Text;
			if (login(username, password))
			{
                MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK);
                BaseData.username = username;
                this.Hide();
                Form1 main = new Form1();
                main.ShowDialog();
                this.Visible = true;
            }
			else
			{
				MessageBox.Show("Check username or password", "Login", MessageBoxButtons.OK);
			}
		}
        public bool login(string username, string password)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)lg.CheckLogin(username, password);

            if (dt.Rows.Count > 0)
            {
                BaseData.Name = dt.Rows[0]["HoTenNV"].ToString();
                BaseData.username = dt.Rows[0]["username"].ToString();
                BaseData.role = dt.Rows[0]["TypeName"].ToString();
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
