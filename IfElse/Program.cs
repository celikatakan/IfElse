using System;

class IfElse

{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");

        int sayı = Convert.ToInt32(Console.ReadLine());

        if (sayı > 10)
        {
            Console.WriteLine("Girilen sayı 10'dan büyüktür.");

        }
        else if (sayı < 10)
        {
            Console.WriteLine("Girilen sayı 10'dan küçüktür.");
        }
        else
        {
            Console.WriteLine("Girilen sayı 10'a eşittir.");
        }

        if (sayı % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");

        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }




    }
}