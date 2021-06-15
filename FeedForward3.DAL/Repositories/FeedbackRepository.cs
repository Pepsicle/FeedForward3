using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using FeedForward3.Models;
using FeedForward3.Interfaces;

namespace FeedForward3.DAL.Repositories
{
    public class FeedbackRepository : IFeedbackLogic
    {
        MySqlDataReader reader;
        MySqlConnection databaseConnection = DbConn.connection();

        public bool UploadFeedback(FeedbackModel feedbackModel)
        {
            string query = "INSERT INTO feedback (testid, name, email, feedback) VALUES (@TestId, @Name, @Email, @Feedback);";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            command.Parameters.AddWithValue("@TestId", feedbackModel.TestId);
            command.Parameters.AddWithValue("@Name", feedbackModel.Name);
            command.Parameters.AddWithValue("@Email", feedbackModel.Email);
            command.Parameters.AddWithValue("@Feedback", feedbackModel.Feedback);

            command.ExecuteNonQuery();
            return true;
        }

        public int GetVisits(int id)
        {
            string query = "SELECT * FROM betas WHERE id=@Id;";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.Parameters.AddWithValue("@Id", id);
            reader = command.ExecuteReader();
            int visits = 0;
            while (reader.Read())
            {
                visits = reader.GetInt32("visits");
            }
            return visits;
        }

        public void Upvote(int id)
        {
            string query = "UPDATE betas SET visits = visits + 1 WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }
        public void Downvote(int id)
        {
            string query = "UPDATE betas SET visits = visits - 1 WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }
    }
}
