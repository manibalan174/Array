using System;

namespace Array
{
    class Program
    {
        public void Array(int[] arry)
        {
            Console.WriteLine("Array Exection");
            for(int i=0; i<arry.Length;i++)
            {
                Console.WriteLine(arry[i]);
            }
        }
        public static void Arry1()
        {
            Console.WriteLine("Ddeclareing Array VAluse");
            int[] Number = new int[5];
              Number[0]=1;
              Number[2]=3;
              Number[4]=5;
              for(int i =0; i< Number.Length;i++)
              {
                  Console.WriteLine(Number[i]);
              }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program P = new Program();
            int[] arry1={10,20,30,40,50};
            int[] arry2={1,2,3,4,5};
            P.Array(arry1);
            P.Array(arry2);
            Arry1();
        }
    }
}
