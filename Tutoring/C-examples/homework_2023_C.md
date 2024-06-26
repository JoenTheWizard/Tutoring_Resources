## Note

The following tasks may require you to research certain subjects on your own. You will apply your current understanding of the C programming languages, but certain tasks (such as certain algorithms, mathematical equations etc) will be done via researching maybe through online sources, documentation or books. Part of what makes software engineering, or engineering as a whole is to continously learn about new topics frequently. As technologies evolve, you will be required to learn more and more as a software/cybersecurity engineer.

If you are having troubles with some of the questions, it's fine to skip some of them and work on another question then come back to it when you feel ready.

# Task 1
## C pointers
Write a program to demonstrate how to use a pointer to change the value of a variable. The following program is a template:
```c
#include <stdio.h>
int main(void) {
    int num = 10;
    int *p = &num;

    printf("Before change: %i\n", num);

    //Change the value here using 'p'. Hint: Try utilizing dereferences

    printf("After change: %i\n", num);

    return 0;
}
```

# Task 2
## Dynamic memory
Dynamically allocate an array of integers of size 5, assign values to each index (1-5) and print it. Make sure to free the memory afterwards (you can use tools like `valgrind` to help you to detect memory leaks). Remember to use Valgrind by doing `valgrind ./<executable>`, in which you can see the heap summary.

# Task 3
## Makefiles
Write a Makefile that compiles a C program with source file: main.c. The executable should be named `myprogram`, in the makefile store the executable name in a variable called `EXEC`. The Makefile should also include a `clean` target that removes all the generated files.

# Task 4
## Modify array
Make a function `modify_array()` that takes in the array {1,2,3} and modifies the first value ('1') to another value (can be any other value). Make sure to print the array before and after its passed to modify_array()

# Task 5
## Arrays and pointers
Write a C program that includes an array of integers (of any size you want greater than 1) and a pointer. Assign the address of the first element of the array to the pointer. Now, use the pointer to traverse the array and print its elements. Explain how this works in terms of memory addresses.

# Task 6
## Bubble sort
Write a program that uses the bubble sort algorithm to sort an array of characters (Hint: 'chars' can be compared with their **ASCII values**). Try to sort it ascending order and then descending order and describe what you did to change it. You can use the below as a template

```c
#include <stdio.h>
int main(void) {
    char arr[] = {'j','l','u','c','k','a','t','w'};
    int n = sizeof(arr)/sizeof(arr[0]);
    
    //Call your function here: bubbleSort()
    
    printf("Sorted array: ");
    for (int i=0; i < n; i++)
        printf("%c ", arr[i]);
        
    return 0;
}
```

# Task 7
## Loops (revision)
Write a C program that reads a positive integer `n` from the user and then displays the sum of all the values from 1 to n
Example how the program would look like:
```c
./myprogram
Enter n value: 3
Sum: 6
```

# Task 8
## Conditions (revision)
 Write a C program that reads a temperature in Celsius and displays a message indicating the weather condition based on the following ranges:
- Temp < 0: "Freezing weather"
- Temp 0-10: "Very cold weather"
- Temp 10-20: "Cold weather"
- Temp 20-30: "Normal temperature"
- Temp 30-40: "It's hot"
- Temp >= 40: "It's very hot"

# Task 9
## More loops
Write a C program that calculates the sum of all multiples of 3 or 5 below a given number using a while loop. The program should prompt the user to enter a non-negative integer, and then output the sum of all multiples of 3 and 5 that are less than that number.

# Task 10
## sizeof()
Write a C program that calculates the size of various data types. The program should output the size in bytes for the following data types: `char`, `int`, `float`, `double`, and `long`. Additionally, make an array (any length greater than 1) of each of those types and print the sizes (in bytes). Explain the outputs.

# Task 11
## Fibonacci sequence
Write a C program that uses recursion to generate the first N terms of the Fibonacci sequence, where N is a positive integer input by the user. The program should prompt the user to enter the value of N, then print the first N terms of the Fibonacci sequence (remember that the Fibonacci Sequence is `F(n) = F(n-1) + F(n-2)`).

# Task 12
## Graph theory
Write a program to represent the following graph using an adjency matrix.
![](https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/6n-graf.svg/1200px-6n-graf.svg.png)
