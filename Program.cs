//  Module 1, Week 1, In Class Assignment
//  Display some text using Console.WriteLine() or Console.Write().
//  Wait for a user's response using Console.Read(), Console.ReadKey(), or Console.ReadLine().
Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

Console.Write("Please enter your name:  ");
var userInput = Console.ReadLine();

Console.Write("Please enter your birth year:  ");
var birthYear = Console.ReadLine();

Console.WriteLine($"Hello {userInput}, welcome to the C# programming world!");
Console.WriteLine($"{birthYear} was a good year!");

Console.WriteLine();
