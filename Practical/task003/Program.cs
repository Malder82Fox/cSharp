// this code makes the sum of the first and last digit of a three digit number

Console.Clear();

Console.Write("Enter three-digital number - ");
string strThreeNum = Console.ReadLine();
int.TryParse(strThreeNum, out int ThreeNum);

if (strThreeNum.Length == 3)
{
    int[] digitArray = new int[3]; // create new array witht Size == 3

    for (int i = 2; i >= 0; i--)
    {
        digitArray[i] = ThreeNum % 10; // get last digital in number
        ThreeNum /= 10; // delet last digital in number
    }

    Console.WriteLine(string.Join(" ", digitArray)); // displey our array

    int firstNum = digitArray[0];
    int lastNum = digitArray[2];

    int result = firstNum + lastNum;

    Console.WriteLine($"Sum first and last digital in three-digital number - {strThreeNum} it is {result}");
}

else
{
    Console.WriteLine("You entered a non-three-digit number, restart the program");
}