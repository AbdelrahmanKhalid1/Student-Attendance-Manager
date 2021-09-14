using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Team
{
    class Utlis
    {
        //Sheet names in excel file
        public const String SHEET_STUDENT_INFO = "Info";
        public const String SHEET_STUDENT_EXAM_RESULTS = "Monthly Exams";
        public const String SHEET_STUDENT_ATTENDANCE = "Attendance";

        //Const Rows values
        public const int STUDENT_CODE_ROW_INDEX = 1; //code row index in monthly exams and quizzes

        //Const Cols values
        public const int STUDENT_CODE_COLUMN_INDEX = 1; //code col index in student info sheet
        public const int QUIZ_DATE_COLUMN_INDEX = 1; //index in monthly exams and quizzes sheets

        //Const Attendance Values
        public const int ATTENDANCE_DAY_COLUMN_INDEX = 1;
        public const int ATTENDANCE_TIME_COLUMN_INDEX = 2;
        public const int ATTENDANCE_DATE_COLUMN_INDEX = 3;
        public const int ATTENDANCE_CENTER_NAME_COLUMN_INDEX = 4;
        public const string NOT_ATTENDED = "DID NOT ATTEND";
        public const string DID_NOT_TAKE_EXAM = "NO_RESULT";
    }
}
