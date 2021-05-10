using System;

namespace CallByVF
{
    class Program
    {
        // public static void CallByValus(int n) // CAll Vy Valeus
        // {
        //      ++n;
        //     Console.WriteLine("CAll By Values :"+n);
        // }
     public static void CAllByFef(ref int n)  // CAll Vy Refernce
     {
            ++n;
           Console.WriteLine("CAll By Reference :"+n);
     }

        static void Main(string[] args)
        {
           
            int i = 5;
             Console.WriteLine("Initiazing the Values for i : "+i);
            // CallByValus(i);
               CAllByFef(ref i);
             Console.WriteLine("After Passing : "+i);
           // CallByVTest();
        }
    }
}
