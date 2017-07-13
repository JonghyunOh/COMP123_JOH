using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.7 - Modified Driver class to implement SuperHero
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);


            Console.WriteLine("\n\n\n");

            SuperVillain superVilian1 = new SuperVillain("Jonghyun", 100);
            superVilian1.AddPower("Fire ball", 70);
            superVilian1.AddPower("Guided arrow", 30);
            superVilian1.AddPower("Blizzard", 35);
            SuperVillain superVilian2 = new SuperVillain("Wayne", 90);
            superVilian2.AddPower("Call Meteo", 50);
            superVilian2.AddPower("Vanishing", 10);
            superVilian2.AddPower("Electric bolt", 20);

            Console.WriteLine(superVilian1.ToString());
            Console.WriteLine("Malice: " + superVilian1.Malice);

            Console.WriteLine("\n\n\n");

            Console.WriteLine(superVilian2.ToString());
            Console.WriteLine("Malice: " + superVilian2.Malice);

        }
    }
}
