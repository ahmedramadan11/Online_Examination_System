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

namespace Examination_System.Exam
{
    public partial class frmExam : Form
    {
        DataTable examDetailsTable;
        DataTable questionChoiceTable;
        QuestionChoiceList questionChoicesList;
        BindingSource bindingSourceExamDetails;
        string[] examAnswers;
        
        public User CurrentUser { get; set; }
        public int ExamID { get; set; }
        public int CourseID { get; set; }

        public frmExam(User _currentUser, int _examID, int _courseID)
        {
            InitializeComponent();
            bindingSourceExamDetails = new BindingSource();
            questionChoicesList = new QuestionChoiceList();
            examDetailsTable = new DataTable();
            questionChoiceTable = new DataTable();
            examAnswers = new string[10];

            for (int i = 0; i < examAnswers.Length; i++)
            {
                examAnswers[i] = "A";
            }

            CurrentUser = _currentUser;
            ExamID = _examID;
            CourseID = _courseID;

            Trace.WriteLine(ExamID);
        }

        private void frmExam_Load(object sender, EventArgs e)
        {

            examDetailsTable = ExamDetailsManager.SelectExamDetails(ExamID);
            bindingSourceExamDetails.DataSource = examDetailsTable;

            lblQuestionNum.Text = "1";
            lblQuestion.DataBindings.Add("Text", bindingSourceExamDetails, "QDescription");

            DataRowView exam = (DataRowView)bindingSourceExamDetails.Current;


            questionChoicesList = QuestionChoiceManager.SelectQuestionChoice();


            var result = questionChoicesList.Where((Q) => Q.QID == (int)exam.Row["QID"]).ToList();

            cmbAnswers.DataSource = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]);
            cmbAnswers.DisplayMember = "Description";
            cmbAnswers.ValueMember = "ChoiceNum";

            ShowAnswers(exam, result);
        }



        private void btnNext_Click(object sender, EventArgs e)
        {

            int index = bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current);
            if (index < bindingSourceExamDetails.Count - 1)
            {

                bindingSourceExamDetails.MoveNext();
                lblQuestionNum.Text = (bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current) + 1).ToString();

                DataRowView exam = (DataRowView)bindingSourceExamDetails.Current;


                questionChoicesList = QuestionChoiceManager.SelectQuestionChoice();


                var result = questionChoicesList.Where((Q) => Q.QID == (int)exam.Row["QID"]).ToList();
                ShowAnswers(exam, result);


                cmbAnswers.DataSource = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]);
                cmbAnswers.DisplayMember = "Description";
                cmbAnswers.ValueMember = "ChoiceNum";
            }

            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int index = bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current);
            if (index != 0)
            {

                bindingSourceExamDetails.MovePrevious();
                lblQuestionNum.Text = (bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current) + 1).ToString();

                DataRowView exam = (DataRowView)bindingSourceExamDetails.Current;
                questionChoicesList = QuestionChoiceManager.SelectQuestionChoice();
                questionChoiceTable = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]);


                Trace.WriteLine(questionChoiceTable.Rows[0].ToString());

                var result = questionChoicesList.Where((Q) => Q.QID == (int)exam.Row["QID"]).ToList();

                ShowAnswers(exam, result);


                cmbAnswers.DataSource = questionChoiceTable;
                cmbAnswers.DisplayMember = "Description";
                cmbAnswers.ValueMember = "ChoiceNum";
            }


            
        }

        private void ShowAnswers(DataRowView currentExam, List<QuestionChoice> _questionChoiceList)
        {
            if (currentExam.Row["QType"].Equals("2"))
            {
                lblChoice1.Text = "True";
                lblChoice2.Text = "False";

                lblChoice3.Visible = false;
                lblChoice4.Visible = false;

                lblChoice3Num.Visible = false;
                lblChoice4Num.Visible = false;
            }
            else
            {

                lblChoice3.Visible = true;
                lblChoice4.Visible = true;

                lblChoice3Num.Visible = true;
                lblChoice4Num.Visible = true;


                lblChoice1.Text = _questionChoiceList[0].Description;
                lblChoice2.Text = _questionChoiceList[1].Description;
                lblChoice3.Text = _questionChoiceList[2].Description;
                lblChoice4.Text = _questionChoiceList[3].Description;

                _questionChoiceList.Clear();
            }
        }

        private void frmExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }


        private void cmbAnswers_DropDownClosed(object sender, EventArgs e)
        {

            int index = bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current);
            examAnswers[index] = (string)cmbAnswers.SelectedValue;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int result = StudentCourseManager.ExamAnswer(ExamID, CurrentUser.UID, CourseID, examAnswers);

            Trace.WriteLine(result);
        }
    }
}
