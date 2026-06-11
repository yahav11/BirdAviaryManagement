using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birdAviarymanagement
{
    public class HealthService : IHealthService
    {
        private Random rnd = new Random();

        public bool IsBirdHealthy(string ringId)
        {
            return rnd.Next(2) == 0;
        }
    }
}
