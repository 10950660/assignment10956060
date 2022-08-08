using System;
using System.Linq;
using System.Collections.Generic;


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter number");
    
    int b = Convert.ToInt32(Console.ReadLine());
    int a = b-1;
    
    if (b<3){
      Console.WriteLine("There are no prime numeber less than this number");
    }
    
    bool? isPrime = null;
     List<int> prime= new List<int>(); 
    
    while (a > 1){
      int c = 2;
      if(a == 2){
        isPrime = true;
      }
      else {
        while (c < a){
          if (a % c == 0){
            isPrime = false;
            break;
          }
          else {
            c++ ;
            if (a == 3){
              isPrime = true;
            }
          }
          if (c == a - 1){
            isPrime = true;
          }
        }
      }
      
      if (isPrime == true){
       
        
        prime.Add(a);
      

        double avg = Queryable.Average(prime.AsQueryable());
        Console.WriteLine("The average is " + avg);

        
        

      }
      a -= 1;
    }
    

    
  }
}