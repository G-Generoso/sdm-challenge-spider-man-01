using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpiderNetApi.Models;

namespace SpiderNetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissoesController :ControllerBase
    {
       private static List<MissaoAranha> missoes = new();

       [HttpGet]
       public ActionResult<IEnumerable<MissaoAranha>> Get()
        {
            return Ok(missoes);
        }
        
        [HttpPost]
    public ActionResult<MissaoAranha>Post(MissaoAranha missao)
        {
            //diferencial
            if(missao.NivelPerigo <=0 || missao.NivelPerigo > 10)
            {
                return BadRequest();
            }
            else
            {
                missoes.Add(missao);
            return CreatedAtAction(nameof(Get), new {id = missao.Id});
            }

            
        }
    }
    
}