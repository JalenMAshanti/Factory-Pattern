using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class IronMan : ISuperHero
    {
        public void Move()
        {
           Console.WriteLine("*Fly with Iron Suit*");
        }
    }
}
