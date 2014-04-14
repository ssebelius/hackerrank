package main

import "fmt"

func main() {
	var T int
  	var N int
  
  	fmt.Scan(&T)
  
    for i := 0; i < T; i++ {
      fmt.Scan(&N)
      height := 1
      for j:= 0; j < N; j++ {
        if j % 2 == 0 {
        	height *= 2
        } else {
        	height++
        }
      }
      fmt.Println(height)
    }
}