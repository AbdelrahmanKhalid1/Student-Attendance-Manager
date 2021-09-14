using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geo_Team.models;

namespace Geo_Team
{
    public partial class UserControlAddStudent : UserControl
    {
        private Form parentForm;
        private Excel excel;
        private bool isEdit;
        private string editStudentCode;
        public UserControlAddStudent(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            isEdit = false;
            try
            {
                excel = Excel.getInstance();
            }
            catch (NullReferenceException e)
            {
                handleNullError(e);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_code.Text == "")
                    throw new Exception("No student code is entered!");

                editStudentCode = txt_code.Text;
                loadStudent();

                isEdit = true;
                lbl_option.Text = "Edit Student";
                btn_add_student.Text = "Confirm";
                btn_cancel_edit.Visible = true;
            }
            catch (Exception ignore)
            { 
                handleNullError(ignore);
            }
        }

        /**
         * Summary
         *      loading student with entered code to edit his data
         * **/
        private void loadStudent()
        {
            Student student = excel.getStudentInfo(editStudentCode);
            txt_name.Text = student.name;
            txt_phone.Text = student.phone;
            txt_parent_phone.Text = student.parentPhone;
        }

        private void btn_cancel_edit_Click(object sender, EventArgs e)
        {
            isEdit = false;
            lbl_option.Text = "New Student";
            btn_add_student.Text = "Add New";
            btn_cancel_edit.Visible = false;
            editStudentCode = "";
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            if (validateName() && validatePhone(txt_phone, lbl_error_phone) && validatePhone(txt_parent_phone, lbl_error_parent_phone))
            {
                try
                {
                    if (isEdit)
                    {
                        bool isSuccessfull = excel.updateStudent(editStudentCode, txt_name.Text, txt_phone.Text, txt_parent_phone.Text);
                        if (isSuccessfull)
                            MessageBox.Show("Updated Successfully");
                    }
                    else
                    {
                        int code = excel.addNewStudent(txt_name.Text, txt_phone.Text, txt_parent_phone.Text);
                        if (code != -1)
                            MessageBox.Show("Student is Added Successfully with code \"" + code + "\"");
                    }
                }
                catch (Exception ignore)
                {
                    handleNullError(ignore);
                }
            }
        }

        /**
         * Summary:
         *      function to validate student name is valid and not empty
         * **/
        private bool validateName()
        {
            bool isValid = txt_name.Text.TrimEnd() != "";
            lbl_error_name.Visible = !isValid; //visivle if txt_name.Text is empty
            return isValid;
        }

        /**
         * Summary:
         *      function to validate phone number is valid and not empty
         * **/
        private bool validatePhone(TextBox txtPhone, Label lbl_err)
        {
            if (txtPhone.Text.Length != 11)
            {
                lbl_err.Visible = true;
                return false;
            }

            switch (txtPhone.Text.Substring(0, 3))
            {
                case "011":
                case "010":
                case "015":
                case "012":
                    lbl_err.Visible = false;
                    return true;
                default:
                    lbl_err.Visible = true;
                    return false;
            }
        }
       
        /**
         * Summary:
         *      KeyPress event for txt_phone and txt_parent_phone
         *      to prevent any character than numbers and "." to be writter
         *      ==> to make their input in numbers and "." only
         * **/
        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_code_MouseClick(object sender, MouseEventArgs e)
        {
            parentForm.AcceptButton = btn_edit;
        }

        private void txt_propertise_mouse_click(object sender, MouseEventArgs e)
        {
            parentForm.AcceptButton = btn_add_student;
        }
        
        private void handleNullError(Exception e)
        {
            if (excel == null)
            {
                MessageBox.Show("Must provide excel file");
            }

            else
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}