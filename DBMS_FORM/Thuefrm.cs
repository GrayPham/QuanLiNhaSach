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
    public partial class Thuefrm : Form
    {
        public Thuefrm()
        {
            InitializeComponent();

        }

        


        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DB mydb = new DB();
                mydb.openconnection();
                int MS = int.Parse(textBox3.Text);
                int MTV = int.Parse(textBox2.Text);
                int Soluong = int.Parse(textBox4.Text);
                SqlCommand command = new SqlCommand("Select MaSach, TenSach, DonGia FROM Sach Where MaSach =" + MS, mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);
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
                        if (flag1 == 1)
                        {
                            if (flag2 == 1)
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    dataGridView1.Rows.Add(reader["MaSach"].ToString(), reader["TenSach"].ToString(), reader["DonGia"].ToString(), textBox4.Text, dateMuon.Text, dateTra.Text);
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
                            MessageBox.Show("Da Muon Sach Nay Roi!", "MS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void btnPrintf_Click(object sender, EventArgs ERROR)
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

            int row = dataGridView1.Rows.Count;
            int tong = 0;
            for (int i = 0; i < row - 1; i++)
            {
                tong += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            for (int i = 0; i < row - 1; i++)
            {

                SqlCommand comand = new SqlCommand();
                comand.CommandText = "InsertMuon";
                comand.CommandType = CommandType.StoredProcedure;
                comand.Connection = mydb.getConnection;

                try
                {
                    comand.Parameters.Add("@flag", SqlDbType.Int).Value = i;
                    comand.Parameters.Add("@MATV", SqlDbType.Int).Value = int.Parse(textBox2.Text);
                    comand.Parameters.Add("@MS", SqlDbType.Int).Value = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    comand.Parameters.Add("@MANV", SqlDbType.Int).Value = BaseData.idUser;
                    comand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    comand.Parameters.Add("@NMuon", SqlDbType.DateTime).Value = dateMuon.Value;
                    comand.Parameters.Add("@NTra", SqlDbType.DateTime).Value = dateTra.Value;
                    comand.Parameters.Add("@MHD", SqlDbType.Int).Value = MHD;
                    comand.Parameters.Add("@NXuat", SqlDbType.DateTime).Value = dateMuon.Value;
                    comand.Parameters.Add("@TongTien", SqlDbType.Int).Value = tong;
                    comand.Parameters.Add("@GiamGia", SqlDbType.Int).Value = 0;
                    comand.Parameters.Add("@DXOA", SqlDbType.Bit).Value = false;
                    comand.Parameters.Add("@ThanhVien", SqlDbType.Bit).Value = false;

                    comand.ExecuteNonQuery();
                    MessageBox.Show("Invoice successful", "Information");

                }
                catch (Exception E)
                {
                    MessageBox.Show("ERROR" + E.Message);

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

        private void Thuefrm_Load_1(object sender, EventArgs e)
        {
            label_name.Text = BaseData.Name;
            labelRole.Text = BaseData.role;
        }
    }
}
