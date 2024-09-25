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
    public partial class ProductModuleForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCategory()
        {
            cbCate.Items.Clear();
            cmd = new SqlCommand("SELECT CateName FROM tbCategories", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbCate.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
            

        }

        private void btnSavePro_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure you want to save this product?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbProducts(pname,pqty,pprice,pdes,pcate)VALUES(@pname,@pqty,@pprice,@pdes,@pcate)", conn);
                    cmd.Parameters.AddWithValue("@pname", txtProName.Text);
                    cmd.Parameters.AddWithValue("@pqty", int.Parse(txtQuan.Text));
                    cmd.Parameters.AddWithValue("@pprice", int.Parse( txtPrice.Text));
                    cmd.Parameters.AddWithValue("@pdes", txtDes.Text);
                    cmd.Parameters.AddWithValue("@pcate", cbCate.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully saved");
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
            txtProName.Clear();
            txtQuan.Clear();
            txtPrice.Clear();
            txtDes.Clear();
            cbCate.Items.Clear();
            txtProName.Focus();
        }

        private void btnClearPro_Click(object sender, EventArgs e)
        {
            Clear();
            btnSavePro.Enabled = true;
            btnUpdatePro.Enabled = false;
        }

        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure you want to update this product?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbProducts SET pname=@pname,pqty=@pqty,pprice=@pprice,pdes=@pdes,pcate=@pcate WHERE pId LIKE '" + lblIDPro.Text + "'", conn);
                    cmd.Parameters.AddWithValue("@pname", txtProName.Text);
                    cmd.Parameters.AddWithValue("@pqty", int.Parse(txtQuan.Text));
                    cmd.Parameters.AddWithValue("@pprice", int.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@pdes", txtDes.Text);
                    cmd.Parameters.AddWithValue("@pcate", cbCate.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully updated");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
