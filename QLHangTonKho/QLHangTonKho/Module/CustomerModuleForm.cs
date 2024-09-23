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
namespace QLHangTonKho.Module
{
    public partial class CustomerModuleForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        public CustomerModuleForm()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbCustomers(cname,cphone)VALUES(@cname,@cphone)", conn);
                    cmd.Parameters.AddWithValue("@cname", txtNameCus.Text);
                    cmd.Parameters.AddWithValue("@cphone", txtPhoneCus.Text);
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been successfully saved");
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
            txtNameCus.Clear();
            txtPhoneCus.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtNameCus.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to update this customer?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbCustomers SET cname=@cname,cphone=@cphone WHERE cId LIKE '" + lblIDCus.Text + "' ", conn);
                    cmd.Parameters.AddWithValue("@cname", txtNameCus.Text);
                    cmd.Parameters.AddWithValue("@cphone", txtPhoneCus.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been successfully updated");
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
