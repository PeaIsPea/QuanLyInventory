using QLHangTonKho.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHangTonKho
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }



        /*Làm hiện ứng hover cho các button*/
        private void btnProducts_MouseHover(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.White;
            btnProducts.ForeColor = Color.Black;

            toolTip.SetToolTip(btnProducts, "Open List Products");

            
        }

        private void btnProducts_MouseLeave(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.Red;
            btnProducts.ForeColor = Color.White;
        }

        private void btnCustomers_MouseHover(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.White;
            btnCustomers.ForeColor = Color.Black;

            toolTip.SetToolTip(btnCustomers, "Open List Customers");
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            btnCustomers.BackColor = Color.Red;
            btnCustomers.ForeColor = Color.White;
        }

        private void btnCategories_MouseHover(object sender, EventArgs e)
        {
            btnCategories.BackColor = Color.White;
            btnCategories.ForeColor = Color.Black;

            toolTip.SetToolTip(btnCategories, "Open List Categories");
        }

        private void btnCategories_MouseLeave(object sender, EventArgs e)
        {
            btnCategories.BackColor = Color.Red;
            btnCategories.ForeColor = Color.White;
        }

        private void btnUsers_MouseHover(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.White;
            btnUsers.ForeColor = Color.Black;

            toolTip.SetToolTip(btnUsers, "Open List Users");
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.Red;
            btnUsers.ForeColor = Color.White;
        }

        private void btnOrders_MouseHover(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.White;
            btnOrders.ForeColor = Color.Black;

            toolTip.SetToolTip(btnOrders, "Open List Orders");
        }

        private void btnOrders_MouseLeave(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.Red;
            btnOrders.ForeColor = Color.White;
        }

        /*-----------------------------------------------------------------------------*/




        /*Tạo hàm để hiển thị form con lên form chính----------------------------------*/

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close(); 
                
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panMain.Controls.Add(childForm);
                panMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }


        /*----------------------------------------------------------------------------*/



        /*Nhấn buttonUsers sẽ hiển thị FormModuleUser con lên*/
        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsers());    
        }
        /*-----------------------------------------------------*/
    }
}
