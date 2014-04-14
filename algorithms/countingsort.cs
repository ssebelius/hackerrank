using System;
class Solution {
  static void Main(string[] args) {
    int[] count = new int[100];
    
    int n = int.Parse(Console.ReadLine());
    for(int i=0; i<n; ++i) {
      string[] tokens = Console.ReadLine().Split();
      int value = int.Parse(tokens[0]);
      count[value]++;
    }

    int[] answer = new int[100];
    answer[0] = count[0]; // first case
    for(int i=1; i<100; ++i) {
		if(count[i] == 0)
          answer[i] = answer[i-1];
      	else
          answer[i] = count[i] + answer[i-1];
    }

    Console.WriteLine(String.Join(" ", answer));
  }
}