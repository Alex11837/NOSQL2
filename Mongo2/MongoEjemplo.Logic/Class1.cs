using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoEjemplo.Logic
{
    public class Class1
    {
        public static void ConnectWithoutAuthentication()
        {
            string connectionString = "mongodb://localhost:27017"; MongoClient client = new MongoClient(connectionString); Console.WriteLine("Connected");
        }
    }
}
