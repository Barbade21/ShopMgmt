namespace ShopManagment
{
    partial class frmAddType
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
            this.lblAddType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAddType = new System.Windows.Forms.TextBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddType
            // 
            this.lblAddType.AutoSize = true;
            this.lblAddType.Location = new System.Drawing.Point(326, 58);
            this.lblAddType.Name = "lblAddType";
            this.lblAddType.Size = new System.Drawing.Size(67, 16);
            this.lblAddType.TabIndex = 0;
            this.lblAddType.Text = "Add Type";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(84, 126);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // txtAddType
            // 
            this.txtAddType.Location = new System.Drawing.Point(214, 120);
            this.txtAddType.Name = "txtAddType";
            this.txtAddType.Size = new System.Drawing.Size(274, 22);
            this.txtAddType.TabIndex = 2;
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(286, 209);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(135, 44);
            this.btnAddType.TabIndex = 3;
            this.btnAddType.Text = "Insert Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // frmAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.txtAddType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAddType);
            this.Name = "frmAddType";
            this.Text = "AddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAddType;
        private System.Windows.Forms.Button btnAddType;
    }
}