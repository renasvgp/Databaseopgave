using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaseopgave 
{
   public class IDGenerator
    {
        public static int GetMaxFacilityNo(SqlConnection connection)
        {
            


            string queryStringMaxFacilityNo = "SELECT  MAX(Facility_No)  FROM Facility";
            
            
            SqlCommand command = new SqlCommand(queryStringMaxFacilityNo, connection);
            SqlDataReader reader = command.ExecuteReader();


            int MaxFacilityNo = 0;


            if (reader.Read())
            {
                MaxFacilityNo = reader.GetInt32(0);
            }

            reader.Close();

            return MaxFacilityNo;
        }
    }
}


