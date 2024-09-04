using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLATFORMSERVICE.Data;
using PLATFORMSERVICE.DTOs;

namespace PLATFORMSERVICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformServiceController : ControllerBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;

        public PlatformServiceController(IPlatformRepo platformRepo, IMapper mapper) 
        { 
            _repository = platformRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("Platformss coming...");

            var platform = _repository.GetAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platform));
        }
    }
}
