using DBMS_FORM.Object;
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

namespace DBMS_FORM
{
    public partial class Banfrm : Form
    {
        public Banfrm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB mydb = new DB();
            mydb.openconnection();
            int Soluong = int.Parse(textBox3.Text);
            int MS = int.Parse(textBox2.Text);
            SqlCommand command = new SqlCommand("Select MaSach, TenSach, DonGia FROM Sach Where MaSach =" + MS, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (btnYes.Checked)
            {
                int MTV = int.Parse(textBox4.Text);
                SqlCommand command2 = new SqlCommand("Select MTV FROM ThanhVien WHERE MTV =" + MTV, mydb.getConnection);
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();
                adapter.SelectCommand = command2;
                adapter.Fill(table2);
           
                if (table2.Rows.Count > 0)
                {
                    if (table.Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "CheckMuon";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = mydb.getConnection;
                        SqlParameter parameter = new SqlParameter();
                        cmd.Parameters.Add("@MTV", SqlDbType.Int).Value = MTV;
                        cmd.Parameters.Add("@MS", SqlDbType.Int).Value = MS;
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Soluong;
                        cmd.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@Status2", SqlDbType.Int).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        int flag1 = Convert.ToInt32(cmd.Parameters["@Status"].Value);
                        int flag2 = Convert.ToInt32(cmd.Parameters["@Status2"].Value);
                        if (flag2 == 1)
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader["MaSach"].ToString(), reader["TenSach"].ToString(), reader["DonGia"].ToString(), textBox3.Text);
                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("So Luong Sach Khong Du", "MS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Invalid Ma Sach", "MS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Ma Thanh Vien", "MTV ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                SqlDataReader reader = command.ExecuteReader();
                if (table.Rows.Count > 0)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["MaSach"].ToString(), reader["TenSach"].ToString(), reader["DonGia"].ToString(), textBox3.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Ma Sach", "MS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }



        private void btnPrintf_Click(object sender, EventArgs e)
        {
            DB mydb = new DB();
            mydb.openconnection();


            SqlCommand cmdhd = new SqlCommand("Select MHD From HoaDon", mydb.getConnection);
            int MHD = 0;
            SqlDataReader reader = cmdhd.ExecuteReader();

            while (reader.Read())
            {
                if (MHD <= int.Parse(reader["MHD"].ToString()))
                {
                    MHD = int.Parse(reader["MHD"].ToString()) + 1;
                }

            }
            reader.Close();
            if (btnYes.Checked)
            {


                try
                {

                    int row = dataGridView1.Rows.Count;
                    int tong = 0;
                    int MTV = int.Parse(textBox4.Text);
                    for (int i = 0; i < row - 1; i++)
                    {
                        tong += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                    for (int i = 0; i < row - 1; i++)
                    {
                        SqlCommand comand = new SqlCommand();
                        comand.CommandText = "INSERTBANTV";
                        comand.CommandType = CommandType.StoredProcedure;
                        comand.Connection = mydb.getConnection;
                        comand.Parameters.Add("@flag", SqlDbType.Int).Value = i;
                        comand.Parameters.Add("@GIAMGIA", SqlDbType.Int).Value = 0;
                        comand.Parameters.Add("@MS", SqlDbType.Int).Value = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        comand.Parameters.Add("@MANV", SqlDbType.Int).Value = 2001;
                        comand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        comand.Parameters.Add("@MTV", SqlDbType.Int).Value = MTV;
                        comand.Parameters.Add("@MHD", SqlDbType.Int).Value = MHD;
                        comand.Parameters.Add("@NXuat", SqlDbType.DateTime).Value = DateTime.Now;
                        comand.Parameters.Add("@NBan", SqlDbType.DateTime).Value = DateTime.Now;
                        comand.Parameters.Add("@TongTien", SqlDbType.Int).Value = tong;

                        comand.ExecuteNonQuery();


                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("ERROR" + E.Message);

                }
                finally
                {
                    mydb.closeConnection();
                }
            }
            else
            {


                try
                {

                    int row = dataGridView1.Rows.Count;
                    int tong = 0;
                    for (int i = 0; i < row - 1; i++)
                    {
                        tong += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                    for (int i = 0; i < row - 1; i++)
                    {
                        SqlCommand comand = new SqlCommand();
                        comand.CommandText = "INSERTBAN";
                        comand.CommandType = CommandType.StoredProcedure;
                        comand.Connection = mydb.getConnection;

                        comand.Parameters.Add("@flag", SqlDbType.Int).Value = i;

                        comand.Parameters.Add("@MS", SqlDbType.Int).Value = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        comand.Parameters.Add("@MANV", SqlDbType.Int).Value = 2001;
                        comand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                        comand.Parameters.Add("@MHD", SqlDbType.Int).Value = MHD;
                        comand.Parameters.Add("@NXuat", SqlDbType.DateTime).Value = DateTime.Now;
                        comand.Parameters.Add("@NBan", SqlDbType.DateTime).Value = DateTime.Now;
                        comand.Parameters.Add("@TongTien", SqlDbType.Int).Value = tong;

                        comand.Parameters.Add("@DXOA", SqlDbType.Bit).Value = false;

                        comand.ExecuteNonQuery();


                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("ERROR" + E.Message);

                }
                finally
                {
                    mydb.closeConnection();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }





        private void btnYes_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void btnNo_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }

        private void Banfrm_Load(object sender, EventArgs e)
        {
            label_name.Text = BaseData.Name;
            labelRole.Text = BaseData.role;
        }
    }
}
