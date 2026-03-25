using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiderNetApi.Models
{
    public class MissaoAranha
    {
        public int Id {get;set;}    
        public string VilaoEnfrentado{get;set;}
        public string Localizacao{get;set;}
        public int NivelPerigo{get;set;}
        public bool Resolvido{get;set;}
    }
}