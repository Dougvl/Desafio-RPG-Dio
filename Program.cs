using System;
using RGP_Dio.src.Entities;

namespace RGP_Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight", 500, 100);
            Knight enemy= new Knight("Mefistofilico", 99 , "Satango", 2000, 300);
            Druid druid= new Druid("Jenica", 23 , "Druid", 250, 500);
            Sorcerer sorcerer = new Sorcerer("Mage do terror", 45, "Sorcerer", 600, 1000);
            Paladin paladin = new Paladin("Daniel", 50, "Paladin", 1000, 800 );

            Console.WriteLine(knight);
            Console.WriteLine(knight.Attack(10));
            Console.WriteLine();
            Console.WriteLine(druid);
            Console.WriteLine(druid.Attack(10));
            Console.WriteLine();
            Console.WriteLine(sorcerer);
            Console.WriteLine(sorcerer.Attack(10));
            Console.WriteLine();
            Console.WriteLine(paladin);
            Console.WriteLine(paladin.Attack(10));
        }
    }
}
