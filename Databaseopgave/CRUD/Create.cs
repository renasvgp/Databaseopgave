using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaseopgave.CRUD
{
    public class Create
    {
        public static int InsertFacility(SqlConnection connection, Facility facility)
        {
            Console.WriteLine("Creating a facility");

            
            string insertCommandString = $"INSERT INTO Facility VALUES({facility.Facility_No}, '{facility.Name}')";
            Console.WriteLine($"SQL applied: {insertCommandString}");

           
            SqlCommand command = new SqlCommand(insertCommandString, connection);

            Console.WriteLine($"Facility created {facility.Facility_No} - Name: {facility.Name}");
           
            int numberOfRowsAffected = command.ExecuteNonQuery();
           
            return numberOfRowsAffected;
            
            

            
        }
    }
    
    
}
