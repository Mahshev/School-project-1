using System;

public class MaProgram
{

    public static void Main (string[] args)
    {
        char k;
        float p;
        Console.WriteLine("Pls type a character.");
        k = char.Parse(Console.ReadLine());
        Console.WriteLine("Pls type how long the triangle is");
        p = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("  " + k);
        Console.Write(" " + k); Console.Write(k); Console.WriteLine(k);
        Console.Write(k); Console.Write(k); Console.Write(k); Console.Write(k); Console.WriteLine(k);
        Console.WriteLine(" ");
        Console.WriteLine("The shetah of the triangle is: " + p * p / 2 + "the hekeph is: " + p * 3);

        Console.ReadLine();
    }


}

using System;

public class MaProgram
{

    public static void Main(string[] args)
    {
        double dollar, trip, kitzba;
        Console.WriteLine("Pls type how much 1 dollar is in shekels.");
        dollar = double.Parse(Console.ReadLine());
        Console.WriteLine("How much does the trip cost? (in dollars)");
        trip = double.Parse(Console.ReadLine());
        kitzba = 400;
        Console.WriteLine("The trip cost " + (dollar * trip + kitzba * dollar) + " in shekels.");
        Console.ReadLine();

    }


}


using System;

public class MaProgram
{

    public static void Main (string[] args)
    {
        double r, e;
        e = 1.6;
        Console.WriteLine("pls type how long your car has driven.(in miles)");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("Your car drived " + e * r + " kilometers.");
        Console.ReadLine();
        
            
    }


}


using System;

public class MaProgram
{

    public static void Main (string[] args)
    {
        double day, night, shabat;
        double dayhour, nighthour, shabathour;
        Console.WriteLine("How much does a worker get for 1 hour a day?");
        day = double.Parse(Console.ReadLine());
        night = 1.5 * day;
        shabat = 2 * day;
        Console.WriteLine("pls write how much hours does the worker work for 1 day, night, shabat(in this order");
        dayhour = double.Parse(Console.ReadLine());
        nighthour = double.Parse(Console.ReadLine());
        shabathour = double.Parse(Console.ReadLine());
        Console.WriteLine("The worker has gained " + (dayhour * day + nighthour * night + shabathour * shabat) + " shekels past the last week");
        Console.ReadLine();
    }


}


using System;

public class MaProgram
{

    public static void Main(string[] args)
    {
        int twonumber, sh, helkten;
        Console.WriteLine("Please put a two digit number:");
        twonumber = int.Parse(Console.ReadLine());
        sh = twonumber % 10;
        helkten = twonumber / 10;
        Console.WriteLine("the sum of the two digit number is " + (sh + helkten));
    }


}
