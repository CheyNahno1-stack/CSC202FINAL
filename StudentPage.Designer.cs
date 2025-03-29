namespace CSC202FinalProject
{
    partial class StudentPage
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
            DtaGrdStudent = new DataGridView();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            btnSearch = new Button();
            txtbxStudenSearch = new TextBox();
            txtbxStudentName = new TextBox();
            txtbxStudentGrade = new TextBox();
            txtbxAttendance = new TextBox();
            txtbxScore = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)DtaGrdStudent).BeginInit();
            SuspendLayout();
            // 
            // DtaGrdStudent
            // 
            DtaGrdStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtaGrdStudent.Location = new Point(12, 122);
            DtaGrdStudent.Name = "DtaGrdStudent";
            DtaGrdStudent.Size = new Size(559, 217);
            DtaGrdStudent.TabIndex = 0;
            DtaGrdStudent.CellContentClick += DtaGrdStudent_CellContentClick;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(392, 399);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(93, 23);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveStudent.Location = new Point(560, 399);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(108, 23);
            btnRemoveStudent.TabIndex = 2;
            btnRemoveStudent.Text = "Remove Student ";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(392, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtbxStudenSearch
            // 
            txtbxStudenSearch.Location = new Point(61, 38);
            txtbxStudenSearch.Name = "txtbxStudenSearch";
            txtbxStudenSearch.Size = new Size(296, 23);
            txtbxStudenSearch.TabIndex = 4;
            // 
            // txtbxStudentName
            // 
            txtbxStudentName.Location = new Point(592, 129);
            txtbxStudentName.Name = "txtbxStudentName";
            txtbxStudentName.Size = new Size(176, 23);
            txtbxStudentName.TabIndex = 5;
            txtbxStudentName.TextChanged += txtbxStudentName_TextChanged;
            // 
            // txtbxStudentGrade
            // 
            txtbxStudentGrade.Location = new Point(622, 183);
            txtbxStudentGrade.Name = "txtbxStudentGrade";
            txtbxStudentGrade.Size = new Size(100, 23);
            txtbxStudentGrade.TabIndex = 6;
            txtbxStudentGrade.TextChanged += txtbxStudentGrade_TextChanged;
            // 
            // txtbxAttendance
            // 
            txtbxAttendance.Location = new Point(622, 244);
            txtbxAttendance.Name = "txtbxAttendance";
            txtbxAttendance.Size = new Size(100, 23);
            txtbxAttendance.TabIndex = 7;
            txtbxAttendance.TextChanged += txtbxAttendance_TextChanged;
            // 
            // txtbxScore
            // 
            txtbxScore.Location = new Point(622, 295);
            txtbxScore.Name = "txtbxScore";
            txtbxScore.Size = new Size(100, 23);
            txtbxScore.TabIndex = 8;
            txtbxScore.TextChanged += txtbxScore_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(621, 111);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 9;
            label1.Text = "Add Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(613, 165);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 10;
            label2.Text = "Student Grade Level:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(613, 226);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 11;
            label3.Text = "Students Attendance:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(622, 277);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 12;
            label4.Text = "Students Score: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 20);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 13;
            label5.Text = "Search Students: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(186, 86);
            label6.Name = "label6";
            label6.Size = new Size(199, 24);
            label6.TabIndex = 14;
            label6.Text = "Student Information";
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbxScore);
            Controls.Add(txtbxAttendance);
            Controls.Add(txtbxStudentGrade);
            Controls.Add(txtbxStudentName);
            Controls.Add(txtbxStudenSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(DtaGrdStudent);
            Name = "StudentPage";
            Text = "StudentPage";
            ((System.ComponentModel.ISupportInitialize)DtaGrdStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtaGrdStudent;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnSearch;
        private TextBox txtbxStudenSearch;
        private TextBox txtbxStudentName;
        private TextBox txtbxStudentGrade;
        private TextBox txtbxAttendance;
        private TextBox txtbxScore;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}