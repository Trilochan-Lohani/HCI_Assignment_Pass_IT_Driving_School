namespace Pass_IT_Driving_School
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnSignUp = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtConformPassword = new TextBox();
            lblConformPassword = new Label();
            lblSignUp = new Label();
            lblMessage = new Label();
            pictureBox1 = new PictureBox();
            chkPassword = new CheckBox();
            lblShowPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(145, 211);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(303, 209);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 29);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Green;
            btnSignUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(303, 407);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(86, 36);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Add";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(303, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 29);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(145, 251);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Passsword";
            // 
            // txtConformPassword
            // 
            txtConformPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConformPassword.Location = new Point(303, 289);
            txtConformPassword.Name = "txtConformPassword";
            txtConformPassword.Size = new Size(237, 29);
            txtConformPassword.TabIndex = 2;
            // 
            // lblConformPassword
            // 
            lblConformPassword.AutoSize = true;
            lblConformPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConformPassword.Location = new Point(145, 291);
            lblConformPassword.Name = "lblConformPassword";
            lblConformPassword.Size = new Size(148, 21);
            lblConformPassword.TabIndex = 6;
            lblConformPassword.Text = "Conform Password";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.Location = new Point(326, 148);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(159, 45);
            lblSignUp.TabIndex = 8;
            lblSignUp.Text = "Add User";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(303, 372);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pass_IT_Driving_School_Logo_removebg_preview;
            pictureBox1.Location = new Point(273, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 153);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkPassword.Location = new Point(439, 336);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(15, 14);
            chkPassword.TabIndex = 12;
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // lblShowPassword
            // 
            lblShowPassword.AutoSize = true;
            lblShowPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowPassword.Location = new Point(303, 330);
            lblShowPassword.Name = "lblShowPassword";
            lblShowPassword.Size = new Size(130, 21);
            lblShowPassword.TabIndex = 13;
            lblShowPassword.Text = "Show Password?";
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 209, 92);
            ClientSize = new Size(831, 495);
            Controls.Add(lblShowPassword);
            Controls.Add(chkPassword);
            Controls.Add(pictureBox1);
            Controls.Add(lblMessage);
            Controls.Add(lblSignUp);
            Controls.Add(txtConformPassword);
            Controls.Add(lblConformPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnSignUp);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Registration_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            Load += Registration_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnSignUp;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConformPassword;
        private Label lblConformPassword;
        private Label lblSignUp;
        private Label lblMessage;
        private PictureBox pictureBox1;
        private CheckBox chkPassword;
        private Label lblShowPassword;
    }
}