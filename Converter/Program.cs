using System;

//A program allows to convert euro <-> hryvnia, usd <-> hryvnia
//It contains class Converter that consists of public fields and 4 methods  
//Let`s demonstrate the result on the determined data set

namespace Converter
{
    public class Converter
    {
        public double usd;
        public double euro;
        public Converter(double usd, double euro)
        {
            this.usd = usd;
            this.euro = euro;
        }

        public double ConvertHryvniaToUsd(double hryvnia)
        {
            return hryvnia / usd;
        }

        public double ConvertHryvniaToEuro(double hryvnia)
        {
            return hryvnia / euro;
        }

        public double ConvertUsdToHryvnia(double usd)
        {
            return usd * this.usd;
        }
        public double ConvertEuroToHryvnia(double euro)
        {
            return euro * this.euro;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter(28.15, 32.55);
            double hryvnia = 100;
            double usd = 5;
            double euro = 4;
            Console.WriteLine("There is " + c.ConvertHryvniaToUsd(hryvnia) + " usd in " + hryvnia + " hryvnas");
            Console.WriteLine("There is " + c.ConvertHryvniaToEuro(hryvnia) + " euro in " + hryvnia + " hryvnas");
            Console.WriteLine("There is " + c.ConvertUsdToHryvnia(usd) + " hryvnas in " + usd + " usd");
            Console.WriteLine("There is " + c.ConvertEuroToHryvnia(euro) + " hryvnas in " + euro + " euro");
        }
    }
}
