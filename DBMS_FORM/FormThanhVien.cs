using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_FORM.Model;
using DBMS_FORM.BLL;
namespace DBMS_FORM
{
    public partial class FormThanhVien : Form
    {
        public FormThanhVien()
        {
            InitializeComponent();
        }
        BLL.ThanhVien thanhvien = new BLL.ThanhVien();
        private void FormThanhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN_QUANLYNHASACH_DBMSDataSet1.fun_ThanhVien' table. You can move, or remove it, as needed.
            this.fun_ThanhVienTableAdapter.Fill(this.dOAN_QUANLYNHASACH_DBMSDataSet1.fun_ThanhVien);
            dataGridView1.DataSource = thanhvien.hienThiTV();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thanhvien.searchTV(textBox_search.Text);
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Your search does not exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {

        }
    }
}
