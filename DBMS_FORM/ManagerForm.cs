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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void fillDVG_NVOfNVQL()
        {
            ManagerBLL mbll = new ManagerBLL();
            int manql = BaseData.idUser;
            DVGNhanVien.DataSource = mbll.GetNvOfManager(manql);
        }

        private void importBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Importfrm importfrm = new Importfrm();
            this.Visible = false;
            importfrm.ShowDialog();
            this.Visible=true;
        }

        private void staffManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            this.Visible = false;
            formNhanVien.ShowDialog();
            this.Visible = true;
        }

        private void turnoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoverCheckForm turnoverCheckForm = new TurnoverCheckForm();
            this.Visible = false;
            turnoverCheckForm.ShowDialog();
            this.Visible = true;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            label_name.Text = BaseData.Name;

        }
    }
}
