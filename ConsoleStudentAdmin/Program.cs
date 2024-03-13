using Microsoft.Data.Sqlite;

namespace ConsoleStudentAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Connection string to the SQLite database file
            string connectionString = "Data Source=StudentsDB.db;";

            // SQL query to select all students from the table
            string query = "SELECT * FROM students";

            // Create a new SQLite connection
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command object with the query and connection
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    // Execute the query and get the data reader
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the rows and display the results
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int age = reader.GetInt32(2);
                            string grade = reader.GetString(3);

                            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}, Grade: {grade}");
                        }
                    }
                }

                // Close the connection
                connection.Close();
            }

            Console.ReadLine();
        }
    }
}