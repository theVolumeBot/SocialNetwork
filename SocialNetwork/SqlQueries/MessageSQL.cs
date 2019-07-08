using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SocialNetwork.SqlQueries
{
    class MessageSQL
    {
        public static List<Message> GetAllMessage (int messageId)
        {
            List<Message> Messages = new List<Message>();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.Open();

                string sqlString = $"SELECT * FROM Message WHERE MessageId = {messageId}";

                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);

                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Message message = new Message()
                    {
                        MessageId = reader.GetInt32(0),
                        Author = reader.GetString(1),
                        Created = reader.GetDateTime(2),
                        CommentText = reader.GetString(3),
                    };
                    Message.Add(message);
                }
                return Messages;
            }
        }
    }
}
