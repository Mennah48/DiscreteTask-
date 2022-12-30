using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int sum ; 
        Console.WriteLine("Please,Enter the start of the range :");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Please,Enter the end of the range : ");
        int end = int.Parse(Console.ReadLine());
        
      for (int i=start; i<=end;i++)
      {
        sum=0;
        for (int factor=1; factor<i; factor++)
        {
          if(i%factor==0)
          {
            sum=sum+factor;
          }
        }
        
        if(sum==i)
         {
          Console.WriteLine(i);
         }
      }
     }
   }
 }
