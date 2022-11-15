using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaseopgave.CRUD
{
  public class Delete
    {
        public static int DeleteFacility(SqlConnection connection, int facility_no)
        {
            Console.WriteLine("Deleting a facility");

           
            string deleteCommandString = $"DELETE FROM Facility  WHERE Facility_No = {facility_no}";
            
            SqlCommand command = new SqlCommand(deleteCommandString, connection);
            
            
            
            Console.WriteLine($"The facility has been deleted {facility_no}");
            Console.WriteLine();

            int numberOfRowsAffected = command.ExecuteNonQuery();

            
            return numberOfRowsAffected;
        }
    }
}
