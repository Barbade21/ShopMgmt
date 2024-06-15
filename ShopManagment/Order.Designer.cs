namespace ShopManagment
{
    partial class frmOrder
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
            this.grdPView = new System.Windows.Forms.DataGridView();
            this.cmbbxPName = new System.Windows.Forms.ComboBox();
            this.cmbbxPType = new System.Windows.Forms.ComboBox();
            this.btnPClear = new System.Windows.Forms.Button();
            this.btnPRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnRemoveCart = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnOrderConfirm = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lstView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPView)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPView
            // 
            this.grdPView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPView.Location = new System.Drawing.Point(207, 173);
            this.grdPView.Name = "grdPView";
            this.grdPView.RowHeadersWidth = 51;
            this.grdPView.RowTemplate.Height = 24;
            this.grdPView.Size = new System.Drawing.Size(308, 237);
            this.grdPView.TabIndex = 2;
            this.grdPView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPView_CellContentClick);
            // 
            // cmbbxPName
            // 
            this.cmbbxPName.FormattingEnabled = true;
            this.cmbbxPName.Location = new System.Drawing.Point(207, 118);
            this.cmbbxPName.Name = "cmbbxPName";
            this.cmbbxPName.Size = new System.Drawing.Size(308, 24);
            this.cmbbxPName.TabIndex = 25;
            this.cmbbxPName.SelectedIndexChanged += new System.EventHandler(this.cmbbxPName_SelectedIndexChanged);
            // 
            // cmbbxPType
            // 
            this.cmbbxPType.FormattingEnabled = true;
            this.cmbbxPType.Location = new System.Drawing.Point(207, 60);
            this.cmbbxPType.Name = "cmbbxPType";
            this.cmbbxPType.Size = new System.Drawing.Size(308, 24);
            this.cmbbxPType.TabIndex = 24;
            this.cmbbxPType.SelectedIndexChanged += new System.EventHandler(this.cmbbxPType_SelectedIndexChanged);
            // 
            // btnPClear
            // 
            this.btnPClear.Location = new System.Drawing.Point(303, 513);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(135, 43);
            this.btnPClear.TabIndex = 23;
            this.btnPClear.Text = "Clear";
            this.btnPClear.UseVisualStyleBackColor = true;
            this.btnPClear.Click += new System.EventHandler(this.btnPClear_Click);
            // 
            // btnPRegister
            // 
            this.btnPRegister.Location = new System.Drawing.Point(84, 513);
            this.btnPRegister.Name = "btnPRegister";
            this.btnPRegister.Size = new System.Drawing.Size(124, 43);
            this.btnPRegister.TabIndex = 22;
            this.btnPRegister.Text = "Logout";
            this.btnPRegister.UseVisualStyleBackColor = true;
            this.btnPRegister.Click += new System.EventHandler(this.btnPRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(207, 451);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(308, 22);
            this.txtPrice.TabIndex = 27;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(58, 457);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Price :";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(554, 239);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(106, 23);
            this.btnAddCart.TabIndex = 28;
            this.btnAddCart.Text = "Add To Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnRemoveCart
            // 
            this.btnRemoveCart.Location = new System.Drawing.Point(554, 316);
            this.btnRemoveCart.Name = "btnRemoveCart";
            this.btnRemoveCart.Size = new System.Drawing.Size(106, 45);
            this.btnRemoveCart.TabIndex = 29;
            this.btnRemoveCart.Text = "Remove from Cart";
            this.btnRemoveCart.UseVisualStyleBackColor = true;
            this.btnRemoveCart.Click += new System.EventHandler(this.btnRemoveCart_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(770, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(50, 16);
            this.Name.TabIndex = 30;
            this.Name.Text = "Name :";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(937, 33);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(44, 16);
            this.lblName1.TabIndex = 31;
            this.lblName1.Text = "Name";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(937, 91);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(47, 16);
            this.lblUserId.TabIndex = 33;
            this.lblUserId.Text = "UserId";
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(770, 91);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(53, 16);
            this.UserId.TabIndex = 32;
            this.UserId.Text = "UserId :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(937, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(770, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 16);
            this.Email.TabIndex = 34;
            this.Email.Text = "Email :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(911, 451);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(308, 22);
            this.txtTotal.TabIndex = 38;
            // 
            // btnOrderConfirm
            // 
            this.btnOrderConfirm.Location = new System.Drawing.Point(1070, 513);
            this.btnOrderConfirm.Name = "btnOrderConfirm";
            this.btnOrderConfirm.Size = new System.Drawing.Size(185, 31);
            this.btnOrderConfirm.TabIndex = 40;
            this.btnOrderConfirm.Text = "Order Confirm";
            this.btnOrderConfirm.UseVisualStyleBackColor = true;
            this.btnOrderConfirm.Click += new System.EventHandler(this.btnOrderConfirm_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(757, 444);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(124, 29);
            this.btnTotal.TabIndex = 39;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lstView2
            // 
            this.lstView2.HideSelection = false;
            this.lstView2.Location = new System.Drawing.Point(757, 199);
            this.lstView2.Name = "lstView2";
            this.lstView2.Size = new System.Drawing.Size(462, 211);
            this.lstView2.TabIndex = 41;
            this.lstView2.UseCompatibleStateImageBehavior = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1297, 578);
            this.Controls.Add(this.lstView2);
            this.Controls.Add(this.btnOrderConfirm);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.btnRemoveCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbbxPName);
            this.Controls.Add(this.cmbbxPType);
            this.Controls.Add(this.btnPClear);
            this.Controls.Add(this.btnPRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdPView);
//            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPView;
        private System.Windows.Forms.ComboBox cmbbxPName;
        private System.Windows.Forms.ComboBox cmbbxPType;
        private System.Windows.Forms.Button btnPClear;
        private System.Windows.Forms.Button btnPRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnRemoveCart;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnOrderConfirm;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ListView lstView2;
    }
}