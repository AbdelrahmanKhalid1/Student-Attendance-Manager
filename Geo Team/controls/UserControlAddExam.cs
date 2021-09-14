using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo_Team
{
    public partial class UserControlAddExam : UserControl
    {
        private Form parentForm;
        private Excel excel;

        public UserControlAddExam(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            

            //to fix text colors in dataGridView and radio buttons
            //set ForeColor to black or normal text color
            dgv_exams.DefaultCellStyle.ForeColor = Color.Black;
            radio_exam.ForeColor = Color.Black;
            radio_quiz.ForeColor = Color.Black;
        }

        private void txt_mouse_click(object sender, MouseEventArgs e)
        {
            parentForm.AcceptButton = btn_save;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validateTextBox())
            {
                if (radio_quiz.Checked)
                {
                    Excel.getInstance().addNewAttendanceData(txt_date.Text, txt_day.Text, txt_mark.Text, dgv_exams.Rows);
                }
                else 
                {
                    Excel.getInstance().addNewMonthlyExam(txt_date.Text, txt_mark.Text, dgv_exams.Rows);
                }
            }
        }

        private bool validateTextBox()
        {
            if(txt_date.Text == "")
            {
                MessageBox.Show("Date Can't be empty!");
                return false;
            }
            else if(txt_day.Text == "" || !validateDays())
            {
                MessageBox.Show("Day Can't be empty!");
                return false;
            }
            else if(txt_mark.Text == "" /*|| validateMarks()*/) //validateMarks if a function to validate exam marks if text is all zeroes or there is zeroes at the start of number but not float
            {
                MessageBox.Show("Exam mark Can't be empty!");
                return false;
            }
            else if(!radio_exam.Checked && !radio_quiz.Checked) //radio buttons not checked
            {
                MessageBox.Show("Please Choose type of exam (quiz, monthly)!");
                return false;
            }
            else if (dgv_exams.Rows.Count == 1) //no student code is added to datagridview
            {
                MessageBox.Show("No Student code is added to table!");
                return false;
            }

            return true;
        }

        private bool validateDays()
        {
            switch (txt_day.Text.ToLower())
            {
                case "saturday":
                case "sat":
                case "sunday":
                case "sun":
                case "monday":
                case "mon":
                case "tuesday":
                case "tue":
                case "wednesday":
                case "wed":
                case "thursday":
                case "thu":
                case "thur":
                case "friday":
                case "fri":
                    return true;
            }
            return false;
        }

        /**
         * Summary
         *      converts data in dataGridView from rows and columns to matix of string
         *      [date, grade]
         * **/
        private string[] prepareData()
        {
            MessageBox.Show("" + dgv_exams.RowCount);
            //dgv_exams.Rows[0].Cells[]
            int rowSize = dgv_exams.RowCount - 1;// -1 to remove last empty row
            string[,] grades = new string[rowSize, 2];

            return null;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //clear all data
            txt_date.Text = "";
            txt_day.Text = "";
            txt_mark.Text = "";
            dgv_exams.Rows.Clear();
        }

        private void txt_date_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_mark_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }
    }
}
