namespace Geo_Team
{
    partial class UserControlAllStudents
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.stu_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_parent_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_center_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
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
            this.label5.TabIndex = 51;
            this.label5.Text = "Students";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_students
            // 
            this.dgv_students.AllowUserToAddRows = false;
            this.dgv_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_students.BackgroundColor = System.Drawing.Color.White;
            this.dgv_students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_code,
            this.stu_name,
            this.stu_phone,
            this.stu_parent_phone,
            this.stu_group,
            this.stu_center_name});
            this.dgv_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_students.Location = new System.Drawing.Point(0, 39);
            this.dgv_students.Margin = new System.Windows.Forms.Padding(25);
            this.dgv_students.MultiSelect = false;
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.ReadOnly = true;
            this.dgv_students.RowHeadersVisible = false;
            this.dgv_students.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_students.Size = new System.Drawing.Size(870, 557);
            this.dgv_students.TabIndex = 52;
            // 
            // stu_code
            // 
            this.stu_code.HeaderText = "Student Code";
            this.stu_code.Name = "stu_code";
            this.stu_code.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "Student Name";
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // stu_phone
            // 
            this.stu_phone.HeaderText = "Phone Number";
            this.stu_phone.Name = "stu_phone";
            this.stu_phone.ReadOnly = true;
            // 
            // stu_parent_phone
            // 
            this.stu_parent_phone.HeaderText = "Parent Phone Number";
            this.stu_parent_phone.Name = "stu_parent_phone";
            this.stu_parent_phone.ReadOnly = true;
            // 
            // stu_group
            // 
            this.stu_group.HeaderText = "Group";
            this.stu_group.Name = "stu_group";
            this.stu_group.ReadOnly = true;
            // 
            // stu_center_name
            // 
            this.stu_center_name.HeaderText = "Center Name";
            this.stu_center_name.Name = "stu_center_name";
            this.stu_center_name.ReadOnly = true;
            // 
            // UserControlAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.label5);
            this.Name = "UserControlAllStudents";
            this.Size = new System.Drawing.Size(870, 596);
            this.Load += new System.EventHandler(this.UserControlAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_parent_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_center_name;
    }
}
