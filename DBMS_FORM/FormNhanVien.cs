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
using DBMS_FORM.Model;

namespace DBMS_FORM
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.hienThiNV();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.searchNV(txtfind.Text);
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Your search does not exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool add;
        private void btnadd_Click(object sender, EventArgs e)
        {
            add = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            add = false;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            add = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                int ma = int.Parse(textBox_id.Text);
                string hoTen = textBox_name.Text;
                string sdt = textBox_phone.Text;
                string dc = richTextBox_address.Text;

                int sachBan = (int)numeric_booksale.Value;
                int luong = int.Parse(textBox_salary.Text);
                int vang = (int)numeric_absent.Value;
                string kq = "";

                DOAN_QUANLYNHASACH_DBMSEntities addNV = new DOAN_QUANLYNHASACH_DBMSEntities();
                addNV.sp_AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, ref kq);

                addNV.fun_DanhSachNhanVien();


            }
        }
    }
}
