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

        NhanVien quanLy = new NhanVien();
        private void lbSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  NOTE: Đợi phân quyền
            int maNV = 2002;  
            dataGridView1.DataSource = quanLy.capDuoi(maNV);
            if(dataGridView1.Rows.Count == 0)
            {
                dataGridView1.DataSource = quanLy.hoaDon(maNV);
            }    
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
