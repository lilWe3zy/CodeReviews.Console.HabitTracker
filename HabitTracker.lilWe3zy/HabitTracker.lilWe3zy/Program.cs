using Microsoft.Data.Sqlite;

namespace HabitTracker.lilWe3zy;

internal class Program
{
    public static void Main(string[] args)
    {
        using (var connection = new SqliteConnection("Data Source=habitTracker.db"))
        {
            // Creates file if it does not exist
            connection.Open();

            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT *";
        }
    }
}