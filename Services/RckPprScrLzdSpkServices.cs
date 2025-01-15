using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RckPprScrLzdSpkEndpoints.Services
{
    public class RckPprScrLzdSpkServices
    {
        Random rng = new Random();

        public string CpuChoice(){
            switch(rng.Next(1, 6)){
                case 1:
                return "Rock";
                case 2:
                return "Paper";
                case 3:
                return "Scissor";
                case 4:
                return "Lizard";
                default:
                return "Spock";
            }
        }

    }
}