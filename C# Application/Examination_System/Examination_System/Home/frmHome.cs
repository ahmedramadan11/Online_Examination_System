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

namespace Examination_System.Home
{
    public partial class frmHome : Form
    {
        public User CurrentUser { get; set; }
        StudentCourseList studentCourseList;
        public frmHome(User _cUser)
        {
            InitializeComponent();
            CurrentUser = _cUser;
            studentCourseList = new StudentCourseList();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            studentCourseList = StudentCourseManager.SelectAllStudentCourse();
            grdStudentCourse.DataSource = studentCourseList;
        }
    }
}
