namespace bakery_management_system.Views
{
    partial class MyPaymentForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            logoutButton1 = new components.LogoutButton();
            panel2 = new Panel();
            btnMyOrders = new components.ButtonSidebar1();
            btnProducts = new components.ButtonSidebar();
            btnMyPayments = new components.ButtonSidebar1();
            btnCategories = new components.ButtonSidebar1();
            pbLogo = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelComponent11 = new components.PanelComponent1();
            flpInvoices = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panelComponent11.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1469, 820);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 814);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(logoutButton1);
            panel1.Location = new Point(3, 667);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 144);
            panel1.TabIndex = 0;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BackgroundColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BorderColor = Color.PaleVioletRed;
            logoutButton1.BorderRadius = 10;
            logoutButton1.BorderSize = 0;
            logoutButton1.FlatAppearance.BorderSize = 0;
            logoutButton1.FlatStyle = FlatStyle.Flat;
            logoutButton1.Font = new Font("Segoe UI Semibold", 12F);
            logoutButton1.ForeColor = Color.White;
            logoutButton1.Location = new Point(43, 0);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 2;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMyOrders);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnMyPayments);
            panel2.Controls.Add(btnCategories);
            panel2.Controls.Add(pbLogo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 658);
            panel2.TabIndex = 1;
            // 
            // btnMyOrders
            // 
            btnMyOrders.BackColor = SystemColors.Control;
            btnMyOrders.BackgroundColor = SystemColors.Control;
            btnMyOrders.BorderColor = Color.PaleVioletRed;
            btnMyOrders.BorderRadius = 10;
            btnMyOrders.BorderSize = 0;
            btnMyOrders.FlatAppearance.BorderSize = 0;
            btnMyOrders.FlatStyle = FlatStyle.Flat;
            btnMyOrders.Font = new Font("Segoe UI Semibold", 12F);
            btnMyOrders.ForeColor = Color.Black;
            btnMyOrders.Location = new Point(9, 250);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Padding = new Padding(15, 5, 30, 5);
            btnMyOrders.Size = new Size(188, 50);
            btnMyOrders.TabIndex = 11;
            btnMyOrders.Text = "Carts";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.TextColor = Color.Black;
            btnMyOrders.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(255, 101, 0);
            btnProducts.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(9, 306);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(189, 50);
            btnProducts.TabIndex = 9;
            btnProducts.Text = "Payments";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextColor = Color.White;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnMyPayments
            // 
            btnMyPayments.BackColor = SystemColors.Control;
            btnMyPayments.BackgroundColor = SystemColors.Control;
            btnMyPayments.BorderColor = Color.PaleVioletRed;
            btnMyPayments.BorderRadius = 10;
            btnMyPayments.BorderSize = 0;
            btnMyPayments.FlatAppearance.BorderSize = 0;
            btnMyPayments.FlatStyle = FlatStyle.Flat;
            btnMyPayments.Font = new Font("Segoe UI Semibold", 12F);
            btnMyPayments.ForeColor = Color.Black;
            btnMyPayments.Location = new Point(10, 138);
            btnMyPayments.Name = "btnMyPayments";
            btnMyPayments.Padding = new Padding(15, 5, 30, 5);
            btnMyPayments.Size = new Size(188, 50);
            btnMyPayments.TabIndex = 12;
            btnMyPayments.Text = "Products";
            btnMyPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnMyPayments.TextColor = Color.Black;
            btnMyPayments.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.Control;
            btnCategories.BackgroundColor = SystemColors.Control;
            btnCategories.BorderColor = Color.PaleVioletRed;
            btnCategories.BorderRadius = 10;
            btnCategories.BorderSize = 0;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 12F);
            btnCategories.ForeColor = Color.Black;
            btnCategories.Location = new Point(10, 194);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 5, 30, 5);
            btnCategories.Size = new Size(188, 50);
            btnCategories.TabIndex = 10;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextColor = Color.Black;
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(19, 6);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(panelComponent11, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1243, 814);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panelComponent11
            // 
            panelComponent11.BackColor = Color.White;
            panelComponent11.Controls.Add(flpInvoices);
            panelComponent11.Dock = DockStyle.Fill;
            panelComponent11.Location = new Point(20, 105);
            panelComponent11.Margin = new Padding(20);
            panelComponent11.Name = "panelComponent11";
            panelComponent11.Size = new Size(1203, 689);
            panelComponent11.TabIndex = 0;
            // 
            // flpInvoices
            // 
            flpInvoices.Dock = DockStyle.Fill;
            flpInvoices.Location = new Point(0, 0);
            flpInvoices.Margin = new Padding(30);
            flpInvoices.Name = "flpInvoices";
            flpInvoices.Size = new Size(1203, 689);
            flpInvoices.TabIndex = 0;
            // 
            // MyPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 820);
            Controls.Add(tableLayoutPanel1);
            Name = "MyPaymentForm";
            Text = "MyPaymentForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panelComponent11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private components.LogoutButton logoutButton1;
        private Panel panel2;
        private components.ButtonSidebar1 btnMyOrders;
        private components.ButtonSidebar btnProducts;
        private components.ButtonSidebar1 btnMyPayments;
        private components.ButtonSidebar1 btnCategories;
        private PictureBox pbLogo;
        private TableLayoutPanel tableLayoutPanel3;
        private components.PanelComponent1 panelComponent11;
        private FlowLayoutPanel flpInvoices;
    }
}