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
    public partial class FormThanhVien : Form
    {
        ThanhVienBLL tvBLl = new ThanhVienBLL();
        private int maOld;

        public FormThanhVien()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbThanhVien.Text != "") // Check k quá 50
            {
                string searchTV = txbThanhVien.Text;
                dataGridView1.DataSource = tvBLl.SearchTV(searchTV);
            }
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
             if (textBox_id.Text != "")
            {
                int idTv =Convert.ToInt32( textBox_id.Text);
                string name = textBox_name.Text.ToString();
                string phone = textBox_phone.Text.ToString();
                string address= richTextBox_address.Text.ToString();
                string email = textBox_Email.Text.ToString();
                int level = Convert.ToInt32(numeric_level.Value.ToString());
                int usetv = checkTypeUser();
                if (tvBLl.MethodTV(idTv, name, phone, address, email, usetv, level) == true)
                {
                    MessageBox.Show("Successfull!!", "Add Member");
                    fillDVGThanhVien();
                }
                else
                {
                    MessageBox.Show("Error!!", "Add Member");
                }
            }
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                int ma = Convert.ToInt32(textBox_id.Text);
                try
                {
                    tvBLl.DeleteTV(ma);
                    fillDVGThanhVien();
                    btnedit.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Input Id TV", "Add TV");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {

                int idTv = Convert.ToInt32(textBox_id.Text);
                string name = textBox_name.Text.ToString();
                string phone = textBox_phone.Text.ToString();
                string address = richTextBox_address.Text.ToString();
                string email = textBox_Email.Text.ToString();
                int level = Convert.ToInt32(numeric_level.Value.ToString());
                int usetv = checkTypeUser();
                if (checkBoxExpire.Checked)
                {
                    usetv = 0;
                }
                tvBLl.editThanhvien(idTv, maOld, name, phone, address, email, usetv, level);
                fillDVGThanhVien();
                btnedit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Input Id TV", "Add TV");
            }
        }
        private void fillDVGThanhVien()
        {
            dataGridView1.DataSource = tvBLl.GetTV();
        }

        private void FormThanhVien_Load(object sender, EventArgs e)
        {
            fillDVGThanhVien();
            label_name.Text = BaseData.Name;
            labelRole.Text = BaseData.role;
            btnedit.Enabled = false;
            btnremove.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnedit.Enabled = true;
            btnremove.Enabled = true;
            //numeric_booksale.ReadOnly = true;
            maOld = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            richTextBox_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_Email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            numeric_level.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            //textBox_salary.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //numeric_absent.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }
        private int checkTypeUser()
        {
            if(checkBoxExpire.Checked == true)
            {
                return 0;
            }
            
            return 1;
        }
        private void buttonExpire_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                int ma = Convert.ToInt32(textBox_id.Text);

                tvBLl.Expiretv(ma);
                fillDVGThanhVien();
                btnedit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Input Id TV", "Delete TV");
            }
        }
    }
}
