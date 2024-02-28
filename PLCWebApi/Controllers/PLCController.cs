using Microsoft.AspNetCore.Mvc;

namespace PLCWebApi;

public class PLCController
{
    [ApiController]
    [Route("api/[controller]")]
    public class YourController : ControllerBase
    {
        private readonly DataBaseTags _context;

        public YourController(DataBaseTags context)
        {
            _context = context;
        }

        [HttpGet("AI")]
        public IActionResult GetAI()
        {
            var analogueIn = _context.AnalogueIn.ToList();
            return Ok(analogueIn);
        }

        [HttpGet("AO")]
        public IActionResult GetAO()
        {
            var analogueOut = _context.AnalogueOut.ToList();
            return Ok(analogueOut);
        }


        [HttpGet("DI")]
        public IActionResult GetDI()
        {
            var digitalIn = _context.DigitalIn.ToList();
            return Ok(digitalIn);
        }


        [HttpGet("DO")]
        public IActionResult GetDO()
        {
            var digitalOut = _context.DigitalOut.ToList();
            return Ok(digitalOut);
        }
    }
}