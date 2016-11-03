using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDbMvc.Models
{
    public class Pessoa
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> Address = new List<string>();

        [BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public decimal Valor { get; set; }
    }
}