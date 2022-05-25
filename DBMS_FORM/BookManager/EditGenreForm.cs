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
    public partial class EditGenreForm : Form
    {
        public EditGenreForm()
        {
            InitializeComponent();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            int flag = 0;
            SqlCommand comand = new SqlCommand();
            comand.CommandText = "EditGender";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Connection = db.getConnection;
            if (radioyes.Checked != true)
            {
                flag = 1;
            }

            try
            {
                comand.Parameters.Add("@flag", SqlDbType.Int).Value = flag;
                comand.Parameters.Add("@MTL", SqlDbType.Int).Value = int.Parse(bookidtxt.Text);
                comand.Parameters.Add("@TTL", SqlDbType.NVarChar).Value = GenreNametxt.Text;

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
                SqlCommand command = new SqlCommand("Select * From TheLoai Where MTL=" + id, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);


                if (table.Rows.Count > 0)
                {
                    GenreNametxt.Text = table.Rows[0]["TenTL"].ToString();

                    if (table.Rows[0]["BiLoaiBo"].ToString() != "")
                    {

                        radiono.Checked = false;
                        radioyes.Checked = true;
                    }
                    else
                    {
                        radioyes.Checked = false;
                        radiono.Checked = true;
                    }



                }
                else
                {
                    MessageBox.Show("Not found", "Find Genre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else { MessageBox.Show("Pls enter ID to find", "Enter ID Pls!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
