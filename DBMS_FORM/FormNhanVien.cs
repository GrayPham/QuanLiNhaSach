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
        ManagerBLL managerBLL = new ManagerBLL();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            fillDVGNhanVien();
            fillComboBox();
        }
        private void fillDVGNhanVien()
        {
            dataGridView1.DataSource = nv.hienThiNV();
        }
        private void fillComboBox(int index = 0)
        {
            comboBox_find.DisplayMember = "MNV";
            comboBox_find.ValueMember = "MNV";
            comboBox_find.DataSource = managerBLL.GetManager();
            comboBox_find.SelectedIndex = index;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.searchNV(txtfind.Text);
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Your search does not exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text != "")
            {
                
                    int ma = int.Parse(textBox_id.Text);
                    string hoTen = textBox_name.Text;
                    string sdt = textBox_phone.Text;
                    string dc = richTextBox_address.Text;

                    int sachBan = (int)numeric_booksale.Value;
                    int luong = int.Parse(textBox_salary.Text);
                    int vang = (int)numeric_absent.Value;
                    string kq = "";
                    int maNQL = Convert.ToInt32(comboBox_find.SelectedValue);
                    managerBLL.AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, maNQL);

                    //addNV.sp_AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, ref kq);
                    fillDVGNhanVien();
                
                
            }
            else
            {
                MessageBox.Show("Input Id Staff", "Add Staff");
            }


        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            
        }

    }
}
