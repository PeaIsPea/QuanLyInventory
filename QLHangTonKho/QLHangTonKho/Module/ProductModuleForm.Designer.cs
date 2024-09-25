namespace QLHangTonKho.Module
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearPro = new System.Windows.Forms.Button();
            this.btnUpdatePro = new System.Windows.Forms.Button();
            this.btnSavePro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.lblIDPro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 44);
            this.panel1.TabIndex = 14;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(555, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(21, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 12;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Module";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(172, 260);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(377, 26);
            this.txtDes.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Description:";
            // 
            // btnClearPro
            // 
            this.btnClearPro.BackColor = System.Drawing.Color.Aqua;
            this.btnClearPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPro.Location = new System.Drawing.Point(450, 402);
            this.btnClearPro.Name = "btnClearPro";
            this.btnClearPro.Size = new System.Drawing.Size(99, 32);
            this.btnClearPro.TabIndex = 25;
            this.btnClearPro.Text = "Clear";
            this.btnClearPro.UseVisualStyleBackColor = false;
            this.btnClearPro.Click += new System.EventHandler(this.btnClearPro_Click);
            // 
            // btnUpdatePro
            // 
            this.btnUpdatePro.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdatePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePro.Location = new System.Drawing.Point(311, 402);
            this.btnUpdatePro.Name = "btnUpdatePro";
            this.btnUpdatePro.Size = new System.Drawing.Size(99, 32);
            this.btnUpdatePro.TabIndex = 24;
            this.btnUpdatePro.Text = "Update";
            this.btnUpdatePro.UseVisualStyleBackColor = false;
            this.btnUpdatePro.Click += new System.EventHandler(this.btnUpdatePro_Click);
            // 
            // btnSavePro
            // 
            this.btnSavePro.BackColor = System.Drawing.Color.Aqua;
            this.btnSavePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePro.Location = new System.Drawing.Point(172, 402);
            this.btnSavePro.Name = "btnSavePro";
            this.btnSavePro.Size = new System.Drawing.Size(99, 32);
            this.btnSavePro.TabIndex = 23;
            this.btnSavePro.Text = "Save";
            this.btnSavePro.UseVisualStyleBackColor = false;
            this.btnSavePro.Click += new System.EventHandler(this.btnSavePro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Catogory:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(172, 203);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(377, 26);
            this.txtPrice.TabIndex = 20;
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(172, 149);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(377, 26);
            this.txtQuan.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity:";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(172, 98);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(377, 26);
            this.txtProName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Name:";
            // 
            // cbCate
            // 
            this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(172, 306);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(238, 28);
            this.cbCate.TabIndex = 28;
            // 
            // lblIDPro
            // 
            this.lblIDPro.AutoSize = true;
            this.lblIDPro.Location = new System.Drawing.Point(143, 356);
            this.lblIDPro.Name = "lblIDPro";
            this.lblIDPro.Size = new System.Drawing.Size(25, 20);
            this.lblIDPro.TabIndex = 29;
            this.lblIDPro.Text = "ID";
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 461);
            this.Controls.Add(this.lblIDPro);
            this.Controls.Add(this.cbCate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClearPro);
            this.Controls.Add(this.btnUpdatePro);
            this.Controls.Add(this.btnSavePro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnClearPro;
        public System.Windows.Forms.Button btnUpdatePro;
        public System.Windows.Forms.Button btnSavePro;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbCate;
        public System.Windows.Forms.Label lblIDPro;
    }
}