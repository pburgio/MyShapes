using MyShapes.Web.Dto;

namespace MyShapes.Web.Model
{
    public class MyMapperProfile : AutoMapper.Profile
    {
        public MyMapperProfile()
        {
            // Create Maps <SOURCE_TYPE, DEST_TYPE>
            CreateMap<ShapeMongoObject, Shape>();
            CreateMap<Shape, ShapeDto>();
        }
    }
}
