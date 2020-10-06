using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;


namespace Covid_19
{
    public class MongoDB
    {
        private MongoClient mongoClient;

        public MongoDB()
        {
            mongoClient = new MongoClient("mongodb+srv://Deldar:Shekho%4012345@cluster0.9mybl.mongodb.net/test?authSource=admin&replicaSet=atlas-jxdwqv-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");
        }


        public List<BsonDocument> GetConfirmedCases()
        {
            var database = mongoClient.GetDatabase("Covid-19");
            var confirmedCases = database.GetCollection<BsonDocument>("Confirmed_Cases");
            var docs = confirmedCases.Find(new BsonDocument()).Project("{_id: 0}").ToList();

            return docs;
        }

        public List<BsonDocument> GetDeathCases()
        {
            var database = mongoClient.GetDatabase("Covid-19");
            var confirmedDeath = database.GetCollection<BsonDocument>("Confirmed_Deaths");
            var docs = confirmedDeath.Find(new BsonDocument()).Project("{_id: 0}").ToList();


            return docs;

        }

        public List<BsonDocument> GetRecoveredCases()
        {
            var database = mongoClient.GetDatabase("Covid-19");
            var confirmedRecovered = database.GetCollection<BsonDocument>("Confirmed_Recovered");
            var docs = confirmedRecovered.Find(new BsonDocument()).Project("{_id: 0}").ToList();


            return docs;
        }

    }
}
