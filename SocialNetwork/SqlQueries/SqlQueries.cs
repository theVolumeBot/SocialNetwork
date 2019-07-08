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
                } else
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

                string sqlString = $"SELECT * FROM AppUser WHERE AppUser.NickName  ='{nickName}'";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = sqlString;
                sqlCommand.Connection = sqlConnection;
                var reader = sqlCommand.ExecuteReader();


                if(!reader.Read())
                {
                    user = null;
                }
                  
                

            }

            return user;
        }

        public static void CreateUser(string nickName, string userPassword, string birthDate, string city, string secret)
        {
            User user = new User();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string sqlString = $"INSERT INTO AppUser (NickName, UserPassword, Birthdate, City, [Secret]) VALUES ('{nickName}', '{userPassword}', '{birthDate}', '{city}', '{secret}')";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = sqlString;
                sqlCommand.ExecuteNonQuery(); 


            }

        }
}
