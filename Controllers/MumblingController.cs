using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        public string Mumbler(string mumbling)
        {
            var answer = "";
            var count = 0;

            foreach (char character in mumbling.ToUpper())
            {
                if (count != 0) answer += "-";

                answer += character;
                answer += new String(char.ToLower(character), count);

                ++count;
            }

            return answer;
        }
    }
}