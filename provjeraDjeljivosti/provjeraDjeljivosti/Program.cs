using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj: ");
        int broj = Convert.ToInt32(Console.ReadLine());

        if (broj % 4 == 0 && broj % 6 == 0)
        {
            Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
        }
        else if (broj % 4 == 0)
        {
            Console.WriteLine("Broj je djeljiv s 4");
        }
        else if (broj % 6 == 0)
        {
            Console.WriteLine("Broj je djeljiv s 6");
        }
        else
        {
            Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");
        }
    }
}

