using QLHangTonKho.Module;
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

namespace QLHangTonKho.views
{
    public partial class FrmOrder : Form
    {


        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;


        public FrmOrder()
        {
            InitializeComponent();
            LoadOrder();
        }


        public void LoadOrder()
        {
            int i = 0;
            dgvOrder.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbOrder", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dgvOrder.Rows.Add(i, reader[0].ToString(),Convert.ToDateTime(reader[1].ToString()).ToString("dd//MM/yyyy"), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());

            }
            reader.Close();
            conn.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderModuleForm orderModuleForm = new OrderModuleForm();
            orderModuleForm.btnOInsert.Enabled = true;
            orderModuleForm.btnOUpdate.Enabled = true;


            orderModuleForm.ShowDialog();
        }

        
    }
}
