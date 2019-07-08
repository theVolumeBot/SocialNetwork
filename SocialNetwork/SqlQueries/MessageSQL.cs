using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SocialNetwork
{
    class MessageSQL
    {
        public static List<Message> GetAllMessage (int userId)
        {
            List<Message> Messages = new List<Message>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlQueries.connectionString))
            {
                sqlConnection.Open();

                string sqlString = $"SELECT * FROM Message WHERE ToUserId = {userId}";

                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Message message = new Message()
                    {
                        MessageId = reader.GetInt32(0),
                        FromUserId = reader.GetInt32(1),
                        ToUserId = reader.GetInt32(2),
                        MessageTitle = reader.GetString(3),
                        MessageContent = reader.GetString(4),
                        DateForMessage = reader.GetDateTime(5)
                    };
                    Messages.Add(message);
                }
                return Messages;
            }
        }
    }
}
