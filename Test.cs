using System;

namespace ArrayTest
{
    class Program
    {
       
       public void DimensionalArray()
       {
       
       }
        
        public static void UserArray()
        {
  int[] arr = new int[10]; 
    int i;  
       Console.Write("\n\nRead and Print elements of an array:\n");
       Console.Write("-----------------------------------------\n");	
  
    Console.Write("Input 10 elements in the array :\n");  
    for(i=0; i<10; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  	
         if(arr[i] == 2)
           {
            break;
         }	
    }  
  if(arr[i] == 2 )
  {
      Console.WriteLine("HEllo MAchi");
  }
    Console.Write("\nElements in array are: ");  
    for(i=0; i<arr.Length; i++)  
    {  
        Console.Write("{0}  ", arr[i]);  
    } 
    Console.Write("\n");
        }
        static void Main(string[] args)
        {
           UserArray();
          // DimensionalArray();
        }

    }
}
