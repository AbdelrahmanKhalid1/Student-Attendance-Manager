using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Geo_Team
{
    public partial class FormMain : Form
    {
        public const int WIDTH_COLLAPSE_RATE = 15;
        public static readonly Color BG_SELECTED_MENU = Color.NavajoWhite;
        public static readonly Color BG_UNSELECTED_MENU = Color.Transparent;

        private Button selectedMenuButton;
        private int panelNavOriginalWidth;
        private bool isCollapsed;

        #region Init
        public FormMain()
        {
            InitializeComponent();
            timerTime.Start();

            panelNavOriginalWidth = panel_nav.Width;
            isCollapsed = false;
        }

        /**
         * Summary
         *      After Form is completly loaded open dialog to select excel file to read
         * */
        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                openExcelFile();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Navigation
        private void btn_view_student_Click(object sender, EventArgs e)
        {
            unselectMenuButton(sender);
            navNewDestination(new UserControlStudentMarks(this));
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            unselectMenuButton(sender);
            navNewDestination(new UserControlAllStudents());
        }

        private void btn_add_quiz_Click(object sender, EventArgs e)
        {
            unselectMenuButton(sender);
            navNewDestination(new UserControlAddExam(this));
        }

        private void btn_add_new_student_Click(object sender, EventArgs e)
        {
            unselectMenuButton(sender);
            navNewDestination(new UserControlAddStudent(this));
        }

        private void unselectMenuButton(object newSelectedMenuButton)
        {
            if (selectedMenuButton != null)
                selectedMenuButton.BackColor = BG_UNSELECTED_MENU;
            selectedMenuButton = newSelectedMenuButton as Button;
            selectedMenuButton.BackColor = BG_SELECTED_MENU;
        }

        private void navNewDestination(UserControl userControl)
        {
            panel_container.Controls.Clear();
            AcceptButton = null;
            panel_container.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
        #endregion

        #region animation
        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                while (panel_nav.Width <= panelNavOriginalWidth)
                {
                    panel_nav.Width += WIDTH_COLLAPSE_RATE;
                    this.Refresh();
                }
                isCollapsed = false;
            }
            else
            {
                while (panel_nav.Width >= 80)
                {
                    panel_nav.Width -= WIDTH_COLLAPSE_RATE;
                    this.Refresh();

                }
                isCollapsed = true;
            }
        }
        #endregion

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btn_open_excel_Click(object sender, EventArgs e)
        {
            try
            {
                openExcelFile();
            }
            catch{ }
        }

        private void loadExcelSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openExcelFile();
            }
            catch { }
        }

        private void createNewExcelSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceFile = Environment.CurrentDirectory + @"\Student Sheet Template.xlsx";
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Office |*.xls; *.xlsx";
                saveFileDialog.FileName = "Student Sheet 20XX.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(sourceFile, saveFileDialog.FileName);
                }
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openExcelFile()
        {
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(openFD.ShowDialog() == DialogResult.OK)
                Excel.newInstance(openFD.FileName);
        }
    }
}
