using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            openFD.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\data";
            openFD.ShowDialog();
            try
            {
                Excel.newInstance(openFD.FileName);
            }
            catch (Exception)
            {/*case user dose not select any excel file*/ }
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
            if(selectedMenuButton != null)
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
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button != selectedMenuButton)
                button.BackColor = BG_UNSELECTED_MENU;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = BG_SELECTED_MENU;
        }

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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
