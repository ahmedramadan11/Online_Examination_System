using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class frmInstr : Form
    {
        public frmInstr()
        {
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
    }
}
