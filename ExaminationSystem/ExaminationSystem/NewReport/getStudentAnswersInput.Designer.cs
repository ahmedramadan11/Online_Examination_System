
namespace ExaminationSystem.NewReport
{
    partial class getStudentAnswersInput
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
            this.txtExamID = new System.Windows.Forms.TextBox();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExamID
            // 
            this.txtExamID.Location = new System.Drawing.Point(258, 120);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.Size = new System.Drawing.Size(293, 20);
            this.txtExamID.TabIndex = 0;
            // 
            // txtStudId
            // 
            this.txtStudId.Location = new System.Drawing.Point(258, 169);
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.Size = new System.Drawing.Size(293, 20);
            this.txtStudId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getStudentAnswersInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStudId);
            this.Controls.Add(this.txtExamID);
            this.Name = "getStudentAnswersInput";
            this.Text = "getStudentAnswersInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExamID;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Button button1;
    }
}