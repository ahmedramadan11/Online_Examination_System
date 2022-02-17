using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionChoiceManager
    {

        static DBManager dBmanager = new();

        public static DataTable SelectQuestionChoice(int _questionID)
        {
            try
            {
                Dictionary<string, object> map = new Dictionary<string, object>();
                map["@Q_ID"] = _questionID;
                return dBmanager.ExecuteDataTable("Select_Choices", map);
            }
            catch (Exception ex)
            {

            }
            return new();
        }


        #region Mapping

        //internal static ExamDetailsList DataTable2ExamDetails(DataTable Dt)
        //{
        //    ExamDetailsList examDetails = new();
        //    try
        //    {
        //        for (int i = 0; i < Dt?.Rows.Count; i++)
        //        {
        //            examDetails.Add(DataRow2ExamDetails(Dt.Rows[i]));
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return examDetails;
        //}


        //internal static ExamDetails DataRow2ExamDetails(DataRow Dr)
        //{
        //    ExamDetails U = new();
        //    try
        //    {
        //        if (int.TryParse(Dr["EID"]?.ToString() ?? "-1", out int TempInt))
        //            U.EID = TempInt;

        //        if (int.TryParse(Dr["QID"]?.ToString() ?? "-1", out TempInt))
        //            U.QID = TempInt;

        //        if (int.TryParse(Dr["CID"]?.ToString() ?? "-1", out TempInt))
        //            U.CID = TempInt;

        //        U.QDescription = Dr["QDescription"]?.ToString() ?? "NA";

        //        if (int.TryParse(Dr["QType"]?.ToString() ?? " - 1", out TempInt))
        //            U.QType = TempInt;

        //        U.Model_Answer = Dr["Model_Answer"]?.ToString() ?? "NA";
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return U;
        //}


        #endregion
    }
}
