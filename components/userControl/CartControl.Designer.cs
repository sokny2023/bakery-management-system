namespace bakery_management_system.components.userControl
{
    partial class CartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartControl));
            btnPay = new ButtonComponent1();
            pbProductImage = new PictureBox();
            lblProductPrice = new Label();
            lblProductName = new Label();
            lblQuantity = new Label();
            ptRemove = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptRemove).BeginInit();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(255, 101, 0);
            btnPay.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnPay.BorderColor = Color.PaleVioletRed;
            btnPay.BorderRadius = 10;
            btnPay.BorderSize = 0;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI Semibold", 12F);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(54, 351);
            btnPay.Name = "btnPay";
            btnPay.Padding = new Padding(15, 8, 15, 8);
            btnPay.Size = new Size(188, 50);
            btnPay.TabIndex = 7;
            btnPay.Text = "Add to cart";
            btnPay.TextColor = Color.White;
            btnPay.UseVisualStyleBackColor = false;
            // 
            // pbProductImage
            // 
            pbProductImage.Image = Properties.Resources.bakery1;
            pbProductImage.Location = new Point(39, 76);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(220, 145);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 6;
            pbProductImage.TabStop = false;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = Color.FromArgb(126, 96, 191);
            lblProductPrice.Location = new Point(97, 233);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(73, 31);
            lblProductPrice.TabIndex = 5;
            lblProductPrice.Text = "label1";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProductName.ForeColor = Color.FromArgb(255, 101, 0);
            lblProductName.Location = new Point(54, 15);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(86, 37);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "label1";
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.FromArgb(126, 96, 191);
            lblQuantity.Location = new Point(97, 285);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(73, 31);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "label1";
            // 
            // ptRemove
            // 
            ptRemove.Image = (Image)resources.GetObject("ptRemove.Image");
            ptRemove.Location = new Point(266, 3);
            ptRemove.Name = "ptRemove";
            ptRemove.Size = new Size(38, 35);
            ptRemove.SizeMode = PictureBoxSizeMode.Zoom;
            ptRemove.TabIndex = 9;
            ptRemove.TabStop = false;
            ptRemove.Click += ptRemove_Click;
            // 
            // CartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(ptRemove);
            Controls.Add(lblQuantity);
            Controls.Add(btnPay);
            Controls.Add(pbProductImage);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Margin = new Padding(20);
            Name = "CartControl";
            Size = new Size(307, 437);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptRemove).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ButtonComponent1 btnPay;
        private PictureBox pbProductImage;
        private Label lblProductPrice;
        private Label lblProductName;
        private Label lblQuantity;
        private PictureBox ptRemove;
    }
}
