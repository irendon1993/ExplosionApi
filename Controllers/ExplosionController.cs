using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{explosion}")]
        public string Exploding(string explosion)
        {
            var answer = "";

            foreach (var character in explosion)
            {
                var number = int.Parse(character.ToString());

                for (var n = 0; n < number; n++)
                {
                    answer += character;
                }
            }

            return answer;
        }
    }
}