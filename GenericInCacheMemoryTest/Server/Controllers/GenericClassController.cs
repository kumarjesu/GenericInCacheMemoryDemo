using GenericInCacheMemoryTest.Server.ServiceRepos;
using GenericInCacheMemoryTest.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericInCacheMemoryTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericClassController : ControllerBase
    {
        private readonly IGenericClassServiceRepo _genericClassServiceRepo;
        public GenericClassController(IGenericClassServiceRepo genericClassServiceRepo)
        {
            _genericClassServiceRepo = genericClassServiceRepo;
        }

        [HttpGet]
        public IEnumerable<GenericClass> GetGenericClass()
        {
            return _genericClassServiceRepo.GetGenericClasses();
        }
    }
}
