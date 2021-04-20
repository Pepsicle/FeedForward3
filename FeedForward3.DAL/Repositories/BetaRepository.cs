﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using FeedForward3.Models;
using FeedForward3.Interfaces;

namespace FeedForward3.DAL.Repositories
{
    public class BetaRepository : IBetaLogic
    {
        MySqlDataReader reader;
        MySqlConnection databaseConnection = DbConn.connection();

        public BetaListModel betaList()
        {
            string query = "SELECT * FROM betas";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            BetaListModel betaList = new BetaListModel();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BetaModel beta = new BetaModel(reader.GetInt32("id"), reader.GetString("title"), reader.GetString("description"), reader.GetString("company"));
                    betaList.AddBeta(beta);
                }
                reader.Close();
            }
            return betaList;
        }

        public bool UploadBeta(BetaModel betaModel)
        {
            string query = "INSERT INTO betas (title, description, company) VALUES (@Title, @Description, @CompanyName);";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            command.Parameters.AddWithValue("@Title", betaModel.Title);
            command.Parameters.AddWithValue("@Description", betaModel.Description);
            command.Parameters.AddWithValue("@CompanyName", betaModel.CompanyName);

            command.ExecuteNonQuery();
            return true;
        }
    }
}
