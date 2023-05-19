using AutoMapper;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MyShapes.Web.Model;

namespace MyShapes.Web.Repositories
{
    public class ShapesMongoDbRepository : IShapeRepository
    {
        private readonly IMongoCollection<ShapeMongoObject> _mongoDbCollection;
        private readonly IMapper _mapper;

        public ShapesMongoDbRepository(IOptions<MongoDBSettings> mongoDBSettings, IMapper mapper)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);

            _mongoDbCollection = database.GetCollection<ShapeMongoObject>(mongoDBSettings.Value.CollectionName);
            _mapper = mapper;
        }

        public IEnumerable<Shape> GetShapes()
        {
            var objectsFromDb = _mongoDbCollection.AsQueryable().ToList();
            return _mapper.Map<List<Shape>>(objectsFromDb);
        }
    }
}
