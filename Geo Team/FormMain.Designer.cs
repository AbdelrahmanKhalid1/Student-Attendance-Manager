namespace Geo_Team
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_header = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_add_exam = new System.Windows.Forms.Button();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_view_student = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_header.Controls.Add(this.labelTime);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Controls.Add(this.btn_menu);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1120, 50);
            this.panel_header.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(948, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(121, 50);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "HH:MM:SS";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1069, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 50);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(8, 0);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(54, 50);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geo Team";
            // 
            // panel_nav
            // 
            this.panel_nav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_nav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_nav.Controls.Add(this.btn_add_exam);
            this.panel_nav.Controls.Add(this.btn_add_student);
            this.panel_nav.Controls.Add(this.btn_view_all);
            this.panel_nav.Controls.Add(this.btn_view_student);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 50);
            this.panel_nav.Margin = new System.Windows.Forms.Padding(0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(265, 610);
            this.panel_nav.TabIndex = 2;
            // 
            // btn_add_exam
            // 
            this.btn_add_exam.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_exam.FlatAppearance.BorderSize = 0;
            this.btn_add_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_exam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_exam.ForeColor = System.Drawing.Color.Teal;
            this.btn_add_exam.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_exam.Image")));
            this.btn_add_exam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_exam.Location = new System.Drawing.Point(3, 120);
            this.btn_add_exam.Name = "btn_add_exam";
            this.btn_add_exam.Size = new System.Drawing.Size(255, 60);
            this.btn_add_exam.TabIndex = 5;
            this.btn_add_exam.Text = "         Add Exam Grades";
            this.btn_add_exam.UseVisualStyleBackColor = false;
            this.btn_add_exam.Click += new System.EventHandler(this.btn_add_quiz_Click);
            this.btn_add_exam.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_add_exam.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_student.FlatAppearance.BorderSize = 0;
            this.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_student.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.ForeColor = System.Drawing.Color.Teal;
            this.btn_add_student.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_student.Image")));
            this.btn_add_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_student.Location = new System.Drawing.Point(3, 180);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(255, 60);
            this.btn_add_student.TabIndex = 6;
            this.btn_add_student.Text = "         Add new Student";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_new_student_Click);
            this.btn_add_student.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_add_student.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_view_all
            // 
            this.btn_view_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_all.FlatAppearance.BorderSize = 0;
            this.btn_view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_all.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all.ForeColor = System.Drawing.Color.Teal;
            this.btn_view_all.Image = ((System.Drawing.Image)(resources.GetObject("btn_view_all.Image")));
            this.btn_view_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_all.Location = new System.Drawing.Point(3, 60);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(255, 60);
            this.btn_view_all.TabIndex = 4;
            this.btn_view_all.Text = "         View All Students";
            this.btn_view_all.UseVisualStyleBackColor = false;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            this.btn_view_all.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_view_all.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_view_student
            // 
            this.btn_view_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_student.FlatAppearance.BorderSize = 0;
            this.btn_view_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_student.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_student.ForeColor = System.Drawing.Color.Teal;
            this.btn_view_student.Image = ((System.Drawing.Image)(resources.GetObject("btn_view_student.Image")));
            this.btn_view_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_student.Location = new System.Drawing.Point(3, 0);
            this.btn_view_student.Name = "btn_view_student";
            this.btn_view_student.Size = new System.Drawing.Size(255, 60);
            this.btn_view_student.TabIndex = 3;
            this.btn_view_student.Text = "   Student Marks";
            this.btn_view_student.UseVisualStyleBackColor = false;
            this.btn_view_student.Click += new System.EventHandler(this.btn_view_student_Click);
            this.btn_view_student.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_view_student.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // openFD
            // 
            this.openFD.FileName = "Student Sheet";
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel_container.Location = new System.Drawing.Point(265, 50);
            this.panel_container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(855, 610);
            this.panel_container.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 660);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_header);
            this.Name = "FormMain";
            this.Text = "Geo Team";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_view_student;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btn_add_exam;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Panel panel_container;
    }
}