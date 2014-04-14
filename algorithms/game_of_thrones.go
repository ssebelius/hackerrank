package main

import (
  "fmt"
)

func main() {
  var input string
  fmt.Scan(&input)
  
  //fmt.Println(input)
  
  count:= 0
  charMap:= make(map[rune]int)
  for _, c := range input {
      // do something with c
    //fmt.Println(c)
    charMap[c]++
    if(charMap[c]%2 != 0) {
      count++
    } else {
      count--
    }
  }
  if count > 1 {
  	fmt.Println("NO")
  } else {
    fmt.Println("YES")
  }
} 