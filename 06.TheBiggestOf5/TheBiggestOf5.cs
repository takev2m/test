using System;

class TheBiggestOf5
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }

        //float a = float.Parse(Console.ReadLine());
        //float b = float.Parse(Console.ReadLine());
        //float c = float.Parse(Console.ReadLine());
        //float d = float.Parse(Console.ReadLine());
        //float e = float.Parse(Console.ReadLine());
        //float biggestNum = a;

        //if (a < b)
        //{
        //    biggestNum = b;
        //}
        //if (biggestNum < c)
        //{
        //    biggestNum = c;
        //}
        //if (biggestNum < d)
        //{
        //    biggestNum = d;
        //}
        //if (biggestNum < e)
        //{
        //    biggestNum = e;
        //}
        //Console.WriteLine(biggestNum);
    }
}
