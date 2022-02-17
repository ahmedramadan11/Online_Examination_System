using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class StudentCourseManager
    {
        static DBManager dBmanager = new();

        public static StudentCourseList SelectAllStudentCourse()
        {
            try
            {
                return DataTable2StudentCourseList(dBmanager.ExecuteDataTable("Select_Student_Course_All"));
            }
            catch (Exception ex)
            {

            }
            return new();
        }


        #region Mapping

        internal static StudentCourseList DataTable2StudentCourseList(DataTable Dt)
        {
            StudentCourseList studentCourse = new();
            try
            {
                for (int i = 0; i < Dt?.Rows.Count; i++)
                {
                    studentCourse.Add(DataRow2StudentCourse(Dt.Rows[i]));
                }
            }
            catch (Exception ex)
            {

            }
            return studentCourse;
        }


        internal static StudentCourse DataRow2StudentCourse(DataRow Dr)
        {
            StudentCourse SC = new();
            try
            {
                if (int.TryParse(Dr["SID"]?.ToString() ?? "-1", out int TempInt))
                    SC.SID = TempInt;

                if (int.TryParse(Dr["CID"]?.ToString() ?? "-1", out TempInt))
                    SC.CID = TempInt;

                if (int.TryParse(Dr["Grade"]?.ToString() ?? "-1", out TempInt))
                    SC.Grade = TempInt;



            }
            catch (Exception ex)
            {

            }
            return SC;
        }


        #endregion
    }
}
