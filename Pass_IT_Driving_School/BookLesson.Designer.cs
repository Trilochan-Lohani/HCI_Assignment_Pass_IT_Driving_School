namespace Pass_IT_Driving_School
{
    partial class BookLesson
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookLesson));
            lblLBName = new Label();
            lblLBNameDisplay = new Label();
            lblLBLastnameDisplay = new Label();
            lblDate = new Label();
            lalblTimeDuration = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            btnSave = new Button();
            btnCancle = new Button();
            gvBookLesson = new DataGridView();
            Booking_Date = new DataGridViewTextBoxColumn();
            Time_Duration = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBookLesson).BeginInit();
            SuspendLayout();
            // 
            // lblLBName
            // 
            lblLBName.AutoSize = true;
            lblLBName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLBName.ForeColor = Color.Black;
            lblLBName.Location = new Point(25, 33);
            lblLBName.Name = "lblLBName";
            lblLBName.Size = new Size(61, 21);
            lblLBName.TabIndex = 0;
            lblLBName.Text = "Name :";
            // 
            // lblLBNameDisplay
            // 
            lblLBNameDisplay.AutoSize = true;
            lblLBNameDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLBNameDisplay.ForeColor = Color.Black;
            lblLBNameDisplay.Location = new Point(92, 33);
            lblLBNameDisplay.Name = "lblLBNameDisplay";
            lblLBNameDisplay.Size = new Size(0, 21);
            lblLBNameDisplay.TabIndex = 1;
            // 
            // lblLBLastnameDisplay
            // 
            lblLBLastnameDisplay.AutoSize = true;
            lblLBLastnameDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLBLastnameDisplay.ForeColor = Color.Black;
            lblLBLastnameDisplay.Location = new Point(92, 65);
            lblLBLastnameDisplay.Name = "lblLBLastnameDisplay";
            lblLBLastnameDisplay.Size = new Size(0, 21);
            lblLBLastnameDisplay.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(25, 96);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(93, 21);
            lblDate.TabIndex = 3;
            lblDate.Text = "Select Date";
            // 
            // lalblTimeDuration
            // 
            lalblTimeDuration.AutoSize = true;
            lalblTimeDuration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lalblTimeDuration.ForeColor = Color.Black;
            lalblTimeDuration.Location = new Point(25, 142);
            lalblTimeDuration.Name = "lalblTimeDuration";
            lalblTimeDuration.Size = new Size(113, 21);
            lalblTimeDuration.TabIndex = 4;
            lalblTimeDuration.Text = "Time Duration";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(146, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 29);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 10, 1, 0, 0, 0, 0);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(146, 142);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(210, 29);
            numericUpDown1.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(25, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Tomato;
            btnCancle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(147, 200);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(113, 40);
            btnCancle.TabIndex = 8;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // gvBookLesson
            // 
            gvBookLesson.BackgroundColor = SystemColors.AppWorkspace;
            gvBookLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvBookLesson.Columns.AddRange(new DataGridViewColumn[] { Booking_Date, Time_Duration });
            gvBookLesson.GridColor = SystemColors.ActiveCaption;
            gvBookLesson.Location = new Point(397, 33);
            gvBookLesson.Name = "gvBookLesson";
            dataGridViewCellStyle1.ForeColor = Color.Black;
            gvBookLesson.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gvBookLesson.RowTemplate.Height = 25;
            gvBookLesson.Size = new Size(344, 216);
            gvBookLesson.TabIndex = 9;
            gvBookLesson.MouseDoubleClick += gvBookLesson_MouseDoubleClick;
            // 
            // Booking_Date
            // 
            Booking_Date.HeaderText = "Booking Date";
            Booking_Date.Name = "Booking_Date";
            Booking_Date.Width = 200;
            // 
            // Time_Duration
            // 
            Time_Duration.HeaderText = "Time Duration";
            Time_Duration.Name = "Time_Duration";
            // 
            // BookLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 209, 92);
            ClientSize = new Size(764, 261);
            Controls.Add(gvBookLesson);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lalblTimeDuration);
            Controls.Add(lblDate);
            Controls.Add(lblLBLastnameDisplay);
            Controls.Add(lblLBNameDisplay);
            Controls.Add(lblLBName);
            ForeColor = Color.AliceBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BookLesson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Lesson";
            Load += BookLesson_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBookLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLBName;
        private Label lblLBNameDisplay;
        private Label lblLBLastnameDisplay;
        private Label lblDate;
        private Label lalblTimeDuration;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Button btnSave;
        private Button btnCancle;
        private DataGridView gvBookLesson;
        private DataGridViewTextBoxColumn Booking_Date;
        private DataGridViewTextBoxColumn Time_Duration;
    }
}