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

namespace QLHangTonKho.Module
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        


        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProduct();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }


        public void LoadCustomers()
        {
            int i = 0;
            dgvCustomers.Rows.Clear();
            cmd = new SqlCommand("SELECT cId, cname FROM tbCustomers WHERE CONCAT(cId, cname) LIKE '%"+txtSearchCus.Text+"%'", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dgvCustomers.Rows.Add(i, reader[0].ToString(), reader[1].ToString());

            }
            reader.Close();
            conn.Close();

        }

        public void LoadProduct()
        {
            int i = 0;
            dgvPro.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbProducts WHERE CONCAT(pId, pname, pprice, pdes, pcate) LIKE '%" + txtSearchPro.Text + "%'", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dgvPro.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

            }
            reader.Close();
            conn.Close();

        }

        private void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtSearchPro_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        int qty = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToInt16(numberQty.Value)>qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberQty.Value = numberQty.Value - 1;
                return;
            }

            int total = int.Parse(txtPrice.Text) * Convert.ToInt16(numberQty.Value);
            txtTotal.Text = total.ToString();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCus.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCusName.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPro.Text = dgvPro.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtProName.Text = dgvPro.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvPro.Rows[e.RowIndex].Cells[4].Value.ToString();
            qty = Convert.ToInt16(dgvPro.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnOInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDCus.Text == "")
                {
                    MessageBox.Show("Please select customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtIdPro.Text == "")
                {
                    MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to insert this order?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate,@pid,@cid,@qty,@price,@total)", conn);
                    cmd.Parameters.AddWithValue("@odate", dateOrder.Text);
                    cmd.Parameters.AddWithValue("@pid", Convert.ToInt16(txtIdPro.Text));
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt16(txtIDCus.Text));
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt16(numberQty.Value));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt16(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt16(txtTotal.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Order has been successfully Inserted");
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtIdPro.Clear();
            txtIDCus.Clear();

            txtCusName.Clear();
            txtPrice.Clear();

            txtTotal.Clear();
            numberQty.Value = 1;

            txtProName.Clear();
            dateOrder.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
