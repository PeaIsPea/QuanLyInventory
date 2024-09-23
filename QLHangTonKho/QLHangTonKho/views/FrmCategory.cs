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

using QLHangTonKho.Module;

namespace QLHangTonKho.views
{
    public partial class FrmCategory : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public FrmCategory()
        {
            InitializeComponent();
            LoadCategory();
        }


        public void LoadCategory()
        {
            int i = 0;
            dgvCate.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCategories", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dgvCate.Rows.Add(i, reader[0].ToString(), reader[1].ToString());

            }
            reader.Close();
            conn.Close();

        }/*------------------------------------------------------------------------------------*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModuleForm cateModuleForm = new CategoryModuleForm();
            cateModuleForm.btnSave.Enabled = true;
            cateModuleForm.btnUpdate.Enabled = false;
            cateModuleForm.ShowDialog();
            LoadCategory();
        }

        private void dgvCate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCate.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm cateModule = new CategoryModuleForm();
                cateModule.lblIDCate.Text = dgvCate.Rows[e.RowIndex].Cells[1].Value.ToString();
                cateModule.txtNameCate.Text = dgvCate.Rows[e.RowIndex].Cells[2].Value.ToString();
                


                cateModule.btnSave.Enabled = false;
                cateModule.btnUpdate.Enabled = true;

                cateModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are u sure u want to delete this category?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tbCategories WHERE CateID LIKE '" + dgvCate.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                }
            }
            LoadCategory();
        }
    }
}
