namespace ShopManagment
{
    partial class frmLogin
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
            this.btnLClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cmbbxLType = new System.Windows.Forms.ComboBox();
            this.txtLUPass = new System.Windows.Forms.TextBox();
            this.txtLUName = new System.Windows.Forms.TextBox();
            this.lblLPass = new System.Windows.Forms.Label();
            this.lblLUName = new System.Windows.Forms.Label();
            this.lblLType = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLClear
            // 
            this.btnLClear.Location = new System.Drawing.Point(525, 353);
            this.btnLClear.Name = "btnLClear";
            this.btnLClear.Size = new System.Drawing.Size(138, 47);
            this.btnLClear.TabIndex = 24;
            this.btnLClear.Text = "Clear";
            this.btnLClear.UseVisualStyleBackColor = true;
            this.btnLClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(313, 353);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 47);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbbxLType
            // 
            this.cmbbxLType.FormattingEnabled = true;
            this.cmbbxLType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbbxLType.Location = new System.Drawing.Point(339, 110);
            this.cmbbxLType.Name = "cmbbxLType";
            this.cmbbxLType.Size = new System.Drawing.Size(256, 24);
            this.cmbbxLType.TabIndex = 22;
            // 
            // txtLUPass
            // 
            this.txtLUPass.Location = new System.Drawing.Point(339, 249);
            this.txtLUPass.Name = "txtLUPass";
            this.txtLUPass.Size = new System.Drawing.Size(256, 22);
            this.txtLUPass.TabIndex = 21;
            this.txtLUPass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLUName
            // 
            this.txtLUName.Location = new System.Drawing.Point(339, 175);
            this.txtLUName.Name = "txtLUName";
            this.txtLUName.Size = new System.Drawing.Size(256, 22);
            this.txtLUName.TabIndex = 20;
            // 
            // lblLPass
            // 
            this.lblLPass.AutoSize = true;
            this.lblLPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPass.Location = new System.Drawing.Point(152, 249);
            this.lblLPass.Name = "lblLPass";
            this.lblLPass.Size = new System.Drawing.Size(83, 20);
            this.lblLPass.TabIndex = 19;
            this.lblLPass.Text = "Password";
            this.lblLPass.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblLUName
            // 
            this.lblLUName.AutoSize = true;
            this.lblLUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLUName.Location = new System.Drawing.Point(152, 178);
            this.lblLUName.Name = "lblLUName";
            this.lblLUName.Size = new System.Drawing.Size(161, 20);
            this.lblLUName.TabIndex = 18;
            this.lblLUName.Text = "Email or User Name";
            // 
            // lblLType
            // 
            this.lblLType.AutoSize = true;
            this.lblLType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLType.Location = new System.Drawing.Point(152, 110);
            this.lblLType.Name = "lblLType";
            this.lblLType.Size = new System.Drawing.Size(45, 20);
            this.lblLType.TabIndex = 17;
            this.lblLType.Text = "Type";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(364, 28);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 25);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.btnLClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbbxLType);
            this.Controls.Add(this.txtLUPass);
            this.Controls.Add(this.txtLUName);
            this.Controls.Add(this.lblLPass);
            this.Controls.Add(this.lblLUName);
            this.Controls.Add(this.lblLType);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbbxLType;
        private System.Windows.Forms.TextBox txtLUPass;
        private System.Windows.Forms.TextBox txtLUName;
        private System.Windows.Forms.Label lblLPass;
        private System.Windows.Forms.Label lblLUName;
        private System.Windows.Forms.Label lblLType;
        private System.Windows.Forms.Label lblLogin;
    }
}