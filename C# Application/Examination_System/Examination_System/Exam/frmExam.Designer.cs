namespace Examination_System.Exam
{
    partial class frmExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cmbAnswers = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.lblChoice1 = new System.Windows.Forms.Label();
            this.lblChoice2 = new System.Windows.Forms.Label();
            this.lblChoice3 = new System.Windows.Forms.Label();
            this.lblChoice4 = new System.Windows.Forms.Label();
            this.lblChoice4Num = new System.Windows.Forms.Label();
            this.lblChoice3Num = new System.Windows.Forms.Label();
            this.lblChoice2Num = new System.Windows.Forms.Label();
            this.lblChoice1Num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(227, 83);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(38, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.Location = new System.Drawing.Point(227, 272);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(51, 15);
            this.lblAnswers.TabIndex = 1;
            this.lblAnswers.Text = "Answers";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(397, 338);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(259, 338);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Previos";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // cmbAnswers
            // 
            this.cmbAnswers.FormattingEnabled = true;
            this.cmbAnswers.Location = new System.Drawing.Point(227, 290);
            this.cmbAnswers.Name = "cmbAnswers";
            this.cmbAnswers.Size = new System.Drawing.Size(268, 23);
            this.cmbAnswers.TabIndex = 4;
            this.cmbAnswers.DropDownClosed += new System.EventHandler(this.cmbAnswers_DropDownClosed);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(693, 415);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "End Exam";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.Location = new System.Drawing.Point(227, 53);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(102, 15);
            this.lblQuestionNum.TabIndex = 6;
            this.lblQuestionNum.Text = "Question Number";
            // 
            // lblChoice1
            // 
            this.lblChoice1.AutoSize = true;
            this.lblChoice1.Location = new System.Drawing.Point(335, 146);
            this.lblChoice1.Name = "lblChoice1";
            this.lblChoice1.Size = new System.Drawing.Size(38, 15);
            this.lblChoice1.TabIndex = 7;
            this.lblChoice1.Text = "label1";
            // 
            // lblChoice2
            // 
            this.lblChoice2.AutoSize = true;
            this.lblChoice2.Location = new System.Drawing.Point(335, 181);
            this.lblChoice2.Name = "lblChoice2";
            this.lblChoice2.Size = new System.Drawing.Size(38, 15);
            this.lblChoice2.TabIndex = 8;
            this.lblChoice2.Text = "label2";
            // 
            // lblChoice3
            // 
            this.lblChoice3.AutoSize = true;
            this.lblChoice3.Location = new System.Drawing.Point(335, 210);
            this.lblChoice3.Name = "lblChoice3";
            this.lblChoice3.Size = new System.Drawing.Size(38, 15);
            this.lblChoice3.TabIndex = 9;
            this.lblChoice3.Text = "label3";
            // 
            // lblChoice4
            // 
            this.lblChoice4.AutoSize = true;
            this.lblChoice4.Location = new System.Drawing.Point(335, 244);
            this.lblChoice4.Name = "lblChoice4";
            this.lblChoice4.Size = new System.Drawing.Size(38, 15);
            this.lblChoice4.TabIndex = 10;
            this.lblChoice4.Text = "label4";
            // 
            // lblChoice4Num
            // 
            this.lblChoice4Num.AutoSize = true;
            this.lblChoice4Num.Location = new System.Drawing.Point(240, 244);
            this.lblChoice4Num.Name = "lblChoice4Num";
            this.lblChoice4Num.Size = new System.Drawing.Size(15, 15);
            this.lblChoice4Num.TabIndex = 18;
            this.lblChoice4Num.Text = "D";
            // 
            // lblChoice3Num
            // 
            this.lblChoice3Num.AutoSize = true;
            this.lblChoice3Num.Location = new System.Drawing.Point(240, 210);
            this.lblChoice3Num.Name = "lblChoice3Num";
            this.lblChoice3Num.Size = new System.Drawing.Size(15, 15);
            this.lblChoice3Num.TabIndex = 17;
            this.lblChoice3Num.Text = "C";
            // 
            // lblChoice2Num
            // 
            this.lblChoice2Num.AutoSize = true;
            this.lblChoice2Num.Location = new System.Drawing.Point(240, 181);
            this.lblChoice2Num.Name = "lblChoice2Num";
            this.lblChoice2Num.Size = new System.Drawing.Size(14, 15);
            this.lblChoice2Num.TabIndex = 16;
            this.lblChoice2Num.Text = "B";
            // 
            // lblChoice1Num
            // 
            this.lblChoice1Num.AutoSize = true;
            this.lblChoice1Num.Location = new System.Drawing.Point(240, 146);
            this.lblChoice1Num.Name = "lblChoice1Num";
            this.lblChoice1Num.Size = new System.Drawing.Size(15, 15);
            this.lblChoice1Num.TabIndex = 15;
            this.lblChoice1Num.Text = "A";
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChoice4Num);
            this.Controls.Add(this.lblChoice3Num);
            this.Controls.Add(this.lblChoice2Num);
            this.Controls.Add(this.lblChoice1Num);
            this.Controls.Add(this.lblChoice4);
            this.Controls.Add(this.lblChoice3);
            this.Controls.Add(this.lblChoice2);
            this.Controls.Add(this.lblChoice1);
            this.Controls.Add(this.lblQuestionNum);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.cmbAnswers);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmExam";
            this.Text = "frmExam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExam_FormClosed);
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQuestion;
        private Label lblAnswers;
        private Button btnNext;
        private Button btnPrev;
        private ComboBox cmbAnswers;
        private Button btnFinish;
        private Label lblQuestionNum;
        private Label lblChoice1;
        private Label lblChoice2;
        private Label lblChoice3;
        private Label lblChoice4;
        private Label lblChoice4Num;
        private Label lblChoice3Num;
        private Label lblChoice2Num;
        private Label lblChoice1Num;
    }
}