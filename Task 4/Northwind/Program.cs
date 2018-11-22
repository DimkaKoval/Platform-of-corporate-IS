using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace platform6k
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            string sqlExpression = "SELECT * FROM Employees WHERE EmployeeID = 8";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                for (int i = 0; i < 13; i++)
                {
                    Console.WriteLine("{0}: {1}", reader.GetName(i), reader.GetValue(i));
                }

            }

            reader.Close();
            Console.WriteLine("----------------------------");
            sqlExpression = "SELECT COUNT(*) FROM Employees WHERE City = 'London' ";
            command = new SqlCommand(sqlExpression, connection);
            object obj = command.ExecuteScalar();


            Console.WriteLine("Count of empoyees in London :{0}", obj);


            reader.Close();

            Console.WriteLine("----------------------------");
            sqlExpression = "SELECT COUNT(*) FROM Customers JOIN Orders ON Customers.CustomerID=Orders.CustomerID WHERE Country='France'  ";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteScalar();


            Console.WriteLine("Count of orders from France :{0}", obj);


            reader.Close();

            Console.WriteLine("----------------------------");
            sqlExpression = "SELECT* FROM Customers JOIN Orders ON Customers.CustomerID=Orders.CustomerID WHERE Country='France'  ";
            command = new SqlCommand(sqlExpression, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}: {1}", reader.GetName(0), reader.GetValue(0));
                }

            }

            reader.Close();
            Console.WriteLine("----------------------------");
            sqlExpression = "SELECT* FROM Customers JOIN Orders ON Customers.CustomerID=Orders.CustomerID WHERE Country='France' AND ShipCountry='France' ";
            command = new SqlCommand(sqlExpression, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}: {1}", reader.GetName(0), reader.GetValue(0));
                }

            }

            reader.Close();
            Console.WriteLine("----------------------------");
            sqlExpression = "SELECT* FROM Customers JOIN Orders ON Customers.CustomerID=Orders.CustomerID WHERE Country='France' AND ShipCountry<>'France' ";
            command = new SqlCommand(sqlExpression, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}: {1}", reader.GetName(0), reader.GetValue(0));
                }

            }
            else
            {
                Console.WriteLine("Such customers don't exsist");
            }

            reader.Close();
            Console.WriteLine("----------------------------");
            sqlExpression = "INSERT INTO Employees(LastName, FirstName, BirthDate, HireDate, Address, City, Country, Notes) VALUES('Nakonechna', 'Solomiya', '1998-07-26','2016-08-09','Yuria Lupy','Lviv','Ukraine','NOPE')";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteNonQuery();
            sqlExpression = "INSERT INTO Employees(LastName, FirstName, BirthDate, HireDate, Address, City, Country, Notes) VALUES('Radysh', 'Rostyslav', '1998-07-26','2016-08-09','Shevchenko','Lviv','Ukraine','NOPE')";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteNonQuery();
            sqlExpression = "INSERT INTO Employees(LastName, FirstName, BirthDate, HireDate, Address, City, Country, Notes) VALUES('Sheremeta', 'Yuria', '1998-07-26','2016-08-09','Verna','Lviv','Ukraine','NOPE')";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteNonQuery();
            sqlExpression = "INSERT INTO Employees(LastName, FirstName, BirthDate, HireDate, Address, City, Country, Notes) VALUES('Luga', 'Danulo', '1998-08-26','2016-09-09','Masepa','Lviv','Ukraine','NOPE')";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteNonQuery();
            sqlExpression = "INSERT INTO Employees(LastName, FirstName, BirthDate, HireDate, Address, City, Country, Notes) VALUES('Larson', 'Ostap', '1998-08-26','2016-05-09','Pyliua','Lviv','Ukraine','NOPE')";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteNonQuery();



            reader.Close();
            Console.WriteLine("----------------------------");
            sqlExpression = "DELETE FROM Employees WHERE LastName='Radysh'";
            command = new SqlCommand(sqlExpression, connection);
            obj = command.ExecuteNonQuery();
            connection.Close();
            Console.ReadKey();

        }
    }
}