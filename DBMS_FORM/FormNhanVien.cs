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
    }
}
