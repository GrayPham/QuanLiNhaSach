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

        private void button_thue_Click(object sender, EventArgs e)
        {
            Thuefrm thuefrm = new Thuefrm();
            this.Visible = false;
            thuefrm.ShowDialog(); 
            this.Visible=true;
        }

        private void button_bansach_Click(object sender, EventArgs e)
        {
            Banfrm banfrm = new Banfrm();
            this.Visible=false;
            banfrm.ShowDialog();
            this.Visible = true;
        }

        private void button_hoadon_Click(object sender, EventArgs e)
        {
            NhapHoaDon nhapHoaDon = new NhapHoaDon();
            this.Visible=false; 
            nhapHoaDon.ShowDialog();
            this.Visible= true;
        }

        private void button_cungcap_Click(object sender, EventArgs e)
        {
            
        }

        private void button_thanhvien_Click(object sender, EventArgs e)
        {
            FormThanhVien formThanhVien = new FormThanhVien();
            this.Visible=false;
            formThanhVien.ShowDialog();
            this.Visible = true;
        }

        private void button_manager_Click(object sender, EventArgs e)
        {
            Manager managerForm = new Manager();
            this.Visible=false;
            managerForm.ShowDialog();
            this.Visible = true;
        }
    }
}
