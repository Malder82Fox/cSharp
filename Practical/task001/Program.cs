// this code checks if the first number is the square of the second
while(true)
{
    Console.Clear();
    Console.Write("Enter first number - ");
    string strnumA = Console.ReadLine();
    int.TryParse(strnumA, out int numA); // convert from type "string" to type "int"
    Console.Write("Enter second number - ");
    string strnumB = Console.ReadLine();
    int.TryParse(strnumB, out int numB);
    int numcheck = numB * numB;
    if(numcheck == numA)
    {
        Console.WriteLine("yes, first number is the square of the second");
    }
    else
    {
        Console.WriteLine("No, first number isn't the square of the second");
    }
    Console.Write("Do You wnant to continue? (Y/N): ");
    string usercheck = Console.ReadLine();
    if(usercheck.ToLower() == "n" || usercheck.ToLower() == "exit" || usercheck.ToLower() == "н" || usercheck.ToLower() == "q") //one of the conditions is met
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break; //exit from while 
    }
    else
    {
        Console.Clear();
    }
}
