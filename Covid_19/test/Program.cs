using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient mongoClient = new MongoClient("mongodb+srv://Deldar:Shekho%4012345@cluster0.9mybl.mongodb.net/test?authSource=admin&replicaSet=atlas-jxdwqv-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");
            var database = mongoClient.GetDatabase("Covid-19");
            var confirmedCases = database.GetCollection<BsonDocument>("Confirmed_Cases");
            var docs = confirmedCases.Find(new BsonDocument()).Project("{_id: 0}").ToList();

            List<int> numbers = new List<int>();
            int total = 0;


            BsonDocument bsonDocument = docs[1];

            List<string> dates = new List<string>();

            for (int i = 4; i < bsonDocument.Count(); i++)
            {
                dates.Add(bsonDocument.GetElement(i).Name);
                
            }


            for (int i = 0; i < dates.Count; i++)
            {
                for (int y = 0; y < docs.Count; y++)
                {
                    int number = int.Parse(docs[y].GetValue(dates[i]).ToString());

    
                    total += number;
                }

                if(total < 0)
                {
                    total = total * -1;
                }

                Console.WriteLine(total);
                numbers.Add(total);
            }

            Console.ReadKey();
        }
    }
}
