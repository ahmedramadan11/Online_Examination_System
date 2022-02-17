﻿using System;
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

        public static StudentCourseList SelectAllStudentCourse(int studentID)
        {
            try
            {
                Dictionary<string, object> map = new Dictionary<string, object>();
                map["@S_ID"] = studentID;
                return DataTable2StudentCourseList(dBmanager.ExecuteDataTable("Select_User_Course_Exam_Join", map));
            }
            catch (Exception ex)
            {

            }
            return new();
        }

        public static int ExamAnswer(int _examID, int _studentID, string[] answers)
        {
            int counter = 1;
            int grade = 0;
            Dictionary<string, object> map1 = new Dictionary<string, object>();
            Dictionary<string, object> map2 = new Dictionary<string, object>();

            map1["@eID"] = _examID;
            map1["@stuId"] = _studentID;
            foreach (var item in answers)
            {
                map1[$"@num{counter++}"] = item;
            }


            dBmanager.ExecuteNonQuery("Exam_Answers", map1);

            map2["@eID"] = _examID;
            map2["@stuId"] = _studentID;

             grade = Convert.ToInt32(dBmanager.ExecuteScaler("ExamCorrection", map2));
            

            return grade;
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

                if (int.TryParse(Dr["EID"]?.ToString() ?? "-1", out TempInt))
                    SC.EID = TempInt;

                SC.userName = Dr["userName"]?.ToString() ?? "NA";


                SC.Cname = Dr["Cname"]?.ToString() ?? "NA";

            }
            catch (Exception ex)
            {

            }
            return SC;
        }


        #endregion
    }
}
