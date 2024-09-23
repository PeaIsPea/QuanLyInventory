using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLHangTonKho.Module;

namespace QLHangTonKho.views
{


    
    public partial class FrmCustomers : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public FrmCustomers()
        {
            InitializeComponent();
            LoadCustomers();
        }


        /*Viết hàm loadCustomers-----------------------------------------------------------------*/

        public void LoadCustomers()
        {
            int i = 0;
            dgvCustomers.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCustomers", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dgvCustomers.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString());

            }
            reader.Close();
            conn.Close();

        }/*------------------------------------------------------------------------------------*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerModuleForm cusModuleForm = new CustomerModuleForm();
            cusModuleForm.btnSave.Enabled = true;
            cusModuleForm.btnUpdate.Enabled = false;
            cusModuleForm.ShowDialog();
            LoadCustomers();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModuleForm cusModule = new CustomerModuleForm();
                cusModule.lblIDCus.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                cusModule.txtNameCus.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                cusModule.txtPhoneCus.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();


                cusModule.btnSave.Enabled = false;
                cusModule.btnUpdate.Enabled = true;
                
                cusModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are u sure u want to delete this customer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tbCustomers WHERE cId LIKE '" + dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                }
            }
            LoadCustomers();
        }
    }
}
