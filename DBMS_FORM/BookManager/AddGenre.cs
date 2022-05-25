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
    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        private void AddGenre_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (genreidtxt.Text != "")
            {
                int MTL = Convert.ToInt32(genreidtxt.Text);
                string TenTL = genrenametxt.Text.ToString();
                bool BiLoaiBo = false;
                if (radioyes.Checked)
                {
                    BiLoaiBo = true;
                }
                if (genrebll.MethodGenre(MTL, TenTL, BiLoaiBo) == true)
                {
                    MessageBox.Show("Successfull!!", "Add Genre");

                }
                else
                {
                    MessageBox.Show("Error!!", "Add Genre");
                }
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
