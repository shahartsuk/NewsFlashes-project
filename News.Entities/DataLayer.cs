using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Entities
{
    public class DataLayer:DbContext
    {
        private static DataLayer _Data;
        static string connectionString = MainManager.Instance.configDB.GetConfigConnectionString();
        private DataLayer():base(connectionString) 
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataLayer>());
            //if the first default model list is null use seed and start the DB
        }
        public static DataLayer Data { get { if (_Data == null) { _Data = new DataLayer(); } return _Data; } }

        //first entrace to DB
        private void Seed()
        {
            SaveChanges();
        }

        //DBset lists of models to DB
    }
}
