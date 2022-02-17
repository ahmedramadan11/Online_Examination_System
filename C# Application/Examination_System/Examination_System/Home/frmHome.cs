using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Diagnostics;

namespace Examination_System.Home
{
    public partial class frmHome : Form
    {
        public User CurrentUser { get; set; }
        StudentCourseList studentCourseList;
        DataGridViewButtonColumn btnStartExam;

        public frmHome(User _cUser)
        {
            InitializeComponent();
            CurrentUser = _cUser;
            studentCourseList = new StudentCourseList();
            btnStartExam = new DataGridViewButtonColumn();
            btnStartExam.HeaderText = "Start Exam";
            btnStartExam.Text = "Start Now";
            btnStartExam.UseColumnTextForButtonValue = true;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            studentCourseList = StudentCourseManager.SelectAllStudentCourse(CurrentUser.UID);
            grdStudentCourse.DataSource = studentCourseList;
            grdStudentCourse.Columns[0].Visible = false;
            grdStudentCourse.Columns[1].Visible = false;
            grdStudentCourse.Columns[2].Visible = false;

            // Add new Column
            grdStudentCourse.Columns.Add(btnStartExam);

        }

        private void grdStudentCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                int examID = (int)senderGrid.Rows[e.RowIndex].Cells[2].Value;
                Exam.frmExam frmExam = new Exam.frmExam(CurrentUser, examID);
                this.Hide();
                frmExam.ShowDialog();
                this.Show();
            }
        }
    }
}
