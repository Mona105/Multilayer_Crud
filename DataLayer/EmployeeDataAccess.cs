using System;
using System.Collections.Generic;
using System.Text;
using CommanLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
namespace DataLayer
{
    public class EmployeeDataAccess
    {
        private DbConnection db = new DbConnection();
        public List<Employees> GetEmployees()
        {
            string query = "select * from Employee";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.cnn;
            if(db.cnn.State==System.Data.ConnectionState.Closed)
            {
                db.cnn.Open();
            }
            SqlDataReader reader = command.ExecuteReader();
            List<Employees> employees = new List<Employees>();
            while(reader.Read())
            {
                Employees emp = new Employees();
                emp.Id = (int)reader["Id"];
                emp.Name = reader["Name"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.Gender = reader["Gender"].ToString();
                emp.Mobile = reader["Mobile"].ToString();
            }
            db.cnn.Close();
            return employees;
        }
    }
}
