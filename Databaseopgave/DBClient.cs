using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Databaseopgave.CRUD;
using Microsoft.Data.SqlClient;

namespace Databaseopgave
{
    
        class DBClient
        {
            //Database connection string - replace it with the connnection string to your own database 
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelOpgaveDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
            public void Start()
            {
                //Apply 'using' to connection (SqlConnection) in order to call Dispose (interface IDisposable) 
                //whenever the 'using' block exits
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Open connection
                    connection.Open();


                        Facility Data1 = new Facility()
                        {
                        Facility_No = IDGenerator.GetMaxFacilityNo(connection) + 1,
                        Name = "Svømmehal"
                        };

                        Create.InsertFacility(connection, Data1);

                        Read.ListAllFacilities(connection);

                        Delete.DeleteFacility(connection, 2);

                Facility UpdateFacility = new Facility()
                {
                    Facility_No = 5,
                    Name = "Træning"
                };

                update.UpdateFacility(connection, UpdateFacility);

                Read.ListAllFacilities(connection);
                


                    
                    
                }
            }
        }
}

