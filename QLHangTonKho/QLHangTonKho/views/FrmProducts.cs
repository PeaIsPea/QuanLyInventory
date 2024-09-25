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
    public partial class FrmProducts : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public FrmProducts()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductModuleForm proModuleForm = new ProductModuleForm();
            proModuleForm.btnSavePro.Enabled = true;
            proModuleForm.btnUpdatePro.Enabled = false;
            proModuleForm.ShowDialog();
            LoadProduct();
           
        }


        public void LoadProduct()
        {
            int i = 0;
            dgvPro.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbProducts WHERE CONCAT(pId, pname, pprice, pdes, pcate) LIKE '%"+txtSearch.Text+"%'", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dgvPro.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

            }
            reader.Close();
            conn.Close();

        }/*------------------------------------------------------------------------------------*/

        private void dgvPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPro.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm proModule = new ProductModuleForm();
                proModule.lblIDPro.Text = dgvPro.Rows[e.RowIndex].Cells[1].Value.ToString();

                proModule.txtProName.Text = dgvPro.Rows[e.RowIndex].Cells[2].Value.ToString();
                proModule.txtQuan.Text = dgvPro.Rows[e.RowIndex].Cells[3].Value.ToString();
                proModule.txtPrice.Text = dgvPro.Rows[e.RowIndex].Cells[4].Value.ToString();
                proModule.txtDes.Text = dgvPro.Rows[e.RowIndex].Cells[5].Value.ToString();
                proModule.cbCate.Text = dgvPro.Rows[e.RowIndex].Cells[6].Value.ToString();

                proModule.btnSavePro.Enabled = false;
                proModule.btnUpdatePro.Enabled = true;
                
                proModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are u sure u want to delete this produtc?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tbProducts WHERE pId LIKE '" + dgvPro.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
