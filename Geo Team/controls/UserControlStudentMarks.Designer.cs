namespace Geo_Team
{
    partial class UserControlStudentMarks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_parent_phone = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_exams = new System.Windows.Forms.DataGridView();
            this.Exam_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_quizes = new System.Windows.Forms.DataGridView();
            this.btn_find = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.center_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quiz_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quizes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Code";
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(156, 8);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(263, 30);
            this.txt_code.TabIndex = 6;
            this.txt_code.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_code_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_parent_phone);
            this.groupBox1.Controls.Add(this.lbl_phone);
            this.groupBox1.Controls.Add(this.lbl_group);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // lbl_parent_phone
            // 
            this.lbl_parent_phone.AutoSize = true;
            this.lbl_parent_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parent_phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_parent_phone.Location = new System.Drawing.Point(6, 108);
            this.lbl_parent_phone.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_parent_phone.Name = "lbl_parent_phone";
            this.lbl_parent_phone.Size = new System.Drawing.Size(153, 17);
            this.lbl_parent_phone.TabIndex = 3;
            this.lbl_parent_phone.Text = "Parent Phone Number:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_phone.Location = new System.Drawing.Point(6, 81);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(107, 17);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_group.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_group.Location = new System.Drawing.Point(6, 54);
            this.lbl_group.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(52, 17);
            this.lbl_group.TabIndex = 1;
            this.lbl_group.Text = "Group:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_name.Location = new System.Drawing.Point(6, 27);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name: ";
            // 
            // dgv_exams
            // 
            this.dgv_exams.AllowUserToDeleteRows = false;
            this.dgv_exams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_exams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_exams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_exams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exam_Date,
            this.Exam_Score});
            this.dgv_exams.Location = new System.Drawing.Point(576, 199);
            this.dgv_exams.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.dgv_exams.Name = "dgv_exams";
            this.dgv_exams.Size = new System.Drawing.Size(245, 346);
            this.dgv_exams.TabIndex = 9;
            // 
            // Exam_Date
            // 
            this.Exam_Date.HeaderText = "Exam Date";
            this.Exam_Date.Name = "Exam_Date";
            this.Exam_Date.ReadOnly = true;
            // 
            // Exam_Score
            // 
            this.Exam_Score.HeaderText = "Score";
            this.Exam_Score.Name = "Exam_Score";
            this.Exam_Score.ReadOnly = true;
            // 
            // dgv_quizes
            // 
            this.dgv_quizes.AllowUserToDeleteRows = false;
            this.dgv_quizes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_quizes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_quizes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_quizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Group,
            this.center_name,
            this.Quiz_Score});
            this.dgv_quizes.Location = new System.Drawing.Point(13, 199);
            this.dgv_quizes.Name = "dgv_quizes";
            this.dgv_quizes.Size = new System.Drawing.Size(535, 346);
            this.dgv_quizes.TabIndex = 8;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(435, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(121, 23);
            this.btn_find.TabIndex = 7;
            this.btn_find.Text = "Find Student";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group Day";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // center_name
            // 
            this.center_name.HeaderText = "Center Name";
            this.center_name.Name = "center_name";
            this.center_name.ReadOnly = true;
            // 
            // Quiz_Score
            // 
            this.Quiz_Score.HeaderText = "Quiz Score";
            this.Quiz_Score.Name = "Quiz_Score";
            this.Quiz_Score.ReadOnly = true;
            // 
            // UserControlStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.dgv_quizes);
            this.Controls.Add(this.dgv_exams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserControlStudentMarks";
            this.Size = new System.Drawing.Size(870, 596);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_exams;
        private System.Windows.Forms.DataGridView dgv_quizes;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Label lbl_parent_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn center_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quiz_Score;
    }
}
