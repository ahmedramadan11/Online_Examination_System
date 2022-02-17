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
        DataTable questionChoicesTable;
        BindingSource bindingSourceExamDetails;
        BindingSource comboDataBinding;
        
        public User CurrentUser { get; set; }
        public int ExamID { get; set; }

        public frmExam(User _currentUser, int _examID)
        {
            InitializeComponent();
            bindingSourceExamDetails = new BindingSource();
            comboDataBinding = new BindingSource();

            CurrentUser = _currentUser;
            ExamID = _examID;
        }

        private void frmExam_Load(object sender, EventArgs e)
        {

            examDetailsTable = ExamDetailsManager.SelectExamDetails(ExamID);
            bindingSourceExamDetails.DataSource = examDetailsTable;

            lblQuestionNum.Text = "1";
            lblQuestion.DataBindings.Add("Text", bindingSourceExamDetails, "QDescription");

            DataRowView exam = (DataRowView)bindingSourceExamDetails.Current;
            ShowAnswers(exam);

            cmbAnswers.DataSource = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]); ;
            cmbAnswers.DisplayMember = "Description";
            cmbAnswers.ValueMember = "ChoiceNum";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            int index = bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current);
            if (index < bindingSourceExamDetails.Count - 1)
            {

                bindingSourceExamDetails.MoveNext();
                lblQuestionNum.Text = (bindingSourceExamDetails.IndexOf(bindingSourceExamDetails.Current) + 1).ToString();

                DataRowView exam = (DataRowView)bindingSourceExamDetails.Current;

                ShowAnswers(exam);

                cmbAnswers.DataSource = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]); ;
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
                ShowAnswers(exam);

                cmbAnswers.DataSource = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]);
                cmbAnswers.DisplayMember = "Description";
                cmbAnswers.ValueMember = "ChoiceNum";
            }


            
        }

        private void ShowAnswers(DataRowView exam)
        {
            if (exam.Row["QType"].Equals("2"))
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
                questionChoicesTable = QuestionChoiceManager.SelectQuestionChoice((int)exam.Row["QID"]);

                lblChoice3.Visible = true;
                lblChoice4.Visible = true;

                lblChoice3Num.Visible = true;
                lblChoice4Num.Visible = true;

                lblChoice1.Text = questionChoicesTable.Rows[0]["Description"].ToString();
                lblChoice2.Text = questionChoicesTable.Rows[1]["Description"].ToString();
                lblChoice3.Text = questionChoicesTable.Rows[2]["Description"].ToString();
                lblChoice4.Text = questionChoicesTable.Rows[3]["Description"].ToString();

                

                questionChoicesTable.Clear();
            }
        }
    }
}
