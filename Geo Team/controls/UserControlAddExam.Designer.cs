namespace Geo_Team
{
    partial class UserControlAddExam
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
            this.dgv_exams = new System.Windows.Forms.DataGridView();
            this.stu_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esam_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_quiz = new System.Windows.Forms.RadioButton();
            this.radio_exam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date: ";
            // 
            // dgv_exams
            // 
            this.dgv_exams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_exams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_exams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_exams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_code,
            this.esam_result});
            this.dgv_exams.Location = new System.Drawing.Point(14, 149);
            this.dgv_exams.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.dgv_exams.Name = "dgv_exams";
            this.dgv_exams.Size = new System.Drawing.Size(823, 433);
            this.dgv_exams.TabIndex = 12;
            // 
            // stu_code
            // 
            this.stu_code.HeaderText = "Student Code";
            this.stu_code.Name = "stu_code";
            // 
            // esam_result
            // 
            this.esam_result.HeaderText = "Exam Result ";
            this.esam_result.Name = "esam_result";
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(121, 61);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(263, 30);
            this.txt_date.TabIndex = 7;
            this.txt_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_mouse_click);
            // 
            // txt_day
            // 
            this.txt_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_day.Location = new System.Drawing.Point(574, 61);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(263, 30);
            this.txt_day.TabIndex = 8;
            this.txt_day.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_mouse_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(458, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Day:";
            // 
            // txt_mark
            // 
            this.txt_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mark.Location = new System.Drawing.Point(575, 106);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(263, 30);
            this.txt_mark.TabIndex = 11;
            this.txt_mark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_mouse_click);
            this.txt_mark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mark_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(429, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Exam Mark:";
            // 
            // radio_quiz
            // 
            this.radio_quiz.AutoSize = true;
            this.radio_quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_quiz.Location = new System.Drawing.Point(121, 111);
            this.radio_quiz.Name = "radio_quiz";
            this.radio_quiz.Size = new System.Drawing.Size(59, 24);
            this.radio_quiz.TabIndex = 9;
            this.radio_quiz.TabStop = true;
            this.radio_quiz.Text = "Quiz";
            this.radio_quiz.UseVisualStyleBackColor = true;
            // 
            // radio_exam
            // 
            this.radio_exam.AutoSize = true;
            this.radio_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_exam.Location = new System.Drawing.Point(215, 111);
            this.radio_exam.Name = "radio_exam";
            this.radio_exam.Size = new System.Drawing.Size(126, 24);
            this.radio_exam.TabIndex = 10;
            this.radio_exam.TabStop = true;
            this.radio_exam.Text = "Monthly Exam";
            this.radio_exam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(870, 39);
            this.label5.TabIndex = 52;
            this.label5.Text = "New Exam";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Exam is: ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(469, 588);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(181, 35);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(656, 588);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(181, 35);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // UserControlAddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radio_exam);
            this.Controls.Add(this.radio_quiz);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.dgv_exams);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddExam";
            this.Size = new System.Drawing.Size(870, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_exams;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn esam_result;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_quiz;
        private System.Windows.Forms.RadioButton radio_exam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}
