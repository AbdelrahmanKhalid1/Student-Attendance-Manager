using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Team.models
{
    class Student
    {
        public readonly String id;
        public String name;
        public String phone, parentPhone;
        public Group group; 
        public String[,] quizResults, examResults;

        public Student(String id, String name, Group group)
        {
            this.id = id;
            this.name = name;
            this.group = group;
        }

        public Student(String id, String name, String phone, Group group)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.group = group;
        }

        public Student(String id, String name, String phone, String parentPhone, Group group)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.parentPhone = parentPhone;
            this.group = group;
        }

        public String printData()
        {
            return "id: " + id + "\nname: " + name + "\n" +
                "phone number: " + phone + "\nparent number: " + parentPhone + "\n";
        }
    }

    public class Group
    {
        public string centerName;
        public string day;
        //public string appointment;

        public Group(string centerName, string day)
        {
            this.centerName = centerName;
            this.day = day;
        }
    }

    /*public class Attendance
    {
        public Group group;
        public string date;
        public string quizGrade;

        public Attendance(Group group, string date, string quizGrade)
        {
            this.group = group;
            this.date = date;
            this.quizGrade = quizGrade;
        }
    }*/
}
