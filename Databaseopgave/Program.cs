using System;
using System.Data.Common;

namespace Databaseopgave
{
    class program
    {
        static void Main(string[] args)
        {
            DBClient dbc = new DBClient();
            dbc.Start();
        }
    }
}
