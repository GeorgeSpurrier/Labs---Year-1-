/*
 * User Input
 * This program asks the user for their name and age and then outputs a greeting message.
 */

//Welcome message
Console.WriteLine("Greeter Program");

// Ask the user for their name store it in a variable
Console.WriteLine("Hello, What is your name?");
string name = Console.ReadLine();

// Create a greeting message
string output = "Hello, " + name;

// Ask the user for their age and store it in a variable
Console.WriteLine("What is your age?");
string age = Console.ReadLine();

// Add the age to the greeting message
output += " you are " + age + " years old!";
Console.WriteLine(output);

