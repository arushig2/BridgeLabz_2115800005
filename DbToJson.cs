using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;";
        string query = "SELECT Id, Name, Age, Email FROM Users";

        DataTable dataTable = new DataTable();

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            string json = JsonConvert.SerializeObject(dataTable, Formatting.Indented);

            File.WriteAllText("UserReport.json", json);

            Console.WriteLine("JSON Report generated successfully: UserReport.json");
            Console.WriteLine(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
