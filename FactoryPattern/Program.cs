

using FactoryPattern.Factory;
using FactoryPattern.Interfaces;
using System.Transactions;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iron Man \nSpiderman \nHulk \n -------------------");
            var input = Helpers.Helper.GetUserInput("Enter which heroe you would like to chose?");
            ISuperHero hero = SuperheroFactory.GetSuperHero(input);
            Console.WriteLine("");
            hero.Move();


        }
    }
}
