package main

import (
	"fmt"
)

func main() {
	var N int
	fmt.Scan(&N)

	var T int
	fmt.Scan(&T)

	var width = make([]int, N)
	for i:=0; i < N; i++ {
     	fmt.Scan(&width[i])
	}
  
	for t:=0; t < T; t++ {
		var i int
		var j int
		fmt.Scan(&i)
		fmt.Scan(&j)

		largest := 3
		for i <= j {
          if width[i] < largest {
            largest = width[i]
          }
          i++
        }
		fmt.Println(largest)
	}
}