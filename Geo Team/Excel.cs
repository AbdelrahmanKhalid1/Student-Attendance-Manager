using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Geo_Team.models;
using System.Windows.Forms;

namespace Geo_Team
{
    class Excel
    {
        private Microsoft.Office.Interop.Excel.Application excelFile;
        private Workbook workbook;
        private Worksheet worksheet;
        private static Excel instance = null;

        private Excel(String path)
        {
            excelFile = new Microsoft.Office.Interop.Excel.Application();
            workbook = excelFile.Workbooks.Open(path);
        }

        public List<Student> getAllStudents()
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_INFO];
            List<Student> students = new List<Student>();
            int lastUsedRow = worksheet.Columns[1].find("").Row; //to get index of an empty cell represent last row used
            Range cells = worksheet.Cells;

            for (int row = 2; row < lastUsedRow; row++)
            {
                Group group = new Group(cells[row, 6].Text, cells[row, 5].Text);
                students.Add(new Student(cells[row, 1].Text, cells[row, 2].Text,
                    cells[row, 3].Text, cells[row, 4].Text, group));
            }
            return students;
        }

        #region loadData
        /**
         * Summary
         *      function get student info, exam and quizzes results
         *
         * returns Student
         **/
        public Student getStudentByCode(String studentCode)
        {
            Student stu = getStudentInfo(studentCode);
            //stu.attendance = getStudentAttendance(studentCode, stu.group);
            stu.quizResults = getStudentQuizResults(studentCode);
            stu.examResults = getStudentExamResults(studentCode);
           return stu;
        }


        public Student getStudentInfo(String studentCode)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_INFO];
            Range findResult = worksheet.Columns[Utlis.STUDENT_CODE_COLUMN_INDEX].Find(studentCode);
            if (findResult == null)
                throw new NullReferenceException("Student code not found or not exist");

            int rowIndex = findResult.Row;
            Range cells = worksheet.Cells;

            //for(int i=1;i<worksheet.UsedRange.Columns.Count; i++)
            //string[] groupStr = cells[rowIndex, 5].Text.Split("/"); // day/appointment ==> day at 0, appointment at 1
            Group group = new Group(cells[rowIndex, 6].Text, cells[rowIndex, 5].Text);

            Student stu = new Student(cells[rowIndex, 1].Text, cells[rowIndex, 2].Text,
                cells[rowIndex, 3].Text, cells[rowIndex, 4].Text, group);
            return stu;
        }

        public String[,] getStudentQuizResults(String studentCode)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_ATTENDANCE];
            Range findResult = worksheet.Rows[Utlis.STUDENT_CODE_ROW_INDEX].Find(studentCode);

            if (findResult != null)
            {
                return buildExamResultsMatrix(findResult.Column);
            }
            return null;
        }

        public String[,] getStudentExamResults(String studentCode)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_EXAM_RESULTS];
            Range findResult = worksheet.Rows[Utlis.STUDENT_CODE_ROW_INDEX].Find(studentCode);

            if (findResult != null)
            {
                return buildExamResultsMatrix(findResult.Column);
            }
            return null;
        }

        private String[,] buildExamResultsMatrix(int colIndex)
        {
            int lastUsedRow = worksheet.Columns[1].find("").Row; //to get index of an empty cell represent last row used
            Range cells = worksheet.Cells;
            String[,] results = new string[lastUsedRow - 2, 2]; //-2 to remove first row (header) and unused row (last row)

            for (int row = 0; row < lastUsedRow - 2; row++)
            {
                results[row, 0] = cells[row + 2, 1].Text; //set date of class (quiz)
                results[row, 1] = cells[row + 2, colIndex].Text; //set quiz grade (score)
                if (results[row, 1] == "")
                    results[row, 1] = Utlis.NOT_ATTENDED;
                
            }
            return results;
        }
        #endregion

        #region modifyData
        #region modifyStudentData
        public int addNewStudent(string name, string phone, string parentPhone, string groupDay, string centerName)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_INFO];
            int firstEmptyRowIndex = worksheet.Columns[1].find("").Row;
            
            //get last code and increment it to generate new code
            string lastStudentCode = worksheet.Cells[firstEmptyRowIndex - 1, Utlis.STUDENT_CODE_COLUMN_INDEX].Text;
            if(lastStudentCode == "code")
            {
                lastStudentCode = "500";
            }
            int newStudentCode = int.Parse(lastStudentCode) + 1;

            //save new student data in excel sheet [Info]
            worksheet.Cells[firstEmptyRowIndex, 1].Value = newStudentCode; //save code
            worksheet.Cells[firstEmptyRowIndex, 2].Value = name; //save student name
            worksheet.Cells[firstEmptyRowIndex, 3].Value = phone; //save student phone number
            worksheet.Cells[firstEmptyRowIndex, 4].Value = parentPhone; //save student parent phone number
            worksheet.Cells[firstEmptyRowIndex, 5].Value = groupDay; //save student group day
            worksheet.Cells[firstEmptyRowIndex, 6].Value = centerName; //save student center name

            //add new studnet code in attendace sheet [Attendace]
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_ATTENDANCE];
            int firstEmptyColIndex = worksheet.Rows[1].find("").Column;
            worksheet.Cells[1, firstEmptyColIndex].Value = newStudentCode;

            //add new studnet code in monthly exam sheet [Monthly Exam]
            //no need to find first empty col index as they have the same number of columns
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_EXAM_RESULTS];
            worksheet.Cells[1, firstEmptyColIndex].Value = newStudentCode;

            workbook.Save();
            return newStudentCode;
        }

        public bool updateStudent(string code, string name, string phone, string parentPhone, string groupDay, string centerName)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_INFO];
            int rowIndex = worksheet.Columns[1].find(code).Row; //get student data position in excell file

            //save new student data in excel sheet
            worksheet.Cells[rowIndex, 1].Value = code; //save code
            worksheet.Cells[rowIndex, 2].Value = name; //save student name
            worksheet.Cells[rowIndex, 3].Value = phone; //save student phone number
            worksheet.Cells[rowIndex, 4].Value = parentPhone; //save student parent phone number
            worksheet.Cells[rowIndex, 5].Value = groupDay; //save student group day
            worksheet.Cells[rowIndex, 6].Value = centerName; //save student center name

            workbook.Save();
            return true;
        }
        #endregion
        #region modifyExamData
        public bool addNewAttendanceData(string date, DataGridViewRowCollection rows) //rows.Cells[] ==> 0 for code, 1 for grade
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_ATTENDANCE];
            int firstEmptyRowIndex = worksheet.Columns[1].find("").Row;

            //save new attendance data in excel sheet
            worksheet.Cells[firstEmptyRowIndex, Utlis.ATTENDANCE_DATE_COLUMN_INDEX].Value = date; //save date
            addExamGrades(firstEmptyRowIndex, rows);

            workbook.Save();
            return true;
        }

        public bool addNewMonthlyExam(string date, DataGridViewRowCollection rows)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_EXAM_RESULTS];
            int firstEmptyRowIndex = worksheet.Columns[1].find("").Row;
            
            //save new monthly exam results in excel sheet
            worksheet.Cells[firstEmptyRowIndex, 1].Value = date; //save date
            addExamGrades(firstEmptyRowIndex, rows);

            workbook.Save();
            return true;
        }

        private void addExamGrades(int firstEmptyRowIndex, DataGridViewRowCollection rows)
        {
            for (int row = 0; row < rows.Count - 1; row++)
            {
                Range findResult = worksheet.Rows[Utlis.STUDENT_CODE_ROW_INDEX].find(rows[row].Cells[0].Value);
                if (findResult == null)
                {
                    Range studentInfoSearchResult = workbook.Worksheets[Utlis.SHEET_STUDENT_INFO].find(rows[row].Cells[0].Value);
                    if (studentInfoSearchResult == null)
                        throw new NullReferenceException("No student with code " + rows[row].Cells[0].Value + " is found");
                }

                int colIndex = findResult.Column;
                worksheet.Cells[firstEmptyRowIndex, colIndex].Value = rows[row].Cells[1].Value; //save Results
            }
        }
        #endregion
        #endregion

        public void closeExcel(){ workbook.Close();}

        public static Excel newInstance(String path)
        {
            if (instance == null)
                instance = new Excel(path);
            else if(instance.workbook.Path != path)
            {
                instance.workbook.Save();
                instance.closeExcel();
            }
            return instance;
        }

        public static Excel getInstance()
        {
            if (instance == null)
                throw new NullReferenceException("You must provide Excel folder path");
            return instance;
        }
    }
}
/*
        public String[,] getStudentQuizResults(String studentCode)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_QUIZ_RESULTS];
            Range findResult = worksheet.Rows[Utlis.STUDENT_CODE_ROW_INDEX].Find(studentCode);

            if (findResult != null)
            {
                return buildExamResultsMatrix(findResult.Column);
            }
            return null;
        }
*/

    /*
     
        public List<Attendance> getStudentAttendance(String studentCode, Group studentGroup)
        {
            worksheet = workbook.Worksheets[Utlis.SHEET_STUDENT_ATTENDANCE];
            Range findResult = worksheet.Rows[Utlis.STUDENT_CODE_ROW_INDEX].Find(studentCode);

            if (findResult != null)
            {
                int colIndex = findResult.Column;
                int lastUsedRow = worksheet.Columns[1].find("").Row; //to get index of an empty cell represent last row used
                Range cells = worksheet.Cells;
                List<Attendance> results = new List<Attendance>();

                for (int row = 0; row < lastUsedRow - 2; row++)
                {
                    try
                    {
                        Attendance attendance = new Attendance(studentGroup, cells[row, Utlis.ATTENDANCE_DATE_COLUMN_INDEX].Text, cells[row + 2, 1].Text);
                        results.Add(attendance);
                        /*
                        //chech if this is current student group 
                        if (cells[row, Utlis.ATTENDANCE_DAY_COLUMN_INDEX].Text == studentGroup.day &&
                            cells[row, Utlis.ATTENDANCE_CENTER_NAME_COLUMN_INDEX].Text == studentGroup.centerName)
                        {
                            Attendance attendance = new Attendance(studentGroup, cells[row, Utlis.ATTENDANCE_DATE_COLUMN_INDEX].Text, cells[row + 2, 1].Text);
                            results.Add(attendance);    
                        }
                        /*
                        //case student has quiz result as if he attended in different group
                        else if (cells[row + 2, 1].Text != Utlis.NOT_GROUP)
                        {
                            Attendance attendance = new Attendance(new Group(attendanceStr[3], attendanceStr[0], attendanceStr[1]), 
                                attendanceStr[2], cells[row + 2, colIndex].Text);
                            results.Add(attendance);
                        }
                        
                    }
                    catch //if new student is added will have not taken any exams
                    {
                        
                    }
                }
                return results;
            }
            return null;
        }
     */