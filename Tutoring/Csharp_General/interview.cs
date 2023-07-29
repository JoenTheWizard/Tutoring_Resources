using System;

public class Program
{
    //Initialize the enum 'Days' which stores the days of week in order
    enum Days
    {
        Monday,
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main()
    {
        //Initialize a value from the enum 'Days'
        Days days = Days.Saturday;

        //This casts '1' to 'Days' enum. It is equivalent to saying Days.Tuesday
        //Days days1 = (Days)1;

        //Print the value from 'days' that it stores
        Console.WriteLine("The day today is " + days);

        //Enums are stored as if they were integer values with specific uses/values.
        //So in our case Days enum at '0' represents 'Monday' or '1' represents 'Tuesday'

        //So if we have a day that's greater than 'Friday' then it is a weekend otherwise it is a weekday
        if (days > Days.Friday)
        {
            Console.WriteLine("It is a weekend");
        }
        else
        {
            Console.WriteLine("It is a weekday");
        }

        //Reasons to use switch case over if else/else if is simply because we can minimize the verbosity
        //if we have a lot of conditional checks/statements.
        string name = "John";

        switch (name)
        {
            case "John":
                Console.WriteLine("Hello John");
                break;
            case "Tom":
                Console.WriteLine("Hello Tom");
                break;
            case "Jim":
                Console.WriteLine("Hello Jim");
                break;
            default:
                Console.WriteLine("I do not know who you are.");
                break;
        }

        //2D dimensional arrays
        //4 columns 4 rows
        int[,] vals = { { 1 , 2, 3, 4 }, 
                    { 2 , 3, 4, 5 }, 
                    { 3 , 4, 5, 6 },
                    { 4, 5, 6, 7 } };

        //2 rows 1 Column
        int[,] vals1 = new int[2, 1] { { 1 },
                                       { 2 } };

        //Dictionary Initialization
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        //Append/add value to the dictionary
        dictionary.Add(1, "value1");

        //Print each value from the dictionary
        foreach (var val in dictionary.Values) {
            Console.WriteLine(val);
        }

        //Lists are dynamic, in the way that we can dynamically add values to the list during run-time
        //of the program. Unlike arrays which are statically initialized.
        List<string> list = new List<string>();
        list.Add("Val");

        //Queues
        //Queues rely on a first-in-first-out structure (FIFO)
        Queue<string> queue = new Queue<string>();
        //Enqueue adds to the end of the queue
        queue.Enqueue("Hello");
        queue.Enqueue("World");
        queue.Enqueue("!");

        //Dequeue removes the start of the queue
        queue.Dequeue();

        //Print each value within the queue
        foreach (var obj in queue)
            Console.Write("{0} ", obj);
        Console.WriteLine();

        //Stacks are last-in-first-out (LIFO). The last element that is appended to the stack will be the last one
        //removed.
        Stack<string> stack = new Stack<string>();
        //Push adds to the top of the list
        stack.Push("Hello");
        stack.Push("World");
        stack.Push("!");

        //Pops the top of the list (which is our recently pushed value in the stack '!')
        stack.Pop();

        //Print each value within the stack
        foreach (var obj in stack)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}
