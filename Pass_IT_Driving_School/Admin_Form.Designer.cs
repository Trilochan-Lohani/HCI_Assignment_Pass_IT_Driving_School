namespace Pass_IT_Driving_School
{
    partial class Admin_Form
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
            components = new System.ComponentModel.Container();
            ToolTip toolTipHome;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            gvStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            gvInstructor = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            cmbGender = new ComboBox();
            tabHome = new TabControl();
            tabAdmin = new TabPage();
            label9 = new Label();
            lblHomeAddress = new Label();
            richTextBox1 = new RichTextBox();
            btnEditInstructor = new Button();
            btnAddInstructor = new Button();
            btnEditStudent = new Button();
            btnRegisterStudent = new Button();
            btnAddAdmin = new Button();
            pictureBox1 = new PictureBox();
            lblSchoolName = new Label();
            lblWelcometext = new Label();
            tabStudentRegistration = new TabPage();
            btnProgressTrack = new Button();
            button1 = new Button();
            label12 = new Label();
            label10 = new Label();
            lblStudentMessage = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            cmbCourse = new ComboBox();
            lblCourseChoosen = new Label();
            cmbInstructor = new ComboBox();
            txtAddress = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblEnrollDate = new Label();
            lblInstructor = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            lblLastName = new Label();
            lblMiddleName = new Label();
            lblFirstName = new Label();
            tabStudentList = new TabPage();
            btnStudentSearch = new Button();
            txtStudentSearch = new TextBox();
            tabInstructorRegistration = new TabPage();
            label1 = new Label();
            lblMessage = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInstructorUpdate = new Button();
            btnInstructorClear = new Button();
            btnInstructorDelete = new Button();
            btnInstructorSave = new Button();
            cmbInstructorJobType = new ComboBox();
            txtInstructorMiddleName = new TextBox();
            txtInstructorLastName = new TextBox();
            txtInstructorAddress = new TextBox();
            txtInstructorPhoneNumber = new TextBox();
            txtInstructorFirstName = new TextBox();
            lblPhoneNumber = new Label();
            lblInstructorAddredd = new Label();
            lblInstructorJobType = new Label();
            lblInstructorLastName = new Label();
            lblInstructorMiddleName = new Label();
            lblInstructorFirstName = new Label();
            tabInstructorList = new TabPage();
            btnSearchInstructor = new Button();
            txtSearchInstructor = new TextBox();
            lblLogout = new LinkLabel();
            toolTipHome = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInstructor).BeginInit();
            tabHome.SuspendLayout();
            tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabStudentRegistration.SuspendLayout();
            tabStudentList.SuspendLayout();
            tabInstructorRegistration.SuspendLayout();
            tabInstructorList.SuspendLayout();
            SuspendLayout();
            // 
            // toolTipHome
            // 
            toolTipHome.BackColor = Color.FromArgb(191, 209, 92);
            toolTipHome.ForeColor = Color.Red;
            toolTipHome.ShowAlways = true;
            toolTipHome.ToolTipIcon = ToolTipIcon.Info;
            toolTipHome.ToolTipTitle = "Double click to Edit";
            // 
            // gvStudent
            // 
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5, Column7, Column8 });
            gvStudent.Location = new Point(7, 56);
            gvStudent.Name = "gvStudent";
            gvStudent.RowTemplate.Height = 25;
            gvStudent.Size = new Size(1228, 406);
            gvStudent.TabIndex = 2;
            toolTipHome.SetToolTip(gvStudent, ".");
            gvStudent.CellContentClick += gvStudent_CellContentClick;
            gvStudent.MouseDoubleClick += gvStudent_MouseDoubleClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 150F;
            Column1.HeaderText = "First Name";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Middle Name";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Last Name";
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gender";
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.FillWeight = 200F;
            Column6.HeaderText = "Address";
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column5
            // 
            Column5.FillWeight = 200F;
            Column5.HeaderText = "Instructor";
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column7
            // 
            Column7.FillWeight = 150F;
            Column7.HeaderText = "Enrolled Date";
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Course";
            Column8.Name = "Column8";
            // 
            // gvInstructor
            // 
            gvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInstructor.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12, Column13, Column14 });
            gvInstructor.Location = new Point(7, 69);
            gvInstructor.Name = "gvInstructor";
            gvInstructor.RowTemplate.Height = 25;
            gvInstructor.Size = new Size(1228, 432);
            gvInstructor.TabIndex = 2;
            toolTipHome.SetToolTip(gvInstructor, ".");
            gvInstructor.MouseDoubleClick += gvInstructor_MouseDoubleClick;
            // 
            // Column9
            // 
            Column9.FillWeight = 150F;
            Column9.HeaderText = "First Name";
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.FillWeight = 150F;
            Column10.HeaderText = "Middle Name";
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.FillWeight = 150F;
            Column11.HeaderText = "Last Name";
            Column11.Name = "Column11";
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.FillWeight = 150F;
            Column12.HeaderText = "Job Type";
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column13
            // 
            Column13.FillWeight = 400F;
            Column13.HeaderText = "Address";
            Column13.Name = "Column13";
            Column13.Width = 400;
            // 
            // Column14
            // 
            Column14.FillWeight = 200F;
            Column14.HeaderText = "Phone Number";
            Column14.Name = "Column14";
            Column14.Width = 200;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.ImeMode = ImeMode.NoControl;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(792, 153);
            cmbGender.Margin = new Padding(4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(350, 29);
            cmbGender.TabIndex = 11;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tabAdmin);
            tabHome.Controls.Add(tabStudentRegistration);
            tabHome.Controls.Add(tabStudentList);
            tabHome.Controls.Add(tabInstructorRegistration);
            tabHome.Controls.Add(tabInstructorList);
            tabHome.Location = new Point(15, 10);
            tabHome.Margin = new Padding(4);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(1250, 570);
            tabHome.TabIndex = 2;
            // 
            // tabAdmin
            // 
            tabAdmin.BackColor = Color.LightGray;
            tabAdmin.Controls.Add(label9);
            tabAdmin.Controls.Add(lblHomeAddress);
            tabAdmin.Controls.Add(richTextBox1);
            tabAdmin.Controls.Add(btnEditInstructor);
            tabAdmin.Controls.Add(btnAddInstructor);
            tabAdmin.Controls.Add(btnEditStudent);
            tabAdmin.Controls.Add(btnRegisterStudent);
            tabAdmin.Controls.Add(btnAddAdmin);
            tabAdmin.Controls.Add(pictureBox1);
            tabAdmin.Controls.Add(lblSchoolName);
            tabAdmin.Controls.Add(lblWelcometext);
            tabAdmin.Location = new Point(4, 30);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(1242, 536);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Home";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(149, 178);
            label9.Name = "label9";
            label9.Size = new Size(90, 23);
            label9.TabIndex = 10;
            label9.Text = "About Us";
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Location = new Point(498, 96);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(227, 21);
            lblHomeAddress.TabIndex = 9;
            lblHomeAddress.Text = "Summer Row, Birmingham UK";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightGray;
            richTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(148, 202);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(653, 279);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnEditInstructor
            // 
            btnEditInstructor.BackColor = Color.Green;
            btnEditInstructor.ForeColor = SystemColors.Control;
            btnEditInstructor.Location = new Point(890, 431);
            btnEditInstructor.Name = "btnEditInstructor";
            btnEditInstructor.Size = new Size(131, 51);
            btnEditInstructor.TabIndex = 7;
            btnEditInstructor.Text = "View Instructor";
            btnEditInstructor.UseVisualStyleBackColor = false;
            btnEditInstructor.Click += btnEditInstructor_Click;
            // 
            // btnAddInstructor
            // 
            btnAddInstructor.BackColor = Color.Green;
            btnAddInstructor.ForeColor = SystemColors.Control;
            btnAddInstructor.Location = new Point(890, 370);
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.Size = new Size(131, 51);
            btnAddInstructor.TabIndex = 6;
            btnAddInstructor.Text = "Add Instructor";
            btnAddInstructor.UseVisualStyleBackColor = false;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.BackColor = Color.Green;
            btnEditStudent.ForeColor = SystemColors.Control;
            btnEditStudent.Location = new Point(890, 310);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(131, 51);
            btnEditStudent.TabIndex = 5;
            btnEditStudent.Text = "View Student";
            btnEditStudent.UseVisualStyleBackColor = false;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.BackColor = Color.Green;
            btnRegisterStudent.ForeColor = SystemColors.Control;
            btnRegisterStudent.Location = new Point(890, 252);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(131, 51);
            btnRegisterStudent.TabIndex = 4;
            btnRegisterStudent.Text = "Add Student";
            btnRegisterStudent.UseVisualStyleBackColor = false;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.Green;
            btnAddAdmin.ForeColor = SystemColors.Control;
            btnAddAdmin.Location = new Point(890, 188);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(131, 51);
            btnAddAdmin.TabIndex = 3;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pass_IT_Driving_School_Logo_removebg_preview;
            pictureBox1.Location = new Point(148, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblSchoolName
            // 
            lblSchoolName.AutoSize = true;
            lblSchoolName.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSchoolName.Location = new Point(408, 58);
            lblSchoolName.Name = "lblSchoolName";
            lblSchoolName.Size = new Size(408, 38);
            lblSchoolName.TabIndex = 1;
            lblSchoolName.Text = "PASS IT DRIVING SCHOOL";
            // 
            // lblWelcometext
            // 
            lblWelcometext.AutoSize = true;
            lblWelcometext.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcometext.Location = new Point(548, 23);
            lblWelcometext.Name = "lblWelcometext";
            lblWelcometext.Size = new Size(111, 22);
            lblWelcometext.TabIndex = 0;
            lblWelcometext.Text = "WELCOME";
            // 
            // tabStudentRegistration
            // 
            tabStudentRegistration.BackColor = Color.LightGray;
            tabStudentRegistration.Controls.Add(btnProgressTrack);
            tabStudentRegistration.Controls.Add(button1);
            tabStudentRegistration.Controls.Add(label12);
            tabStudentRegistration.Controls.Add(label10);
            tabStudentRegistration.Controls.Add(lblStudentMessage);
            tabStudentRegistration.Controls.Add(label11);
            tabStudentRegistration.Controls.Add(label8);
            tabStudentRegistration.Controls.Add(label7);
            tabStudentRegistration.Controls.Add(label6);
            tabStudentRegistration.Controls.Add(btnUpdate);
            tabStudentRegistration.Controls.Add(btnClear);
            tabStudentRegistration.Controls.Add(btnDelete);
            tabStudentRegistration.Controls.Add(btnSave);
            tabStudentRegistration.Controls.Add(dateTimePicker1);
            tabStudentRegistration.Controls.Add(cmbCourse);
            tabStudentRegistration.Controls.Add(lblCourseChoosen);
            tabStudentRegistration.Controls.Add(cmbInstructor);
            tabStudentRegistration.Controls.Add(cmbGender);
            tabStudentRegistration.Controls.Add(txtAddress);
            tabStudentRegistration.Controls.Add(txtMiddleName);
            tabStudentRegistration.Controls.Add(txtLastName);
            tabStudentRegistration.Controls.Add(txtFirstName);
            tabStudentRegistration.Controls.Add(lblEnrollDate);
            tabStudentRegistration.Controls.Add(lblInstructor);
            tabStudentRegistration.Controls.Add(lblAddress);
            tabStudentRegistration.Controls.Add(lblGender);
            tabStudentRegistration.Controls.Add(lblLastName);
            tabStudentRegistration.Controls.Add(lblMiddleName);
            tabStudentRegistration.Controls.Add(lblFirstName);
            tabStudentRegistration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabStudentRegistration.Location = new Point(4, 30);
            tabStudentRegistration.Margin = new Padding(4);
            tabStudentRegistration.Name = "tabStudentRegistration";
            tabStudentRegistration.Padding = new Padding(4);
            tabStudentRegistration.Size = new Size(1242, 536);
            tabStudentRegistration.TabIndex = 0;
            tabStudentRegistration.Text = "Student Registration";
            tabStudentRegistration.Click += tabStudentRegistration_Click;
            // 
            // btnProgressTrack
            // 
            btnProgressTrack.BackColor = Color.Green;
            btnProgressTrack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProgressTrack.ForeColor = SystemColors.ButtonFace;
            btnProgressTrack.Location = new Point(988, 450);
            btnProgressTrack.Margin = new Padding(4);
            btnProgressTrack.Name = "btnProgressTrack";
            btnProgressTrack.Size = new Size(131, 62);
            btnProgressTrack.TabIndex = 36;
            btnProgressTrack.Text = "View Progress";
            btnProgressTrack.UseVisualStyleBackColor = false;
            btnProgressTrack.Click += btnProgressTrack_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(828, 450);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(131, 62);
            button1.TabIndex = 35;
            button1.Text = "Book Lesson";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(1151, 323);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 21);
            label12.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(1151, 246);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 33;
            // 
            // lblStudentMessage
            // 
            lblStudentMessage.AutoSize = true;
            lblStudentMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentMessage.Location = new Point(174, 397);
            lblStudentMessage.Margin = new Padding(4, 0, 4, 0);
            lblStudentMessage.Name = "lblStudentMessage";
            lblStudentMessage.Size = new Size(0, 21);
            lblStudentMessage.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(532, 246);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 21);
            label11.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(1151, 161);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(532, 161);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(532, 73);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(334, 450);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 62);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 192, 0);
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(656, 450);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 62);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(503, 450);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 62);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(171, 450);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 62);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(174, 321);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 29);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2023, 11, 16, 23, 6, 53, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Introductary", "Standard", "Pass Plus", "Driving Test" });
            cmbCourse.Location = new Point(792, 312);
            cmbCourse.Margin = new Padding(4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(350, 29);
            cmbCourse.TabIndex = 14;
            // 
            // lblCourseChoosen
            // 
            lblCourseChoosen.AutoSize = true;
            lblCourseChoosen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCourseChoosen.Location = new Point(618, 319);
            lblCourseChoosen.Margin = new Padding(4, 0, 4, 0);
            lblCourseChoosen.Name = "lblCourseChoosen";
            lblCourseChoosen.Size = new Size(61, 21);
            lblCourseChoosen.TabIndex = 13;
            lblCourseChoosen.Text = "Course";
            // 
            // cmbInstructor
            // 
            cmbInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Items.AddRange(new object[] { "Shyam Krishna", "Hari Man", "Shree Krishna", "Siva Narayan", "Safal Kumar" });
            cmbInstructor.Location = new Point(792, 232);
            cmbInstructor.Margin = new Padding(4);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(350, 29);
            cmbInstructor.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(174, 235);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 29);
            txtAddress.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiddleName.Location = new Point(792, 73);
            txtMiddleName.Margin = new Padding(4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(350, 29);
            txtMiddleName.TabIndex = 9;
            txtMiddleName.TextChanged += txtMiddleName_TextChanged;
            txtMiddleName.KeyPress += txtMiddleName_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(174, 150);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(350, 29);
            txtLastName.TabIndex = 8;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(174, 76);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(350, 29);
            txtFirstName.TabIndex = 7;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnrollDate.Location = new Point(0, 332);
            lblEnrollDate.Margin = new Padding(4, 0, 4, 0);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(108, 21);
            lblEnrollDate.TabIndex = 6;
            lblEnrollDate.Text = "Enrolled Date";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructor.Location = new Point(618, 241);
            lblInstructor.Margin = new Padding(4, 0, 4, 0);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(82, 21);
            lblInstructor.TabIndex = 5;
            lblInstructor.Text = "Instructor";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(8, 246);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(618, 162);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 21);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(4, 161);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(618, 84);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(109, 21);
            lblMiddleName.TabIndex = 1;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(9, 76);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // tabStudentList
            // 
            tabStudentList.BackColor = Color.LightGray;
            tabStudentList.Controls.Add(gvStudent);
            tabStudentList.Controls.Add(btnStudentSearch);
            tabStudentList.Controls.Add(txtStudentSearch);
            tabStudentList.Location = new Point(4, 24);
            tabStudentList.Margin = new Padding(4);
            tabStudentList.Name = "tabStudentList";
            tabStudentList.Padding = new Padding(4);
            tabStudentList.Size = new Size(1242, 542);
            tabStudentList.TabIndex = 1;
            tabStudentList.Text = "Student List";
            tabStudentList.Click += tabStudentList_Click;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Location = new Point(1135, 20);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(75, 29);
            btnStudentSearch.TabIndex = 1;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.Location = new Point(919, 21);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(220, 29);
            txtStudentSearch.TabIndex = 0;
            // 
            // tabInstructorRegistration
            // 
            tabInstructorRegistration.BackColor = Color.LightGray;
            tabInstructorRegistration.Controls.Add(label1);
            tabInstructorRegistration.Controls.Add(lblMessage);
            tabInstructorRegistration.Controls.Add(label5);
            tabInstructorRegistration.Controls.Add(label4);
            tabInstructorRegistration.Controls.Add(label3);
            tabInstructorRegistration.Controls.Add(label2);
            tabInstructorRegistration.Controls.Add(btnInstructorUpdate);
            tabInstructorRegistration.Controls.Add(btnInstructorClear);
            tabInstructorRegistration.Controls.Add(btnInstructorDelete);
            tabInstructorRegistration.Controls.Add(btnInstructorSave);
            tabInstructorRegistration.Controls.Add(cmbInstructorJobType);
            tabInstructorRegistration.Controls.Add(txtInstructorMiddleName);
            tabInstructorRegistration.Controls.Add(txtInstructorLastName);
            tabInstructorRegistration.Controls.Add(txtInstructorAddress);
            tabInstructorRegistration.Controls.Add(txtInstructorPhoneNumber);
            tabInstructorRegistration.Controls.Add(txtInstructorFirstName);
            tabInstructorRegistration.Controls.Add(lblPhoneNumber);
            tabInstructorRegistration.Controls.Add(lblInstructorAddredd);
            tabInstructorRegistration.Controls.Add(lblInstructorJobType);
            tabInstructorRegistration.Controls.Add(lblInstructorLastName);
            tabInstructorRegistration.Controls.Add(lblInstructorMiddleName);
            tabInstructorRegistration.Controls.Add(lblInstructorFirstName);
            tabInstructorRegistration.Location = new Point(4, 24);
            tabInstructorRegistration.Margin = new Padding(4);
            tabInstructorRegistration.Name = "tabInstructorRegistration";
            tabInstructorRegistration.Padding = new Padding(4);
            tabInstructorRegistration.Size = new Size(1242, 542);
            tabInstructorRegistration.TabIndex = 2;
            tabInstructorRegistration.Text = "Instructor Registration";
            tabInstructorRegistration.Click += tabInstructorRegistration_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(509, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 29;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(132, 295);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1093, 150);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1093, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(509, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(509, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 19;
            // 
            // btnInstructorUpdate
            // 
            btnInstructorUpdate.BackColor = Color.Goldenrod;
            btnInstructorUpdate.ForeColor = SystemColors.ButtonFace;
            btnInstructorUpdate.Location = new Point(407, 352);
            btnInstructorUpdate.Margin = new Padding(4);
            btnInstructorUpdate.Name = "btnInstructorUpdate";
            btnInstructorUpdate.Size = new Size(111, 50);
            btnInstructorUpdate.TabIndex = 16;
            btnInstructorUpdate.Text = "Update";
            btnInstructorUpdate.UseVisualStyleBackColor = false;
            btnInstructorUpdate.Click += btnInstructorUpdate_Click;
            // 
            // btnInstructorClear
            // 
            btnInstructorClear.BackColor = Color.FromArgb(0, 192, 0);
            btnInstructorClear.ForeColor = SystemColors.ButtonFace;
            btnInstructorClear.Location = new Point(763, 352);
            btnInstructorClear.Margin = new Padding(4);
            btnInstructorClear.Name = "btnInstructorClear";
            btnInstructorClear.Size = new Size(111, 50);
            btnInstructorClear.TabIndex = 15;
            btnInstructorClear.Text = "Clear";
            btnInstructorClear.UseVisualStyleBackColor = false;
            btnInstructorClear.Click += btnInstructorClear_Click;
            // 
            // btnInstructorDelete
            // 
            btnInstructorDelete.BackColor = Color.Tomato;
            btnInstructorDelete.ForeColor = SystemColors.ButtonFace;
            btnInstructorDelete.Location = new Point(585, 352);
            btnInstructorDelete.Margin = new Padding(4);
            btnInstructorDelete.Name = "btnInstructorDelete";
            btnInstructorDelete.Size = new Size(111, 50);
            btnInstructorDelete.TabIndex = 14;
            btnInstructorDelete.Text = "Delete";
            btnInstructorDelete.UseVisualStyleBackColor = false;
            btnInstructorDelete.Click += btnInstructorDelete_Click;
            // 
            // btnInstructorSave
            // 
            btnInstructorSave.BackColor = Color.FromArgb(0, 192, 0);
            btnInstructorSave.ForeColor = SystemColors.ButtonFace;
            btnInstructorSave.Location = new Point(229, 352);
            btnInstructorSave.Margin = new Padding(4);
            btnInstructorSave.Name = "btnInstructorSave";
            btnInstructorSave.Size = new Size(111, 50);
            btnInstructorSave.TabIndex = 13;
            btnInstructorSave.Text = "Save";
            btnInstructorSave.UseVisualStyleBackColor = false;
            btnInstructorSave.Click += btnInstructorSave_Click;
            // 
            // cmbInstructorJobType
            // 
            cmbInstructorJobType.FormattingEnabled = true;
            cmbInstructorJobType.Items.AddRange(new object[] { "Full Time", "Part Time" });
            cmbInstructorJobType.Location = new Point(716, 144);
            cmbInstructorJobType.Margin = new Padding(4);
            cmbInstructorJobType.Name = "cmbInstructorJobType";
            cmbInstructorJobType.Size = new Size(369, 29);
            cmbInstructorJobType.TabIndex = 11;
            // 
            // txtInstructorMiddleName
            // 
            txtInstructorMiddleName.Location = new Point(716, 54);
            txtInstructorMiddleName.Margin = new Padding(4);
            txtInstructorMiddleName.Name = "txtInstructorMiddleName";
            txtInstructorMiddleName.Size = new Size(369, 29);
            txtInstructorMiddleName.TabIndex = 10;
            txtInstructorMiddleName.KeyPress += txtInstructorMiddleName_KeyPress;
            // 
            // txtInstructorLastName
            // 
            txtInstructorLastName.Location = new Point(132, 142);
            txtInstructorLastName.Margin = new Padding(4);
            txtInstructorLastName.Name = "txtInstructorLastName";
            txtInstructorLastName.Size = new Size(369, 29);
            txtInstructorLastName.TabIndex = 9;
            txtInstructorLastName.TextChanged += txtInstructorLastName_TextChanged;
            txtInstructorLastName.KeyPress += txtInstructorLastName_KeyPress;
            // 
            // txtInstructorAddress
            // 
            txtInstructorAddress.Location = new Point(132, 232);
            txtInstructorAddress.Margin = new Padding(4);
            txtInstructorAddress.Name = "txtInstructorAddress";
            txtInstructorAddress.Size = new Size(369, 29);
            txtInstructorAddress.TabIndex = 8;
            // 
            // txtInstructorPhoneNumber
            // 
            txtInstructorPhoneNumber.Location = new Point(716, 234);
            txtInstructorPhoneNumber.Margin = new Padding(4);
            txtInstructorPhoneNumber.Name = "txtInstructorPhoneNumber";
            txtInstructorPhoneNumber.Size = new Size(369, 29);
            txtInstructorPhoneNumber.TabIndex = 7;
            txtInstructorPhoneNumber.KeyPress += txtInstructorPhoneNumber_KeyPress;
            // 
            // txtInstructorFirstName
            // 
            txtInstructorFirstName.Location = new Point(132, 52);
            txtInstructorFirstName.Margin = new Padding(4);
            txtInstructorFirstName.Name = "txtInstructorFirstName";
            txtInstructorFirstName.Size = new Size(369, 29);
            txtInstructorFirstName.TabIndex = 6;
            txtInstructorFirstName.KeyPress += txtInstructorFirstName_KeyPress;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(562, 233);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(120, 21);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblInstructorAddredd
            // 
            lblInstructorAddredd.AutoSize = true;
            lblInstructorAddredd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorAddredd.Location = new Point(24, 236);
            lblInstructorAddredd.Margin = new Padding(4, 0, 4, 0);
            lblInstructorAddredd.Name = "lblInstructorAddredd";
            lblInstructorAddredd.Size = new Size(70, 21);
            lblInstructorAddredd.TabIndex = 4;
            lblInstructorAddredd.Text = "Address";
            // 
            // lblInstructorJobType
            // 
            lblInstructorJobType.AutoSize = true;
            lblInstructorJobType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorJobType.Location = new Point(562, 144);
            lblInstructorJobType.Margin = new Padding(4, 0, 4, 0);
            lblInstructorJobType.Name = "lblInstructorJobType";
            lblInstructorJobType.Size = new Size(75, 21);
            lblInstructorJobType.TabIndex = 3;
            lblInstructorJobType.Text = "Job Type";
            // 
            // lblInstructorLastName
            // 
            lblInstructorLastName.AutoSize = true;
            lblInstructorLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorLastName.Location = new Point(24, 144);
            lblInstructorLastName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorLastName.Name = "lblInstructorLastName";
            lblInstructorLastName.Size = new Size(86, 21);
            lblInstructorLastName.TabIndex = 2;
            lblInstructorLastName.Text = "Last Name";
            // 
            // lblInstructorMiddleName
            // 
            lblInstructorMiddleName.AutoSize = true;
            lblInstructorMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorMiddleName.Location = new Point(562, 55);
            lblInstructorMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorMiddleName.Name = "lblInstructorMiddleName";
            lblInstructorMiddleName.Size = new Size(109, 21);
            lblInstructorMiddleName.TabIndex = 1;
            lblInstructorMiddleName.Text = "Middle Name";
            // 
            // lblInstructorFirstName
            // 
            lblInstructorFirstName.AutoSize = true;
            lblInstructorFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructorFirstName.Location = new Point(24, 52);
            lblInstructorFirstName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorFirstName.Name = "lblInstructorFirstName";
            lblInstructorFirstName.Size = new Size(88, 21);
            lblInstructorFirstName.TabIndex = 0;
            lblInstructorFirstName.Text = "First Name";
            // 
            // tabInstructorList
            // 
            tabInstructorList.BackColor = Color.LightGray;
            tabInstructorList.Controls.Add(gvInstructor);
            tabInstructorList.Controls.Add(btnSearchInstructor);
            tabInstructorList.Controls.Add(txtSearchInstructor);
            tabInstructorList.Location = new Point(4, 24);
            tabInstructorList.Margin = new Padding(4);
            tabInstructorList.Name = "tabInstructorList";
            tabInstructorList.Padding = new Padding(4);
            tabInstructorList.Size = new Size(1242, 542);
            tabInstructorList.TabIndex = 3;
            tabInstructorList.Text = "Instructor List";
            // 
            // btnSearchInstructor
            // 
            btnSearchInstructor.Location = new Point(1158, 33);
            btnSearchInstructor.Name = "btnSearchInstructor";
            btnSearchInstructor.Size = new Size(75, 29);
            btnSearchInstructor.TabIndex = 1;
            btnSearchInstructor.Text = "Search";
            btnSearchInstructor.UseVisualStyleBackColor = true;
            // 
            // txtSearchInstructor
            // 
            txtSearchInstructor.Location = new Point(952, 34);
            txtSearchInstructor.Name = "txtSearchInstructor";
            txtSearchInstructor.Size = new Size(210, 29);
            txtSearchInstructor.TabIndex = 0;
            // 
            // lblLogout
            // 
            lblLogout.ActiveLinkColor = Color.Red;
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogout.LinkColor = Color.Red;
            lblLogout.Location = new Point(1188, 10);
            lblLogout.Margin = new Padding(4, 0, 4, 0);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(68, 21);
            lblLogout.TabIndex = 3;
            lblLogout.TabStop = true;
            lblLogout.Text = "Log out";
            lblLogout.LinkClicked += lblLogout_LinkClicked;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 209, 92);
            ClientSize = new Size(1284, 591);
            Controls.Add(lblLogout);
            Controls.Add(tabHome);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Admin_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Form_Load;
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInstructor).EndInit();
            tabHome.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabStudentRegistration.ResumeLayout(false);
            tabStudentRegistration.PerformLayout();
            tabStudentList.ResumeLayout(false);
            tabStudentList.PerformLayout();
            tabInstructorRegistration.ResumeLayout(false);
            tabInstructorRegistration.PerformLayout();
            tabInstructorList.ResumeLayout(false);
            tabInstructorList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabHome;
        private TabPage tabStudentRegistration;
        private TabPage tabStudentList;
        private TabPage tabInstructorRegistration;
        private TabPage tabInstructorList;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblEnrollDate;
        private Label lblInstructor;
        private Label lblAddress;
        private Label lblGender;
        private Label lblLastName;
        private Label lblMiddleName;
        private Label lblFirstName;
        private TextBox txtAddress;
        private Label lblCourseChoosen;
        private DateTimePicker dateTimePicker1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtInstructorFirstName;
        private Label lblPhoneNumber;
        private Label lblInstructorAddredd;
        private Label lblInstructorJobType;
        private Label lblInstructorLastName;
        private Label lblInstructorMiddleName;
        private Label lblInstructorFirstName;
        private TextBox txtInstructorMiddleName;
        private TextBox txtInstructorLastName;
        private TextBox txtInstructorAddress;
        private TextBox txtInstructorPhoneNumber;
        private ComboBox cmbInstructorJobType;
        private Button btnInstructorClear;
        private Button btnInstructorDelete;
        private Button btnInstructorSave;
        private LinkLabel lblLogout;
        private Button btnUpdate;
        private Button btnInstructorUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblMessage;
        private Label lblStudentMessage;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label8;
        private ComboBox cmbCourse;
        private ComboBox cmbInstructor;
        private ComboBox cmbGender;
        private TextBox txtMiddleName;
        private Label label12;
        private Label label10;
        private Label label1;
        private Button btnStudentSearch;
        private TextBox txtStudentSearch;
        private DataGridView gvStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnSearchInstructor;
        private TextBox txtSearchInstructor;
        private DataGridView gvInstructor;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Button btnProgressTrack;
        private Button button1;
        private TabPage tabAdmin;
        private Label lblWelcometext;
        private Label lblSchoolName;
        private PictureBox pictureBox1;
        private Button btnEditInstructor;
        private Button btnAddInstructor;
        private Button btnEditStudent;
        private Button btnRegisterStudent;
        private Button btnAddAdmin;
        private RichTextBox richTextBox1;
        private Label lblHomeAddress;
        private Label label9;
        private ToolTip toolTipHome;
    }
}