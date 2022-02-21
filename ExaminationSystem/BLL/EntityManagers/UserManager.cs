using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {

        static DBManager dBmanager = new DBManager();

        public static UserList SelectAllUsers()
        {
            try
            {
                return DataTable2UserList(
                dBmanager.ExecuteDataTable("Select_User_All"));
            }
            catch (Exception ex)
            {

            }
            return new UserList();
        }


        #region Mapping

        internal static UserList DataTable2UserList(DataTable Dt)
        {
            UserList userList = new UserList();
            try
            {
                for (int i = 0; i < Dt?.Rows.Count; i++)
                {
                    userList.Add(DataRow2User(Dt.Rows[i]));
                }
            }
            catch (Exception ex)
            {

            }
            return userList;
        }


        internal static User DataRow2User(DataRow Dr)
        {
            User U = new User();
            try
            {
                if (int.TryParse(Dr["UID"]?.ToString() ?? "-1", out int TempInt))
                    U.UID = TempInt;

                U.userName = Dr["userName"]?.ToString() ?? "NA";

                U.password = Dr["password"]?.ToString() ?? "NA";

                U.Fname = Dr["Fname"]?.ToString() ?? "NA";

                U.Lname = Dr["Lname"]?.ToString() ?? "NA";

                U.address = Dr["address"]?.ToString() ?? "NA";

                if (DateTime.TryParse(Dr["Date_Birth"]?.ToString() ?? "-1", out DateTime TempDateBirth))
                    U.Date_Birth = TempDateBirth;

                U.User_Type = Dr["User_Type"]?.ToString() ?? "NA";
            }
            catch (Exception ex)
            {

            }
            return U;
        }


        #endregion
    }
}
