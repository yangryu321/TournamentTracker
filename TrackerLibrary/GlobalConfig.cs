using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDateConnection connection;

        public static void InitializeConnections(Enum_Database database)
        {
            switch (database)
            {
                case Enum_Database.sql:
                    connection = new SqlConnector();
                    break;
                case Enum_Database.textfile:
                    connection = new TextConnector();
                    break;
                default:
                    break;
            }

        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
