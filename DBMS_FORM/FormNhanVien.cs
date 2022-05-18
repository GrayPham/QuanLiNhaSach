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
        private int manvOld;
        
        public FormNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            fillDVGNhanVien();
            fillComboBox();
            btnedit.Enabled=false;
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

                    int maNQL = Convert.ToInt32(comboBox_find.SelectedValue);
                    managerBLL.AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, maNQL);

                    //addNV.sp_AddNV(ma, hoTen, sdt, dc, sachBan, luong, vang, ref kq);
                    //fillDVGNhanVien();
                
                
            }
            else
            {
                MessageBox.Show("Input Id Staff", "Add Staff");
            }


        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                int ma = int.Parse(textBox_id.Text);
                string hoTen = textBox_name.Text;
                string sdt = textBox_phone.Text;
                string dc = richTextBox_address.Text;

                
                int luong = int.Parse(textBox_salary.Text);
                int vang = (int)numeric_absent.Value;

                int maNQL = Convert.ToInt32(comboBox_find.SelectedValue);
                managerBLL.EditNV(ma, manvOld, hoTen, sdt, dc, luong, vang, maNQL);
                fillDVGNhanVien();
                btnedit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Input Id Staff", "Add Staff");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                int ma = int.Parse(textBox_id.Text);
                
                managerBLL.RemoveNV(ma);
                fillDVGNhanVien();
                btnedit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Input Id Staff", "Add Staff");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnedit.Enabled = true;
            numeric_booksale.ReadOnly = true;
            manvOld =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBox_address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numeric_booksale.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            textBox_salary.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            numeric_absent.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                int ma = int.Parse(textBox_id.Text);

                managerBLL.DeleteNV(ma);
                fillDVGNhanVien();
                btnedit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Input Id Staff", "Add Staff");
            }
        }
    }
}
