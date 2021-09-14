using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Geo_Team.models;
using Microsoft.Office.Interop.Excel;

namespace Geo_Team
{
    public partial class UserControlStudentMarks : UserControl
    {
        private Form parentForm;
        private Excel excel;
        private Student student;

        public UserControlStudentMarks(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                excel = Excel.getInstance();
                student = excel.getStudentByCode(txt_code.Text);
                setUpUi();
            }
            catch (Exception e)
            {
                handleNullError(e);
            }
        }

        private void setUpUi()
        {
            setLabels();
            setDataGridViews();
        }
        private void setLabels()
        {
            lbl_name.Text = "Student Name: " + student.name;
            //lbl_attendance.Text = "Student Attendance: " + student
            lbl_phone.Text = "Student Phone: " + student.phone;
            lbl_parent_phone.Text = "Parent Phone: " + student.parentPhone;
        }
        private void setDataGridViews()
        {
            dgv_quizes.Rows.Clear();
            dgv_exams.Rows.Clear();

            for (int i = 0; i < student.quizResults.GetLength(0); i++)
                dgv_quizes.Rows.Add(student.quizResults[i, 0], student.quizResults[i, 1]);

            for (int i = 0; i < student.examResults.GetLength(0); i++)
                dgv_quizes.Rows.Add(student.examResults[i, 0], student.examResults[i, 1]);
        }

        private void handleNullError(Exception e)
        {
            if (student == null)
            {
                MessageBox.Show(e.Message);
            }
            else if (student.quizResults == null)
            {
                MessageBox.Show("Student " + student.name + " has not taken any quizzes");
            }
            else if (student.examResults == null)
            {
                MessageBox.Show("Student " + student.name + " has not taken any monthly exams");
            }
        }

        private void txt_code_MouseClick(object sender, MouseEventArgs e)
        {
            parentForm.AcceptButton = btn_find;
        }
    }
}
