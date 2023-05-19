using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyShapes.Web.Model
{
    /// <summary>
    /// This is the mongoDb specific datatype. It uses
    /// <see href="https://en.wikipedia.org/wiki/BSON">Bson representation</see>
    /// </summary>
    public class ShapeMongoObject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Color { get; set; } = default!;
    }
}
