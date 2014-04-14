using System;
using System.Collections.Generic;
class Solution {
  
  static void Main(string[] args) {
    List<double> fibonnaci = new List<double>();
    
    int i=2;
    fibonnaci.Add(0); 
    fibonnaci.Add(1);
    double fib;
      
double max = Math.Pow(10,10);
   	while(true) {
      fib = fibonnaci[i-1] + fibonnaci[i-2];
      if(fib <= max) {
        //Console.WriteLine("add " + fib);
        fibonnaci.Add(fib);
      }
      else
        break;
      i++;
    }
    
    int T = int.Parse(Console.ReadLine());
    while(T-- > 0) {
      double N = double.Parse(Console.ReadLine());
      if(fibonnaci.Contains(N))
        Console.WriteLine("IsFibo");
      else
        Console.WriteLine("IsNotFibo");
    }
  }
  
}