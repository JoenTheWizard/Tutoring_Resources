## Note
The following tasks may require you to research certain subjects on your own. You will apply your current understanding of the C# programming languages, but certain tasks (such as certain algorithms, mathematical equations etc) will be done via researching maybe through online sources, documentation or books. Part of what makes software engineering, or engineering as a whole is to continously learn about new topics frequently. As technologies evolve, you will be required to learn more and more as a software/cybersecurity engineer.

If you are having troubles with some of the questions, it's fine to skip some of them and work on another question then come back to it when you feel ready.

# Task 1
## Sum values
Write a C# function that takes an integer input and calculates the sum of all numbers from 1 up to that input number.
Make sure to display the calculated sum as the output and check for values of 0 or smaller, if so print 'Invalid' and return.
Example
```cs
using System;
					
public class Program
{
  //Write your function here

	public static void Main()
	{
		CalculateSum(5); //Would output to the console '15' (1 + 2 + 3 + 4 + 5)
	}
}
```

# Task 2
## Reverse a String
Write a C# function that takes a string as input and returns the string reversed.

Example:
```cs
using System;
				
public class Program
{
  //Write your function here

	public static void Main()
	{
		Console.WriteLine(ReverseString("Hello, world!")); // Output: "!dlrow ,olleH"
	}
}
```

# Task 3
## Calculate the Factorial of a Number
Write a C# function that takes an integer input and calculates the factorial of that number.

Example:
```cs
using System;
				
public class Program
{
  //Write your function here

	public static void Main()
	{
		Console.WriteLine(Factorial(5)); // Output: 120
	}
}
```

# Task 4
## Bank account class
Write a C# class that simulates a basic bank account. The class should have properties for the account number, account holder name, and balance. Implement methods to deposit, withdraw, and display the account details, including the account balance.

# Task 5
## Enums
Create an enum called Color representing different colors: Red, Green, Blue, Yellow, and White. Write a program that prompts the user to enter their favorite color and displays a message based on the entered color. If the color is Red, display "Red is a vibrant color!". If the color is Green, display "Green represents nature and freshness.". If the color is Blue, display "Blue symbolizes calmness and serenity.". If the color is Yellow, display "Yellow is associated with happiness and energy.". If the color is White, display "White signifies purity and innocence.". For any other color, display "Your favorite color is unique!".

# Task 6
## Dictionaries
Use the following data stored from a file
```
Alice: 85
Bob: 73
Charlie: 92
Dave: 68
```
And store them into dictionaries (it should be of types <string,int>). Then output the user with the highest score from the dictionary


# Task 7
## Linked list
Write a linked list class for strings in C#. It should be able to append, push and pop strings from the list. Also implement a 'printList()' function in order to print the contents from the list
Example of using the list in a prgoram
```cs
MyLinkedList list = new MyLinkedList();
list.add("a");
list.add("b");
list.add("c");

list.pop()
list.pop()

list.push("hello");

list.printList();
```

# Task 8
## Multithreading
### This task might require you research more on Threads in C#
Write a C# program that creates a user-defined number of threads within a Console environment. Each thread should execute concurrently and print a message indicating its thread number. The program should prompt the user to enter the number of threads and then create the specified number of threads. Each thread should print a message stating its thread number. Additionally, introduce a random delay (between 1 and 10 seconds) using the `Thread.Sleep` method to simulate some processing time before printing the message.
Note:
If you want to get a random delay amount in C# between 1-10 seconds use `new Random().Next(1000,10001)` (in terms of milliseconds)

# Task 9
## Temperature converter GUI
### This task might require you research more on the other WPF controls (such as RadioButtons)
Create a simple WPF application that allows users to convert temperatures between Celsius and Fahrenheit. The application should have the following components:
- One TextBox for the input value
- Two RadioButton controls to select the conversion direction: Celsius to Fahrenheit or Fahrenheit to Celsius.
- One label to display the result from the converted value
- A button to trigger the temperature conversion event

Requirements:
- The conversion formula from Celsius to Fahrenheit is: Fahrenheit = (Celsius * 9/5) + 32.
- The conversion formula from Fahrenheit to Celsius is: Celsius = (Fahrenheit - 32) * 5/9.
- The result should be rounded to two decimal places.
- Orientation does not matter (You can split the grid into sections if you want)

# Task 10
## Bookstore
### This task might require you research more on the other WPF controls (such as ListBox)

Create a simple WPF application for a bookstore that allows users to search for books based on their titles. The application should have the following components:
- A TextBox for entering the search query.
- A Button to trigger the search event.
- A ListBox to display the search results.

Requirements:
- When the user enters a search query and clicks the search button, the application should display the books whose titles contain the search query in the ListBox.
- Create a class named Book with properties like Title, Author, and Genre.
- Create a collection of Book objects to represent the available books in the bookstore.
- If no books match the search query, display a message in the ListBox indicating that no results were found.
- Store a `books.txt` file for which the library will store all the books. The file will be in the format of `Title,Author,Genre` in a new line. The file should contain the following:
```
Harry Potter and the Philosopher's Stone, J.K. Rowling, Fantasy
To Kill a Mockingbird, Harper Lee, Fiction
The Great Gatsby, F. Scott Fitzgerald, Fiction
Pride and Prejudice, Jane Austen, Romance
1984, George Orwell, Dystopian
The Catcher in the Rye, J.D. Salinger, Fiction
```

Add a 'Add to library' and 'Remove from library' button that modifies the text file where it adds or removes from the input text box. Remember to refresh the list box view.
Add another listbox to the side of the main listbox that lists the Title, Author and Genre when a user clicks on the a specific book

# Task 11
## Interfaces
Create an IProduct interface that includes the common properties and methods of a product. Then create two classes, Book and ElectronicDevice, that implement the IProduct interface.
Using this interface:
```cs
public interface IProduct {
    string Name { get; set; }
    decimal Price { get; set; }
    string GetProductDetails();
}
```

The `GetProductDetails()` strings should return:
- Book class: `$"Book: {Name}, Author: {Author}, Price: {Price}";`
- ElectronicDevice class: `$"Electronic: {Name}, Brand: {Brand}, Price: {Price}";`

# Task 12
## Virtual/Override polymorphism
Create a base class Shape with a virtual method Draw(). Then create three derived classes Circle, Rectangle, and Triangle, each of which overrides the Draw() method to output a specific message for each shape (You can just print something like `Drawing a [shape]`). Finally, create a list of Shape objects, add instances of Circle, Rectangle, and Triangle to it, and iterate over the list calling Draw() on each shape. The output should output the correct message for each shape type.
Example output:
```cs
Drawing a circle
Drawing a rectangle
Drawing a triangle
```

# Task 13
## Windows Forms
Recreate one of the previous WPF GUIs you have created from the previous tutoring sessions to the .NET Windows Forms framework. It could be the Library GUI, the Text Editor GUI etc (Just pick one of them to do, or both if you want to)

# Task 14
## Code to UML
Convert the following C# code to a UML diagram
```cs
public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
    public List<PhoneNumber> PhoneNumbers { get; set; }
    public void Greet() {
        Console.WriteLine("Hello, I'm " + Name);
    }
}

public class Employee : Person {
    public string EmployeeId { get; set; }
    public string Department { get; set; }
    public void Work() {
	Console.WriteLine("Working...");
    }
}

public class Address {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
}

public class PhoneNumber {
    public string Number { get; set; }
    public string Type { get; set; }
}

public class Course {
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public Department Department { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Instructor> Instructors { get; set; }
}

public class Department {
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public ICollection<Course> Courses { get; set; }
}

public class Student : Person {
    public int StudentId { get; set; }
    public ICollection<Course> Courses { get; set; }
    private void EnrollCourse(Course course) {
        Courses.Add(course);
    }

    private void DropCourse(Course course) {
        Courses.Remove(course);
    }
}

public class Instructor : Person {
    public int InstructorId { get; set; }
    public ICollection<Course> Courses { get; set; }
    private OfficeAssignment OfficeAssignment { get; set; }
}

public class OfficeAssignment {
    public int OfficeAssignmentId { get; set; }
    public string Location { get; set; }
    public Instructor Instructor { get; set; }
}
```

# Task 15
## UML to code
Convert the following UML diagram to C# code
![](https://miro.medium.com/v2/resize:fit:1400/1*TYRSuON0vVxy8olllrBVEw.png)
