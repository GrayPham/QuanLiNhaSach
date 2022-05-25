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

namespace DBMS_FORM.BookManager
{
    public partial class AddProvider : Form
    {
        ProviderBLL pvBll = new ProviderBLL();
        public AddProvider()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (proidtxt.Text != "")
            {
                int mncc = Convert.ToInt32(proidtxt.Text);
                string namencc = pronametxt.Text.ToString();

                string address = addtxt.Text.ToString();
                string email = mailtxt.Text.ToString();
                bool ConHD = true;
                if (radiono.Checked)
                {
                    ConHD = false;
                }
                if (pvBll.MethodProvider(mncc, namencc, address, email, ConHD) == true)
                {
                    MessageBox.Show("Successfull!!", "Add Providers");
                    fillDVGNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Error!!", "Add Providers");
                }
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (proidtxt.Text != "")
            {
                int ma = Convert.ToInt32(proidtxt.Text);
                try
                {
                    pvBll.DeleteProvider(ma);
                    fillDVGNhaCungCap();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Input Provider Id ", "Add Providers");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            fillDVGNhaCungCap();
        }
        private void fillDVGNhaCungCap()
        {
            dataGridView1.DataSource = pvBll.GetProvider();
        }
    }
}
