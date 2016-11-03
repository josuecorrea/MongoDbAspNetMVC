using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbMvc.App_Start
{
    public class MongoContext
    {
        public MongoDatabase Database;

        public MongoContext()
        {
            var client = new MongoClient(MongoDbMvc.Properties.Settings.Default.conexao);
            var server = client.GetServer();
            Database = server.GetDatabase(Properties.Settings.Default.database);
        }
    }
}