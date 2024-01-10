namespace Pass_IT_Driving_School
{
    partial class ProgressCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressCard));
            label1 = new Label();
            lblPercentage = new Label();
            lblSecondName = new Label();
            lblFirstName = new Label();
            gvProgressReport = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gvProgressReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Progress Card";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentage.Location = new Point(12, 118);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(136, 21);
            lblPercentage.TabIndex = 1;
            lblPercentage.Text = "87%  completed.";
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondName.Location = new Point(12, 72);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(112, 21);
            lblSecondName.TabIndex = 2;
            lblSecondName.Text = "Progress Card";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(12, 51);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(112, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "Progress Card";
            // 
            // gvProgressReport
            // 
            gvProgressReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvProgressReport.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            gvProgressReport.Location = new Point(164, 51);
            gvProgressReport.Name = "gvProgressReport";
            gvProgressReport.RowTemplate.Height = 25;
            gvProgressReport.Size = new Size(264, 247);
            gvProgressReport.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Date";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 70F;
            Column2.HeaderText = "Duration";
            Column2.Name = "Column2";
            Column2.Width = 70;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.progress_Image;
            pictureBox1.Location = new Point(12, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ProgressCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 209, 92);
            ClientSize = new Size(444, 311);
            Controls.Add(pictureBox1);
            Controls.Add(gvProgressReport);
            Controls.Add(lblFirstName);
            Controls.Add(lblSecondName);
            Controls.Add(lblPercentage);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ProgressCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progress Card";
            Load += ProgressCard_Load;
            ((System.ComponentModel.ISupportInitialize)gvProgressReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPercentage;
        private Label lblSecondName;
        private Label lblFirstName;
        private DataGridView gvProgressReport;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private PictureBox pictureBox1;
    }
}