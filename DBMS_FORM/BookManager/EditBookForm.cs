using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FORM.BookManager
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            int flag = 0;
            SqlCommand comand = new SqlCommand();
            comand.CommandText = "EditBook";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Connection = db.getConnection;
            if (radioyes.Checked != true)
            {
                flag = 1;
            }

            try
            {
                comand.Parameters.Add("@flag", SqlDbType.Int).Value = flag;
                comand.Parameters.Add("@MS", SqlDbType.Int).Value = int.Parse(bookidtxt.Text);
                comand.Parameters.Add("@TS", SqlDbType.NVarChar).Value = booknametxt.Text;
                comand.Parameters.Add("@DG", SqlDbType.Int).Value = int.Parse(pricetxt.Text);
                comand.Parameters.Add("@NN", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                comand.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = publishyeartxt.Text;
                comand.Parameters.Add("@MTL", SqlDbType.Int).Value = int.Parse(genreidtxt.Text);
                comand.Parameters.Add("@NX", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                comand.Parameters.Add("@Soluong", SqlDbType.Int).Value = numericUpDown1.Value;

                comand.ExecuteNonQuery();
                MessageBox.Show("Edit Success", "Okey", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR" + E.Message);

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (bookidtxt.Text != "")
            {
                DB db = new DB();
                db.openconnection();
                int id = int.Parse(bookidtxt.Text);
                SqlCommand command = new SqlCommand("Select * From Sach Where MaSach=" + id, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);


                if (table.Rows.Count > 0)
                {
                    booknametxt.Text = table.Rows[0]["TenSach"].ToString();
                    pricetxt.Text = table.Rows[0]["DonGia"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["NgayNhap"];
                    publishyeartxt.Text = table.Rows[0]["NamXB"].ToString();
                    genreidtxt.Text = table.Rows[0]["MaTL"].ToString();
                    if (table.Rows[0]["NgayXoa"].ToString() != "")
                    {
                        dateTimePicker2.Value = (DateTime)table.Rows[0]["NgayXoa"];
                        radiono.Checked = false;
                        radioyes.Checked = true;
                    }
                    else
                    {
                        radioyes.Checked = false;
                        radiono.Checked = true;
                    }
                    numericUpDown1.Value = int.Parse(table.Rows[0]["SoluongCon"].ToString());


                }
                else
                {
                    MessageBox.Show("Not found", "Find Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else { MessageBox.Show("Pls enter ID to find", "Enter ID Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

