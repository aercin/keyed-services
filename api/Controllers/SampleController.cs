using api.Abstractions;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    { 
        [HttpGet]
        [Route("api/cat-sound")]
        public IActionResult SoundOfCat([FromKeyedServices(nameof(Cat))] IAnimal cat)
        {
            return Ok(cat.MakeSound());
        }

        [HttpGet]
        [Route("api/dog-sound")]
        public IActionResult SoundOfDog([FromKeyedServices(nameof(Dog))] IAnimal dog)
        {
            return Ok(dog.MakeSound());
        }
    }
}
