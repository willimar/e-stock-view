using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.Context
{
    public class MongoClientFactory : MongoClient
    {

        public MongoClientFactory(DataBaseSettings dataBaseSettings) : base(connectionString: ConnectionFactory(dataBaseSettings))
        {
           
        }

        private static string ConnectionFactory(DataBaseSettings dataBaseSettings)
        {
            string connectionString;

            if (string.IsNullOrEmpty(dataBaseSettings.UserName))
            {
                connectionString = $"mongodb://{dataBaseSettings.UserName}:{dataBaseSettings.Port}/?readPreference=primary&appname=postal.code.api&ssl=false";
            }
            else
            {
                //connectionString = $"mongodb+srv://{Program.DataBaseUser}:{Program.DataBasePws}@{Program.DataBaseHost}/{Program.DataBaseName}?retryWrites=true&w=majority&ssl=false";
                //connectionString = $"mongodb://{Program.DataBaseUser}:{Program.DataBasePws}@{Program.DataBaseHost}:{Program.DataBasePort}/?authSource={Program.DataBaseAuth}&readPreference=primary&appname=postal.code.api&ssl=false";
                connectionString = $"mongodb+srv://{dataBaseSettings.UserName}:{dataBaseSettings.UserPws}@{dataBaseSettings.Host}/{dataBaseSettings.Auth}?retryWrites=true&w=majority";
            }

            return connectionString;
        }
    }
}
