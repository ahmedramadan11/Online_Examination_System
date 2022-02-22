
using System.Windows.Forms;

namespace ExaminationSystem.Home
{
    partial class frmHome
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
            this.grdStudentCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdViewGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStudentCourse
            // 
            this.grdStudentCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentCourse.Location = new System.Drawing.Point(12, 73);
            this.grdStudentCourse.Name = "grdStudentCourse";
            this.grdStudentCourse.RowTemplate.Height = 25;
            this.grdStudentCourse.Size = new System.Drawing.Size(346, 323);
            this.grdStudentCourse.TabIndex = 0;
            this.grdStudentCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudentCourse_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Exams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(564, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grades";
            // 
            // grdViewGrades
            // 
            this.grdViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewGrades.Location = new System.Drawing.Point(426, 73);
            this.grdViewGrades.Name = "grdViewGrades";
            this.grdViewGrades.RowTemplate.Height = 25;
            this.grdViewGrades.Size = new System.Drawing.Size(346, 323);
            this.grdViewGrades.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdViewGrades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdStudentCourse);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdStudentCourse;
        private Label label1;
        private Label label2;
        private DataGridView grdViewGrades;
    }
}