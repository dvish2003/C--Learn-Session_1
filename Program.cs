using System;
using System.Security.Cryptography.X509Certificates;
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

        //interface
        Cat cat = new Cat();
        cat.eat(); // Implementation of eat method from IAnimal interface

        //using the UserService class to create a user
        UserService userService = new UserService();
        userService.CreateUser("Alice", 30);




        //. create list
        List<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        Console.WriteLine("Names in the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //LINQ query ====================================================================
        //filters number

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 343, 23, 12, 3, 78, 98, 65, 22, 4, 55, 88 };
        //where
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }


        //select
        var doubledNumbers = numbers.Select(n => n * 2);
        Console.WriteLine("Doubled numbers:");
        foreach (int num in doubledNumbers)
        {
            Console.WriteLine(num);
        }
        


        //First
        var firstEven = numbers.First(n => n % 2 == 0);
        Console.WriteLine("First even number: " + firstEven);

        //order by
        var orderedNumbers = numbers.OrderBy(n => n);
        Console.WriteLine("Ordered numbers:");
        foreach (int num in orderedNumbers)        {
            Console.WriteLine(num);
        }

        //Any by
        bool hasEven = numbers.Any(n => n % 2 == 0);
        Console.WriteLine("Contains even numbers: " + hasEven);


        //real worl example LINQ
        List<Student> students = new List<Student>
        {
            new Student("Alice", 12),
            new Student("Bob", 14),
            new Student("Charlie", 19),
            new Student("David", 21),
            new Student("Eve", 20),
            new Student("Frank", 18),
            new Student("Grace", 11),
            new Student("Heidi", 22),
            new Student("Ivan", 2),
            new Student("Judy", 21)
        };


        var eligibleListStudent = students.Where(s => s.age >= 18).Select(s => s.name).ToList();
        Console.WriteLine("Eligible students for the program:");
        foreach (string studentName in eligibleListStudent)        {
            Console.WriteLine(studentName);
        }



        //orderby
        List<int> numbers_1 = new List<int> { 5, 2, 9, 1, 5, 6 };
        var sortedNumbers = numbers_1.OrderBy(n => n);
        Console.WriteLine("Sorted numbers:");
        foreach (int num in sortedNumbers)        {
            Console.WriteLine(num);
        }



            //====================================================================================================
       
}
}