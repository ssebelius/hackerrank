using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static void nextMove(int n,int r, int c, String [] grid){
    int index =0;
  	int pr = 0;
  	int pc = 0;
  	foreach(String s in grid) {
      index = s.IndexOf('p');
      if(index != -1) {
        pc = index;
        break;
      }
      pr++;
    }
  	
  var x = pc - c;
  var y = pr - r;
  
  string dir;
  if(x < y || y == 0)
    dir = x > 0 ? "RIGHT" : "LEFT";
  else
    dir = y < 0 ? "UP" : "DOWN";
  
  Console.WriteLine(dir);

}
static void Main(String[] args) {
        int n;

        n = int.Parse(Console.ReadLine());
        String pos;
        pos = Console.ReadLine();
        String[] position = pos.Split(' ');
        int [] int_pos = new int[2];
        int_pos[0] = Convert.ToInt32(position[0]);
        int_pos[1] = Convert.ToInt32(position[1]);
        String[] grid  = new String[n];
        for(int i=0; i < n; i++) {
            grid[i] = Console.ReadLine(); 
        }

        nextMove(n, int_pos[0], int_pos[1], grid); 

     }
}
