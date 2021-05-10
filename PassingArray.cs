using System;
using System.Linq;
namespace Arrar2
{
    class Program
    {
        public static void maxArray(int[] Arry)
        {
              //int[] Arry1 = new int[];
              Console.WriteLine("Max Array Values : "+Arry.Max());
        }
        public  static void minArray(int[] Arry2)
        {
             // int[] Arry2 = new int[];
              Console.WriteLine("Max Array Values : "+Arry2.Min());
        }
        public static void twoDimension()
        {
            
            int[,] arr=new int[3,3];//declaration of 2D array  
             arr[0,1]=10;//initialization  
               arr[1,2]=20;  
               arr[2,0]=30;  
  
                      //traversal  
               for(int i=0;i<3;i++){  
                       for(int j=0;j<3;j++){  
                             Console.Write(arr[i,j]+"\t");  
                                   }  
                     Console.WriteLine();//new line at each row  
                    }  

        }
           public static void twoDimensionnxt()
           {
               int[,] ArrTwo={{1,2},{3,4}};
               for(int i=0; i<2;i++)
               {
                   for(int j=0; j<2;j++)
                      {
                          Console.Write(ArrTwo[i,j]+"\t");
                      }
                   Console.WriteLine();
               }
           }
          public static void threeDimensionnxt()
        {
             int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  
  
        //traversal  
          for(int i=0;i<3;i++){  
            for(int j=0;j<3;j++){  
                Console.Write(arr[i,j]+" ");  
            }  
            Console.WriteLine();//new line at each row  
        }  


        }
          public static void minmaxMethod()
        {
            int min,max;
             int[,] arr = { { 1, 20, 3 }, { 40, 5, 6 }, { 7, 80, 9 } };//declaration and initialization  
              max=arr[0,0];
              min=arr[0,0];
        //traversal  
           for(int i=0;i<3;i++)
           {
               for(int j=0; j<3;j++)
               {
                   if(arr[i,j] > max)  //  max Array Length
                   {
                         max=arr[i,j];
                   }
                     if(arr[i,j] < min)  //  max Array Length
                   {
                         min=arr[i,j];
                   }
                  
               }
           }
             Console.WriteLine("Max Values : "+max);
              Console.WriteLine("min Values : "+min);
        }

         public static void JaggedArray()
         {
             int[][] arry = new int[3][] {
                  new int[] { 1 ,2 ,3 ,4 ,5 },
                  new int[] { 0 , 3 },
                  new int[] { 2 , 3 , 4 , 5 , 6 ,7 }
             };
             for(int i=0; i < arry.Length;i++)
             {
                 for(int j=0; j < arry[i].Length;j++)
                 {
                     Console.Write(arry[i][j]+" , ");
                 }
                 Console.WriteLine();
             }
         }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arry1={10,20,30,40,50};
            int[] arry2={1,2,3,4,5};
           // int[,] arry3={{1,2,3},{4,5}};
            maxArray(arry1);
            minArray(arry2);
            twoDimension();
            twoDimensionnxt();
            threeDimensionnxt();
            minmaxMethod();
            JaggedArray();
        }
    }
}
