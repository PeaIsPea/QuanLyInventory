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
    public partial class FrmUsers : Form
    {
        /*Tạo kết nối đến cơ sở dữ liệu và Load lên FormUsers*/

            /*Đây là tạo kết nối---------*/


        SqlConnection conn = new SqlConnection(@"Data Source=BEDAU\SQLEXPRESS;Initial Catalog=QLHANG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

            /*---------------------------*/
        public FrmUsers()
        {
            InitializeComponent();

            //gọi hàm load
            LoadUser();
        }



        /*Viết hàm loadUser-----------------------------------------------------------------*/

        public void LoadUser()
        {
            int i = 0;
            dgvUsers.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbUsers",conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                i++;
                dgvUsers.Rows.Add(i,reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());

            }
            reader.Close();
            conn.Close();

        }/*------------------------------------------------------------------------------------*/


        /*Xử lý sự kiện khi nhấn button thêm users*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModuleForm = new UserModuleForm();
            userModuleForm.btnSave.Enabled = true;
            userModuleForm.btnUpdate.Enabled = false;
            userModuleForm.ShowDialog();
        }
        /*---------------------------------------------*/


        
    }
}
