using System;

namespace Laskentaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2,vastaus;

            //Yhteenlasku
            Console.WriteLine("Anna 1. yhteenlaskettava");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. yhteenlaskettava");
            luku2 = int.Parse(Console.ReadLine());
            vastaus = luku1 + luku2;
            Console.WriteLine("{0} + {1} = {2}", luku1,luku2,vastaus);
            Console.ReadLine();
            
            //Vähennyslasku
            Console.WriteLine("Anna vähennettävä");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna vähentäjä");
            luku2 = int.Parse(Console.ReadLine());
            vastaus = luku1 - luku2;
            Console.WriteLine("{0} - {1} = {2}", luku1, luku2, vastaus);
            Console.ReadLine();

            //Kertolasku
            Console.WriteLine("Anna kertoja");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kerrottava");
            luku2 = int.Parse(Console.ReadLine());
            vastaus = luku1 * luku2;
            Console.WriteLine("{0} x {1} = {2}", luku1, luku2, vastaus);
            Console.ReadLine();

            //Jakolasku
            Console.WriteLine("Anna jaettava");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna jakaja");
            luku2 = int.Parse(Console.ReadLine());
            vastaus = luku1 / luku2;
            // jakaja ja jaettava ovat kokonaislukuja, joten tapahtuu kokonaisjako
            Console.WriteLine("{0} / {1} = {2}", luku1, luku2, vastaus);
            Console.ReadLine();

            //Normaali jakolasku
            double dluku1, dluku2, dvastaus;
            Console.WriteLine("Anna jaettava");
            dluku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna jakaja");
            dluku2 = double.Parse(Console.ReadLine());
            dvastaus = dluku1 / dluku2;
            // :f2 kahdella desimaalilla
            Console.WriteLine("{0} / {1} = {2:f2}", dluku1, dluku2, dvastaus);
            Console.ReadLine();

            //Potenssiin korotus
            Console.WriteLine("Anna kantaluku");
            dluku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna potenssi");
            dluku2 = double.Parse(Console.ReadLine());
            dvastaus = Math.Pow(dluku1,dluku2);
            // :f2 kahdella desimaalilla
            Console.WriteLine("{0} ^ {1} = {2:f2}", dluku1, dluku2, dvastaus);
            Console.ReadLine();

            //Neliöjuuri
            Console.WriteLine("Anna juuri");
            dluku1 = double.Parse(Console.ReadLine());
            dvastaus = Math.Sqrt(dluku1);
            // :f2 kahdella desimaalilla
            Console.WriteLine("Neliöjuuri {0}  = {1:f2}", dluku1, dvastaus);
            Console.ReadLine();

            //Jakojäännös
            Console.WriteLine("Anna jaettava");
            dluku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna jakaja");
            dluku2 = double.Parse(Console.ReadLine());
            dvastaus = dluku1 % dluku2; // jakojäännös tehdään %-merkillä
            // :f2 kahdella desimaalilla
            Console.WriteLine("{0} % {1} = {2:f2}", dluku1, dluku2, dvastaus);
            Console.ReadLine();
        }
    }
}
