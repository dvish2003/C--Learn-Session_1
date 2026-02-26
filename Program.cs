using System;
using FirstApp;

class Program
{

    //method definition
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        //variables and data types

        int number = 10;
        string text = "This is a string.";
        bool isTrue = true;
        double pi = 3.14159;

        Console.WriteLine("Number: " + number);
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Boolean: " + isTrue);
        Console.WriteLine("Pi: " + pi);

        // for loop

        Console.WriteLine("For loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }


        // for Each loop

        Console.WriteLine("For Each loop:");
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }

        // calling the method
        int sum = Sum(5, 7);
        Console.WriteLine("Sum of 5 and 7: " + sum);

        // creating an object of the Student class and setting its properties
        Student student1 = new Student();
        student1.name = "John Doe";
        student1.age = 20;
        Console.WriteLine("Student Name: " + student1.name);
        Console.WriteLine("Student Age: " + student1.age);



        //inheritance
        Dog dog = new Dog();
        dog.eat(); // Inherited method from Animal class
        dog.bark(); // Method from Dog class

    }
}