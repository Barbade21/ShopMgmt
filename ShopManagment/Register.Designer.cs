namespace ShopManagment
{
    partial class frmRegister
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
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblRName = new System.Windows.Forms.Label();
            this.lblREmail = new System.Windows.Forms.Label();
            this.lblRGender = new System.Windows.Forms.Label();
            this.lblRState = new System.Windows.Forms.Label();
            this.lblRPass = new System.Windows.Forms.Label();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.cmbbxRType = new System.Windows.Forms.ComboBox();
            this.cmbbxRState = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(219, 16);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(130, 16);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "Ragistration Form";
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRType.Location = new System.Drawing.Point(59, 66);
            this.lblRType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(45, 20);
            this.lblRType.TabIndex = 1;
            this.lblRType.Text = "Type";
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRName.Location = new System.Drawing.Point(59, 104);
            this.lblRName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(53, 20);
            this.lblRName.TabIndex = 2;
            this.lblRName.Text = "Name";
            // 
            // lblREmail
            // 
            this.lblREmail.AutoSize = true;
            this.lblREmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREmail.Location = new System.Drawing.Point(59, 145);
            this.lblREmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblREmail.Name = "lblREmail";
            this.lblREmail.Size = new System.Drawing.Size(51, 20);
            this.lblREmail.TabIndex = 3;
            this.lblREmail.Text = "Email";
            // 
            // lblRGender
            // 
            this.lblRGender.AutoSize = true;
            this.lblRGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGender.Location = new System.Drawing.Point(59, 186);
            this.lblRGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRGender.Name = "lblRGender";
            this.lblRGender.Size = new System.Drawing.Size(64, 20);
            this.lblRGender.TabIndex = 4;
            this.lblRGender.Text = "Gender";
            // 
            // lblRState
            // 
            this.lblRState.AutoSize = true;
            this.lblRState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRState.Location = new System.Drawing.Point(59, 228);
            this.lblRState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRState.Name = "lblRState";
            this.lblRState.Size = new System.Drawing.Size(48, 20);
            this.lblRState.TabIndex = 5;
            this.lblRState.Text = "State";
            // 
            // lblRPass
            // 
            this.lblRPass.AutoSize = true;
            this.lblRPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPass.Location = new System.Drawing.Point(59, 262);
            this.lblRPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRPass.Name = "lblRPass";
            this.lblRPass.Size = new System.Drawing.Size(83, 20);
            this.lblRPass.TabIndex = 6;
            this.lblRPass.Text = "Password";
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(154, 102);
            this.txtRName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(155, 22);
            this.txtRName.TabIndex = 7;
            this.txtRName.TextChanged += new System.EventHandler(this.txtRName_TextChanged);
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(154, 139);
            this.txtREmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(155, 22);
            this.txtREmail.TabIndex = 8;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(154, 257);
            this.txtRPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.PasswordChar = '*';
            this.txtRPass.Size = new System.Drawing.Size(155, 22);
            this.txtRPass.TabIndex = 9;
            this.txtRPass.UseSystemPasswordChar = true;
            // 
            // cmbbxRType
            // 
            this.cmbbxRType.FormattingEnabled = true;
            this.cmbbxRType.ItemHeight = 16;
            this.cmbbxRType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbbxRType.Location = new System.Drawing.Point(154, 66);
            this.cmbbxRType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxRType.Name = "cmbbxRType";
            this.cmbbxRType.Size = new System.Drawing.Size(155, 24);
            this.cmbbxRType.TabIndex = 10;
            // 
            // cmbbxRState
            // 
            this.cmbbxRState.FormattingEnabled = true;
            this.cmbbxRState.Items.AddRange(new object[] {
            "Maharashtra",
            "Delhi",
            "Andhra Pradesh",
            "Madhya Pradesh",
            "TamilNadu"});
            this.cmbbxRState.Location = new System.Drawing.Point(154, 222);
            this.cmbbxRState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxRState.Name = "cmbbxRState";
            this.cmbbxRState.Size = new System.Drawing.Size(155, 24);
            this.cmbbxRState.TabIndex = 11;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(155, 184);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(66, 24);
            this.rdoMale.TabIndex = 12;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(239, 183);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(85, 24);
            this.rdoFemale.TabIndex = 13;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(675, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.cmbbxRState);
            this.Controls.Add(this.cmbbxRType);
            this.Controls.Add(this.txtRPass);
            this.Controls.Add(this.txtREmail);
            this.Controls.Add(this.txtRName);
            this.Controls.Add(this.lblRPass);
            this.Controls.Add(this.lblRState);
            this.Controls.Add(this.lblRGender);
            this.Controls.Add(this.lblREmail);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.lblRegistration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.Label lblREmail;
        private System.Windows.Forms.Label lblRGender;
        private System.Windows.Forms.Label lblRState;
        private System.Windows.Forms.Label lblRPass;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.TextBox txtREmail;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.ComboBox cmbbxRType;
        private System.Windows.Forms.ComboBox cmbbxRState;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}