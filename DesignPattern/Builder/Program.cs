
using System;
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Usine director = new Usine();

            Builder builderOne = new Renault();
            Builder buiderTwo = new Peugeot();

            director.Construct(builderOne);
            director.Construct(buiderTwo);

            Product productOne = builderOne.GetResult();
            productOne.Show();

            Product productTwo = buiderTwo.GetResult();
            productTwo.Show();

            Console.ReadLine();
        }
    }
}
