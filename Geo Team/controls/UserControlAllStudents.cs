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
    public partial class UserControlAllStudents : UserControl
    {
        public UserControlAllStudents()
        {
            InitializeComponent();
            dgv_students.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void UserControlAllStudents_Load(object sender, EventArgs e)
        {
            try
            {
                Excel excel = Excel.getInstance(); //throws null
                List<Student> students = excel.getAllStudents();
                if (students.Count == 0)
                    throw new Exception("No students were found");

                foreach(Student stu in students)
                    dgv_students.Rows.Add(stu.id, stu.name, stu.phone, stu.parentPhone, stu.group.day, stu.group.centerName);
                
            }
            catch (NullReferenceException ignore)
            {
                MessageBox.Show(ignore.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ignore)
            {
                MessageBox.Show(ignore.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
