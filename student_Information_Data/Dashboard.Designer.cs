namespace student_Information_Data
{
    partial class Dashboard
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvStudents = new DataGridView();
            label2 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            txtAge = new TextBox();
            txtBrithdate = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 30);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(204, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(204, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(434, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(19, 92);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(494, 347);
            dgvStudents.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(593, 37);
            label2.Name = "label2";
            label2.Size = new Size(265, 30);
            label2.TabIndex = 4;
            label2.Text = "UPDATED STUDENT INFO";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 14.25F);
            txtFirstname.Location = new Point(677, 126);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(204, 33);
            txtFirstname.TabIndex = 5;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 14.25F);
            txtLastname.Location = new Point(678, 164);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(204, 33);
            txtLastname.TabIndex = 6;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 14.25F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(678, 202);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(204, 33);
            cmbCourse.TabIndex = 7;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 14.25F);
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(678, 241);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(204, 33);
            cmbSection.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 14.25F);
            txtAge.Location = new Point(678, 279);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(204, 33);
            txtAge.TabIndex = 9;
            // 
            // txtBrithdate
            // 
            txtBrithdate.Font = new Font("Segoe UI", 14.25F);
            txtBrithdate.Location = new Point(677, 316);
            txtBrithdate.Name = "txtBrithdate";
            txtBrithdate.Size = new Size(204, 33);
            txtBrithdate.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(678, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE RECORD";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(679, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 30);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE RECORD";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(537, 125);
            label3.Name = "label3";
            label3.Size = new Size(131, 30);
            label3.TabIndex = 13;
            label3.Text = "First Name :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(540, 167);
            label4.Name = "label4";
            label4.Size = new Size(128, 30);
            label4.TabIndex = 14;
            label4.Text = "Last Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(582, 205);
            label5.Name = "label5";
            label5.Size = new Size(86, 30);
            label5.TabIndex = 15;
            label5.Text = "Course:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(570, 244);
            label6.Name = "label6";
            label6.Size = new Size(98, 30);
            label6.TabIndex = 16;
            label6.Text = "Section :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(604, 282);
            label7.Name = "label7";
            label7.Size = new Size(64, 30);
            label7.TabIndex = 17;
            label7.Text = "Age :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(551, 319);
            label8.Name = "label8";
            label8.Size = new Size(117, 30);
            label8.TabIndex = 18;
            label8.Text = "Birthdate :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(621, 86);
            label9.Name = "label9";
            label9.Size = new Size(47, 30);
            label9.TabIndex = 19;
            label9.Text = "ID :";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 14.25F);
            txtID.Location = new Point(679, 87);
            txtID.Name = "txtID";
            txtID.Size = new Size(204, 33);
            txtID.TabIndex = 20;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(969, 450);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtBrithdate);
            Controls.Add(txtAge);
            Controls.Add(cmbSection);
            Controls.Add(cmbCourse);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label2);
            Controls.Add(dgvStudents);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvStudents;
        private Label label2;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private TextBox txtAge;
        private TextBox txtBrithdate;
        private Button btnSave;
        private Button btnDelete;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtID;
    }
}