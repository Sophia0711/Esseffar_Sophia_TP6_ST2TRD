using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var director = new Director();
            var builder = new Pizzaiolo();
            director.Builder = builder;

            Console.WriteLine("Margharita pizza:");
            director.BuildSimplePizza();
            Console.WriteLine(builder.GetProduct().ToString());

            Console.WriteLine("Full pizza :");
            director.BuildFullPizza();
            Console.WriteLine(builder.GetProduct().ToString());

            Console.WriteLine("Custom pizza:");
            builder.AddChevre();
            builder.AddSaumon();
            builder.AddPatate();
            Console.Write(builder.GetProduct().ToString());
            */

            Console.WriteLine("Same chef can cook with different recipe:");

            Cuisinier.Cooking(new Blanquette());

            Console.Write("\n");

            Console.WriteLine("Same chef can cook with different recipe:");

            Cuisinier.Cooking(new Tajine());
        }
    }
}
