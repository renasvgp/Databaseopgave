using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaseopgave.CRUD
{
   public class update
    {
        public static int UpdateFacility(SqlConnection connection, Facility facility)
        {
            Console.WriteLine("Updating facility");

            
            string updateCommandString = $"UPDATE Facility SET Name='{facility.Name}' WHERE Facility_No = {facility.Facility_No}";
            

            
            SqlCommand command = new SqlCommand(updateCommandString, connection);
            Console.WriteLine($"Updating facility {facility.Facility_No}");
            Console.WriteLine();
            int numberOfRowsAffected = command.ExecuteNonQuery();

            return numberOfRowsAffected;
        }
    }
}
