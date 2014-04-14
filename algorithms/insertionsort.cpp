#include <cstdio>
#include <cstring>
#include <string>
#include <cmath>
#include <cstdlib>
#include <cassert>
#include <iostream>
using namespace std;

void printArr(int size, int* ar) {
  for(int i=0; i< size; i++)
    std::cout << ar[i] << " ";
  
  std::cout << std::endl;
}

void insertionSort(int ar_size, int *  ar) {
  	int value;
  	for(int index=1; index<ar_size; ++index) {
      value = ar[index];
      //5
      //0 1 2 3 4
      //2 4 6 8 3
      
      int subIndex = index;
      while(subIndex > 0 && ar[subIndex-1] > value) {   
        ar[subIndex] = ar[subIndex-1];
        subIndex--;
      }
      ar[subIndex] = value;
      
      printArr(ar_size, ar);
    }
}
int main(void) {
   
    int _ar_size;
    cin >> _ar_size;
    //scanf("%d", &_ar_size);
    int _ar[_ar_size], _ar_i;
    for(_ar_i = 0; _ar_i < _ar_size; _ar_i++) { 
        cin >> _ar[_ar_i];
        //scanf("%d", &_ar[_ar_i]); 
    }

   insertionSort(_ar_size, _ar);
   
   return 0;
}
