using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SocialNetwork
{
    class SqlQueries
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SocialNetworkApp;Integrated Security=True";

        public bool TestLogInInfo(string nickName, string password)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlConnection.Open();
                string sql = $"SELECT * FROM AppUser Where AppUser.NickName = '{nickName}' AND AppUser.UserPassword = '{password}'";
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = sql;
                var reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static User GetUser(string nickName)
        {
            User user = new User();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string sqlString = $"SELECT * FROM AppUser WHERE @nickname = '{nickName}';";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@nickname", nickName));

                var reader = sqlCommand.ExecuteReader();

                reader.Read();

                user.UserId = reader.GetInt32(0);
                user.UserNickName = reader[1].ToString();
                user.UserPassword = reader[2].ToString();
                user.BirthDate = reader.GetDateTime(3);
                user.UserCity = reader[4].ToString();

            }

            return user;
        }

        public static void CreateUser(string nickname, string userpassword, DateTime birthdate, string city, string secret)
        {
            User user = new User();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string sqlString = $"INSERT INTO AppUser (NickName, UserPassword, BirthDate, Age, City, [Secret]) VALUES ('{nickname}', '{userpassword}','{birthdate}','{city}','{secret}')";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.ExecuteNonQuery(); 

            }

        }
    }
}
