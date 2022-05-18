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
    public partial class Importfrm : Form
    {
        public Importfrm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Importfrm_Load(object sender, EventArgs e)
        {
            DB mydb = new DB();
            mydb.openconnection();
            SqlCommand command = new SqlCommand("Select * From NhaCungCap", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            command.ExecuteNonQuery();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DB mydb = new DB();
            mydb.openconnection();
            SqlCommand comand = new SqlCommand();
            comand.CommandText = "IMPORTSACH";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Connection = mydb.getConnection;
            try
            {
                comand.Parameters.Add("@MS", SqlDbType.Int).Value = int.Parse(txtMS.Text);
                comand.Parameters.Add("@TS", SqlDbType.NVarChar).Value = txtTS.Text;
                comand.Parameters.Add("@DG", SqlDbType.Int).Value = int.Parse(txtDGB.Text);
                comand.Parameters.Add("@NN", SqlDbType.DateTime).Value = DateTime.Now;
                comand.Parameters.Add("@MTL", SqlDbType.Int).Value = int.Parse(txtTL.Text);
                comand.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txtSL.Text);
                comand.Parameters.Add("@MNQL", SqlDbType.Int).Value = 2001;
                comand.Parameters.Add("@MNCC", SqlDbType.Int).Value = int.Parse(txtMNCC.Text);
                comand.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = txtNXB.Text;

                comand.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR" + E.Message);

            }
        }
    }
}
