using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class SpiderMan : ISuperHero
    {
        public void Move()
        {
            Console.WriteLine("*Swing from Webs*");
        }
    }
}
