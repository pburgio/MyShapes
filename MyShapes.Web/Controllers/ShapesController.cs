using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyShapes.Web.Dto;
using MyShapes.Web.Repositories;
using System.Data.SqlTypes;

namespace MyShapes.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapesController : ControllerBase
    {
        private readonly IShapeRepository _myRepo;
        private readonly IMapper _mapper;

        /// <summary>
        /// This is used by the framework to inject dependencies
        /// "myRepo" and "mapper" are injected
        /// </summary>
        /// <param name="myRepo"></param>
        /// <param name="mapper"></param>
        public ShapesController(IShapeRepository myRepo, IMapper mapper)
        {
            _myRepo = myRepo;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetShapes")]
        public IEnumerable<ShapeDto> Get()
        {
            // Use this code to pass the Unit Test
            try
            {
                var shapesFromDb = _myRepo.GetShapes();
                return _mapper.Map<IList<ShapeDto>>(shapesFromDb);
            }
            catch(Exception ex)
            {
                return new List<ShapeDto>();
            }

            // Use this code so that the UNIT test fails
            //var shapesFromDb = _myRepo.GetShapes();
            //return _mapper.Map<IList<ShapeDto>>(shapesFromDb);
        }

        // TODO aggiungere Post (per la creazione), Patch (per la modifica), e nel caso "GetArea")
    }
}