using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class frmInstr : Form
    {

        User currentUser;
        public frmInstr(User u)
        {
            currentUser = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewReport.getDepratmentStudentsInput frmReport = new NewReport.getDepratmentStudentsInput();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewReport._2.getSutdentgradesInput frmReport = new NewReport._2.getSutdentgradesInput();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewReport.getCourseTopicsInput frmReport = new NewReport.getCourseTopicsInput();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewReport.getStudentAnswersInput frmReport = new NewReport.getStudentAnswersInput();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            NewReport.NCourse_NumStudInput frmReport = new NewReport.NCourse_NumStudInput();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();

        }

        private void frmInstr_Load(object sender, EventArgs e)
        {
           

            DataTable dt = UserManager.selectInsCourse(currentUser.UID);

        
            courseCombo.DataSource = dt;
            courseCombo2.DataSource = dt;

            courseCombo.DisplayMember = "Cname";
            courseCombo.ValueMember = "CID";

            courseCombo2.DisplayMember = "Cname";
            courseCombo2.ValueMember = "CID";



        }

        private void button7_Click(object sender, EventArgs e)
        {

            int cId = Convert.ToInt32(courseCombo.SelectedValue);

            int examId = 0;
            examId = UserManager.generate_Exam(cId);

            DataTable dt = UserManager.selectCourseStudents(cId);

            foreach(DataRow item in dt.Rows)
            {
                int studId = Convert.ToInt32(item["SID"]);
                UserManager.Insert_Student_EXAM_Course(studId,examId, cId);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            NewReport.getExamQuestionsInput frmReport =new NewReport.getExamQuestionsInput();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {

            string topic = txtTopic.Text;
            int cId = Convert.ToInt32(courseCombo2.SelectedValue);
            int result = UserManager.addNewTopic(cId, topic);
            if(result == -1){
                MessageBox.Show("Topic found before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Topic Added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void courseCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
         


            /* im here*/

        }

        private void courseCombo2_SelectedValueChanged(object sender, EventArgs e)
        {
            
        

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
