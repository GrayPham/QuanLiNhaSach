using DBMS_FORM.BLL;
using DBMS_FORM.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM
{
    public partial class TurnoverCheckForm : Form
    {
        public TurnoverCheckForm()
        {
            InitializeComponent();
        }
        ManagerBLL mBLL = new ManagerBLL();
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int type = checkTypeTurnOver();
            if (type != 0)
            {
                DVGTurnOver.DataSource =mBLL.GetTurnOver(type);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int checkTypeTurnOver()
        {
            if (radioButtonDay.Checked)
                return 1;
            if (radioButtonMouth.Checked)
                return 2;
            if (radioButtonYear.Checked)
                return 3;
            return 0;
        }
        private void ToDoc(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
            {

                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                Console.WriteLine('\t');
            }
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
                Console.WriteLine('\t');
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Word 2007 or Higher(.docx) | *.docx";
                sf.FileName = "exportday.doc";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    ToDoc(DVGTurnOver, sf.FileName);
                }
            }
            else if (radioButtonMouth.Checked)
            {

                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Word 2007 or Higher(.docx) | *.docx";
                sf.FileName = "exportmonth.doc";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    ToDoc(DVGTurnOver, sf.FileName);
                }

            }
            else if (radioButtonYear.Checked)
            {

                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Word 2007 or Higher(.docx) | *.docx";
                sf.FileName = "exportyear.doc";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    ToDoc(DVGTurnOver, sf.FileName);
                }

            }
        }

        private void TurnoverCheckForm_Load(object sender, EventArgs e)
        {
            label_name.Text = BaseData.Name;

        }
    }
}
