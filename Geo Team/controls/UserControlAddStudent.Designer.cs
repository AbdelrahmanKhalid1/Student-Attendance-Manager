namespace Geo_Team
{
    partial class UserControlAddStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_error_parent_phone = new System.Windows.Forms.Label();
            this.lbl_error_phone = new System.Windows.Forms.Label();
            this.lbl_error_name = new System.Windows.Forms.Label();
            this.btn_cancel_edit = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_option = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parent_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_error_parent_phone);
            this.groupBox1.Controls.Add(this.lbl_error_phone);
            this.groupBox1.Controls.Add(this.lbl_error_name);
            this.groupBox1.Controls.Add(this.btn_cancel_edit);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.btn_add_student);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_parent_phone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 358);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // lbl_error_parent_phone
            // 
            this.lbl_error_parent_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_error_parent_phone.AutoSize = true;
            this.lbl_error_parent_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_parent_phone.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_parent_phone.Location = new System.Drawing.Point(567, 260);
            this.lbl_error_parent_phone.Name = "lbl_error_parent_phone";
            this.lbl_error_parent_phone.Size = new System.Drawing.Size(229, 20);
            this.lbl_error_parent_phone.TabIndex = 71;
            this.lbl_error_parent_phone.Text = "Parent phone number not valid!";
            this.lbl_error_parent_phone.Visible = false;
            // 
            // lbl_error_phone
            // 
            this.lbl_error_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_error_phone.AutoSize = true;
            this.lbl_error_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_phone.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_phone.Location = new System.Drawing.Point(567, 225);
            this.lbl_error_phone.Name = "lbl_error_phone";
            this.lbl_error_phone.Size = new System.Drawing.Size(239, 20);
            this.lbl_error_phone.TabIndex = 70;
            this.lbl_error_phone.Text = "Student phone number not valid!";
            this.lbl_error_phone.Visible = false;
            // 
            // lbl_error_name
            // 
            this.lbl_error_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_error_name.AutoSize = true;
            this.lbl_error_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_name.Location = new System.Drawing.Point(567, 190);
            this.lbl_error_name.Name = "lbl_error_name";
            this.lbl_error_name.Size = new System.Drawing.Size(117, 20);
            this.lbl_error_name.TabIndex = 69;
            this.lbl_error_name.Text = "Name not valid!";
            this.lbl_error_name.Visible = false;
            // 
            // btn_cancel_edit
            // 
            this.btn_cancel_edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel_edit.FlatAppearance.BorderSize = 0;
            this.btn_cancel_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_edit.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_edit.Location = new System.Drawing.Point(368, 302);
            this.btn_cancel_edit.Name = "btn_cancel_edit";
            this.btn_cancel_edit.Size = new System.Drawing.Size(181, 35);
            this.btn_cancel_edit.TabIndex = 13;
            this.btn_cancel_edit.Text = "Cancel";
            this.btn_cancel_edit.UseVisualStyleBackColor = false;
            this.btn_cancel_edit.Visible = false;
            this.btn_cancel_edit.Click += new System.EventHandler(this.btn_cancel_edit_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Name.Location = new System.Drawing.Point(16, 190);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.lbl_Name.TabIndex = 68;
            this.lbl_Name.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(181, 184);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(368, 29);
            this.txt_name.TabIndex = 9;
            this.txt_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_propertise_mouse_click);
            // 
            // btn_add_student
            // 
            this.btn_add_student.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add_student.FlatAppearance.BorderSize = 0;
            this.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.ForeColor = System.Drawing.Color.White;
            this.btn_add_student.Location = new System.Drawing.Point(181, 302);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(181, 35);
            this.btn_add_student.TabIndex = 12;
            this.btn_add_student.Text = "Add New";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_option);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(848, 146);
            this.panel1.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_option
            // 
            this.lbl_option.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_option.AutoSize = true;
            this.lbl_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_option.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_option.Location = new System.Drawing.Point(331, 105);
            this.lbl_option.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_option.Name = "lbl_option";
            this.lbl_option.Size = new System.Drawing.Size(170, 31);
            this.lbl_option.TabIndex = 49;
            this.lbl_option.Text = "New Student";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(181, 219);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(368, 29);
            this.txt_phone.TabIndex = 10;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Phone:";
            // 
            // txt_parent_phone
            // 
            this.txt_parent_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_parent_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parent_phone.Location = new System.Drawing.Point(181, 254);
            this.txt_parent_phone.Name = "txt_parent_phone";
            this.txt_parent_phone.Size = new System.Drawing.Size(368, 29);
            this.txt_parent_phone.TabIndex = 11;
            this.txt_parent_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Parent Phone:";
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edit.Location = new System.Drawing.Point(435, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(121, 23);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit Student";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_code
            // 
            this.txt_code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(156, 8);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(263, 30);
            this.txt_code.TabIndex = 7;
            this.txt_code.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_code_MouseClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 71;
            this.label3.Text = "Student Code";
            // 
            // UserControlAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlAddStudent";
            this.Size = new System.Drawing.Size(870, 596);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_option;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_parent_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel_edit;
        private System.Windows.Forms.Label lbl_error_parent_phone;
        private System.Windows.Forms.Label lbl_error_phone;
        private System.Windows.Forms.Label lbl_error_name;
    }
}
