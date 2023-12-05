//program that will take two inputs
//numbers and print whether the second number is a multiple of the first.
//If the second number is not a multiple of the first, then the program displays
//remainder of the division
//14,5 -> no, 4; 16, 8 -> yes

Console.Clear();

Console.Write("Enter first number - ");
string strFirstNum = Console.ReadLine();
int.TryParse(strFirstNum, out int FirstNum);
Console.Write("Enter second number - ");
string strSecondNum = Console.ReadLine();
int.TryParse(strSecondNum, out int SecondNum);

int Result = FirstNum % SecondNum;
if (Result == 0)
{
    Console.WriteLine("Yes, the second number is multiple of the first number");
}

else
{
    Console.WriteLine($" No, the second number is not multiple of the first number. Remainder of the division - {Result}");
}
