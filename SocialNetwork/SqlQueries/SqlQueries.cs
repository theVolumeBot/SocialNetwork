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

        public static User GetUser(int id)
        {
            User user = new User();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string sqlString = $"usp_ReadBlogPost '{id}'";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

                var reader = sqlCommand.ExecuteReader();

                reader.Read();

                blogPost.Id = reader.GetInt32(0);
                blogPost.Title = reader[1].ToString();
                blogPost.Author = reader[2].ToString();
                blogPost.Created = reader.GetDateTime(3);
                blogPost.Content = reader[4].ToString();
                blogPost.Updated = reader.GetDateTime(5);
            }

            return blogPost;
        }
    }
}
