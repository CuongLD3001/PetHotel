namespace QuanLyShop
{
    partial class fRoomManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmPetCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.cbPet = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwitch = new System.Windows.Forms.ComboBox();
            this.btnSwitchPet = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPetCount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountInfoToolStripMenuItem
            // 
            this.accountInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
            this.accountInfoToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.accountInfoToolStripMenuItem.Text = "Account Info";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            this.personalInfoToolStripMenuItem.Click += new System.EventHandler(this.personalInfoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Location = new System.Drawing.Point(640, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 531);
            this.panel1.TabIndex = 1;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(0, -1);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(571, 527);
            this.lsvBill.TabIndex = 4;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pet\'s name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "count";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmPetCount);
            this.panel2.Controls.Add(this.btnAddPet);
            this.panel2.Controls.Add(this.cbPet);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Location = new System.Drawing.Point(640, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 87);
            this.panel2.TabIndex = 2;
            // 
            // nmPetCount
            // 
            this.nmPetCount.Location = new System.Drawing.Point(502, 29);
            this.nmPetCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmPetCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmPetCount.Name = "nmPetCount";
            this.nmPetCount.Size = new System.Drawing.Size(64, 27);
            this.nmPetCount.TabIndex = 3;
            this.nmPetCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(350, 7);
            this.btnAddPet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(152, 69);
            this.btnAddPet.TabIndex = 2;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // cbPet
            // 
            this.cbPet.FormattingEnabled = true;
            this.cbPet.Location = new System.Drawing.Point(3, 45);
            this.cbPet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(339, 28);
            this.cbPet.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 7);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(339, 28);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.cbSwitch);
            this.panel3.Controls.Add(this.btnSwitchPet);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Location = new System.Drawing.Point(640, 685);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 87);
            this.panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotalPrice.Location = new System.Drawing.Point(280, 23);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(126, 29);
            this.txbTotalPrice.TabIndex = 8;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSwitch
            // 
            this.cbSwitch.FormattingEnabled = true;
            this.cbSwitch.Location = new System.Drawing.Point(3, 47);
            this.cbSwitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Size = new System.Drawing.Size(126, 28);
            this.cbSwitch.TabIndex = 5;
            // 
            // btnSwitchPet
            // 
            this.btnSwitchPet.Location = new System.Drawing.Point(3, 8);
            this.btnSwitchPet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSwitchPet.Name = "btnSwitchPet";
            this.btnSwitchPet.Size = new System.Drawing.Size(127, 31);
            this.btnSwitchPet.TabIndex = 6;
            this.btnSwitchPet.Text = "Switch";
            this.btnSwitchPet.UseVisualStyleBackColor = true;
            this.btnSwitchPet.Click += new System.EventHandler(this.btnSwitchPet_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(137, 47);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(127, 27);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(137, 8);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(127, 31);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(414, 4);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(152, 69);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // flpRoom
            // 
            this.flpRoom.Location = new System.Drawing.Point(14, 52);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(619, 720);
            this.flpRoom.TabIndex = 4;
            // 
            // fRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 776);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fRoomManager";
            this.Text = "fShopManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmPetCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountInfoToolStripMenuItem;
        private ToolStripMenuItem personalInfoToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel1;
        private ListView lsvBill;
        private Panel panel2;
        private NumericUpDown nmPetCount;
        private Button btnAddPet;
        private ComboBox cbPet;
        private ComboBox cbCategory;
        private Panel panel3;
        private Button btnSwitchPet;
        private NumericUpDown nmDiscount;
        private Button btnDiscount;
        private Button btnCheckout;
        private FlowLayoutPanel flpRoom;
        private ComboBox cbSwitch;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
    }
}