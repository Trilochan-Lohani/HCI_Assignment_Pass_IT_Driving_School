namespace Pass_IT_Driving_School
{
    partial class LogIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblLogIn = new Label();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            llblMessage = new Label();
            llblShowPassword = new Label();
            lchkBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(247, 217);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(338, 209);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(244, 29);
            txtUserName.TabIndex = 1;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(338, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 29);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(247, 259);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogIn.Location = new Point(391, 145);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(123, 47);
            lblLogIn.TabIndex = 4;
            lblLogIn.Text = "Log In";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Green;
            btnLogIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.Control;
            btnLogIn.Location = new Point(338, 366);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(78, 44);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pass_IT_Driving_School_Logo_removebg_preview;
            pictureBox1.Location = new Point(338, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 155);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // llblMessage
            // 
            llblMessage.AutoSize = true;
            llblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            llblMessage.Location = new Point(338, 331);
            llblMessage.Name = "llblMessage";
            llblMessage.Size = new Size(0, 21);
            llblMessage.TabIndex = 9;
            // 
            // llblShowPassword
            // 
            llblShowPassword.AutoSize = true;
            llblShowPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llblShowPassword.Location = new Point(338, 299);
            llblShowPassword.Name = "llblShowPassword";
            llblShowPassword.Size = new Size(130, 21);
            llblShowPassword.TabIndex = 10;
            llblShowPassword.Text = "Show Password?";
            // 
            // lchkBox
            // 
            lchkBox.AutoSize = true;
            lchkBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lchkBox.Location = new Point(475, 303);
            lchkBox.Name = "lchkBox";
            lchkBox.Size = new Size(15, 14);
            lchkBox.TabIndex = 11;
            lchkBox.UseVisualStyleBackColor = true;
            lchkBox.CheckedChanged += lchkBox_CheckedChanged;
            // 
            // LogIn_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 209, 92);
            ClientSize = new Size(879, 460);
            Controls.Add(lchkBox);
            Controls.Add(llblShowPassword);
            Controls.Add(llblMessage);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogIn);
            Controls.Add(lblLogIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LogIn_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In Page";
            Load += Log_In_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblLogIn;
        private Button btnLogIn;
        private PictureBox pictureBox1;
        private Label llblMessage;
        private Label llblShowPassword;
        private CheckBox lchkBox;
    }
}