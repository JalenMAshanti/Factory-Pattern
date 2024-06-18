using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    public static class SuperheroFactory
    {
        public static ISuperHero GetSuperHero(string input) 
        {
            switch (input.ToLower()) 
            {
                case "spiderman":
                    return new SpiderMan();
                case "iron man":
                    return new IronMan();
                case "hulk":
                    return new Hulk();
                default:
                    return new IronMan();            
            }                       
        } 
    }
}
