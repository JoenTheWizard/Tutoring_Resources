#include <stdio.h>

void swap(int* a, int* b) {
    int tmp=*a;*a=*b;*b=tmp;
}

//Quick sort using last value as pivot. Quick sort can also use the first or the median value in the array as pivot.
//It's a recursive algorithm meaning that it will execute itself until a condition is fully satisfied and will return.
void quicksort(int* arr, int start, int end) {
    if (start >= end) return;
    
    int pivot = arr[end];
    
    int j = start;
    int i = j-1;
    
    for (; j < end; j++) {
       if (arr[j] < pivot) {
            swap(&arr[++i], &arr[j]);
        }
    }
    
    swap(&arr[++i], &arr[j]);
    
    quicksort(arr, start, i - 1);
    quicksort(arr, i + 1, end);
}

int main() {
    
    int arr[] = {8,2,4,7,1,3,9,6,5};
    
    ssize_t size = sizeof(arr)/sizeof(arr[0]);
    
    quicksort(arr, 0, size - 1);
    
    for (int i = 0; i < size; i++) {
        printf("%d ", arr[i]);
    }

    return 0;
}
