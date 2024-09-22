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
    public partial class UserModuleForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbUsers(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", conn);
                    cmd.Parameters.AddWithValue("@username",txtUserName.Text);
                    cmd.Parameters.AddWithValue("@fullname",txtFullName.Text);
                    cmd.Parameters.AddWithValue("@password",txtPassword.Text);
                    cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been successfully saved");
                    Clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtUserName.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUserName.Focus();

        }
    }
}
