namespace bakery_management_system.Views
{
    partial class CategoryForm
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
            tableLayoutPanel3 = new TableLayoutPanel();
            panelComponent11 = new components.PanelComponent1();
            flowLayoutPanelCategories = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1395, 716);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 710);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panelComponent11, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1169, 710);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panelComponent11
            // 
            panelComponent11.BackColor = Color.White;
            panelComponent11.Controls.Add(flowLayoutPanelCategories);
            panelComponent11.Dock = DockStyle.Fill;
            panelComponent11.Location = new Point(3, 88);
            panelComponent11.Name = "panelComponent11";
            panelComponent11.Size = new Size(1163, 619);
            panelComponent11.TabIndex = 0;
            // 
            // flowLayoutPanelCategories
            // 
            flowLayoutPanelCategories.AutoScroll = true;
            flowLayoutPanelCategories.Dock = DockStyle.Fill;
            flowLayoutPanelCategories.Location = new Point(0, 0);
            flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            flowLayoutPanelCategories.Size = new Size(1163, 619);
            flowLayoutPanelCategories.TabIndex = 0;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 716);
            Controls.Add(tableLayoutPanel1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panelComponent11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private components.PanelComponent1 panelComponent11;
        private FlowLayoutPanel flowLayoutPanelCategories;
    }
}