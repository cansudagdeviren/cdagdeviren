
using System;
using System.Data.SqlClient;

namespace MAUI_test_app
{
    internal class User
    {
        public string Uid;
        private string Upass;

        public string Uname;
        public int Ukcal;

        public User(string Uid, string Upass)
        {
            this.Uid = Uid;
            this.Upass = Upass;

            string loc = Preferences.Default.Get("serverLoc", "Unknown");
            SqlConnection con = new SqlConnection(loc);
            con.Open();

            string quest = $"select Name, MyKcal from Users where Password = {Upass} AND ID_User = {Uid}";
            SqlCommand cmd = new SqlCommand(quest, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.Uname = reader.GetString(0);
                this.Ukcal = reader.GetInt32(1);
            }
            con.Close();
        }
    }
}
