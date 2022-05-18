using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_FORM.BLL;
namespace DBMS_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string userName { get; set; } = "Nguyen Van A";
        public string userRole { get; set; } = "Employee";
        NhanVien nv = new NhanVien();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.hienThi();
            label_name.Text = userName;
            lbRole.Text = userRole;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.search(textBox_search.Text);
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Your search does not exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
