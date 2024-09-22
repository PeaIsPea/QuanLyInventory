namespace QLHangTonKho
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 96);
            this.panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(26, 35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(58, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Red;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrders.Location = new System.Drawing.Point(814, 35);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(110, 40);
            this.btnOrders.TabIndex = 13;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.MouseLeave += new System.EventHandler(this.btnOrders_MouseLeave);
            this.btnOrders.MouseHover += new System.EventHandler(this.btnOrders_MouseHover);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Red;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsers.Location = new System.Drawing.Point(669, 35);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(110, 40);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnUsers_MouseLeave);
            this.btnUsers.MouseHover += new System.EventHandler(this.btnUsers_MouseHover);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Red;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCategories.Location = new System.Drawing.Point(521, 35);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(110, 40);
            this.btnCategories.TabIndex = 11;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.MouseLeave += new System.EventHandler(this.btnCategories_MouseLeave);
            this.btnCategories.MouseHover += new System.EventHandler(this.btnCategories_MouseHover);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Red;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.Location = new System.Drawing.Point(369, 35);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(110, 40);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.MouseLeave += new System.EventHandler(this.btnCustomers_MouseLeave);
            this.btnCustomers.MouseHover += new System.EventHandler(this.btnCustomers_MouseHover);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Red;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProducts.Location = new System.Drawing.Point(213, 35);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(110, 40);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.MouseLeave += new System.EventHandler(this.btnProducts_MouseLeave);
            this.btnProducts.MouseHover += new System.EventHandler(this.btnProducts_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inventory Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 24);
            this.panel2.TabIndex = 1;
            // 
            // panMain
            // 
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panMain.Location = new System.Drawing.Point(0, 96);
            this.panMain.Margin = new System.Windows.Forms.Padding(4);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(982, 483);
            this.panMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip toolTip;
    }
}