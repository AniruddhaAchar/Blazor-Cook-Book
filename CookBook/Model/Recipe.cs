using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CookBook.Model
{
    public class Recipe
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string Recipe_Name { get; set; }

        public List<Step> Steps { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public Recipe_Time Recipe_Time { get; set; }

        public string Description { get; set; }
        public string Image_Url { get; set; }
    }
}
