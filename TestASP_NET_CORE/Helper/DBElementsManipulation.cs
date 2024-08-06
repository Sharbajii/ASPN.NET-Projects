using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TestASP_NET_CORE.Data;

namespace TestASP_NET_CORE.Helper
{
    public class DBElementsManipulation
    {
        private readonly string _connectionString;

        public DBElementsManipulation(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<TestASP_NET_CORE.Data.Task> GetTasks()
        {
            List<TestASP_NET_CORE.Data.Task> result = new List<TestASP_NET_CORE.Data.Task>();
            string _commandString = "SELECT TaskId, Title, Date, IsDone, UserId FROM [TodoListDB].[dbo].[Tasks]";
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using SqlCommand command = new SqlCommand(_commandString, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var task = Parse_ITEMS(reader);
                                result.Add(task);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return result;
        }

        private static TestASP_NET_CORE.Data.Task Parse_ITEMS(SqlDataReader reader)
        {
            return new TestASP_NET_CORE.Data.Task
            {
                _taskId = Convert.ToInt32(reader["TaskId"]),
                _title = reader["Title"].ToString(),
                _date = Convert.ToDateTime(reader["Date"]),
                _isDone = Convert.ToBoolean(reader["IsDone"]),
                _userId = Guid.Parse(reader["UserId"].ToString())
            };
        }
    }
}