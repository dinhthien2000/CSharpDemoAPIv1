using DemoAPIv1.Connection;
using DemoAPIv1.enties;
using MySqlConnector;
using System.Collections.Generic;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace DemoAPIv1.dao
{
    public class EmployeeDao
    {

        public static string SELECT = "Select * from Employes";
        public static string CREATE = "insert into Employes(id,name,age) values (@id,@name,@age)";
        public static string UPDATE = "update Employes set name = @name, age = @age where id =@id";
        public static string DELETE = "delete from Employes where id =@id";

        

        public List<Employee> getAllEmployes()
        {
            MySqlConnection conn = Connect.getConnection();
            List<Employee> list = new List<Employee>();
            Employee employee = null;
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();

                MySqlCommand command = new MySqlCommand(SELECT,conn);
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    employee = new Employee(
                        reader.GetString("id"),
                        reader.GetString("name"), 
                        reader.GetString("age")
                        );
                     
                    list.Add(employee);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }

            return list;
        }


        public Employee createEmployes(Employee employee)
        {
            MySqlConnection conn = Connect.getConnection();
            Employee recive = null;
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();

                MySqlCommand command = new MySqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("id", employee.Id);
                command.Parameters.AddWithValue("name", employee.Name);
                command.Parameters.AddWithValue("age", employee.Age);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    recive = employee;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }

            return recive;
        }

    }
}
