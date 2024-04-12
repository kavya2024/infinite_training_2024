using System;
using System.Data;
using System.Data.SqlClient;

class Add
{
    static void Main()
    {
        // Connection string
        string connectionString = "Server=ICS-LT-D8VDR73\\SQLEXPRESS;Database=Employeemanagement;Integrated Security=True;";

       
        InsertEmployee(connectionString, "Kavya A", 28000, 'C');

        // Display all employee rows
        DisplayEmployees(connectionString);

        Console.ReadLine();
    }

   
    static void InsertEmployee(string connectionString, string empName, decimal empSal, char empType)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("AddEmployee2", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Parameters for the stored procedure
            command.Parameters.AddWithValue("@EmpName", empName);
            command.Parameters.AddWithValue("@Empsal", empSal);
            command.Parameters.AddWithValue("@Emptype", empType);

            // Open the connection
            connection.Open();

            // Execute the command (stored procedure)
            command.ExecuteNonQuery();
        }
    }

    //  Display all employee rows
    static void DisplayEmployees(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employee_Details", connection);

            // Open the connection
            connection.Open();

            // Execute the command and get the data
            SqlDataReader reader = command.ExecuteReader();

            // Display the data
            while (reader.Read())
            {
                Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");
            }

            // Close the reader
            reader.Close();
        }
    }
}