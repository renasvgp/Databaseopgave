using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaseopgave.CRUD
{
    public class Read
    {
        public static List<Facility> ListAllFacilities(SqlConnection connection)
        {
            

           
            string queryStringAllFacilities = "SELECT * FROM Facility";
            

            
            SqlCommand command = new SqlCommand(queryStringAllFacilities, connection);
            SqlDataReader reader = command.ExecuteReader();


            Console.WriteLine("Listing all facilites:");

            
            if (!reader.HasRows)
            {
               
                Console.WriteLine("No facilities in database");
                reader.Close();

                
                return null;
            }

            
            List<Facility> Facilities = new List<Facility>();
            while (reader.Read())
            {
                
                Facility nextFacility = new Facility()
                {
                    Facility_No = reader.GetInt32(0),
                    Name = reader.GetString(1),   
                    
                };

                
                Facilities.Add(nextFacility);

                Console.WriteLine(nextFacility);
            }

            
            reader.Close();
            Console.WriteLine();

            
            return Facilities;
        }
    }
    
    
}
