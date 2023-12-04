//the program takes a three-digit number as input and raises 
//the second digit of this number to a power equal to the third number
//254 -> 5^4 = 625

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

    int secondNum = digitArray[1];
    int lastNum = digitArray[2];

    //int result = secondNum ^ lastNum;//почемуто не возводит в степень
    double result = Math.Pow(secondNum, lastNum); // возводим secondNum  в степень  lastNum
    Console.WriteLine(result);
    Console.WriteLine($"second digital `{secondNum}` in three-digital number - {strThreeNum} equal to the third number `{lastNum}` it is --- {result}");
}

else
{
    Console.WriteLine("You entered a non-three-digit number, restart the program");
}

//семинар 2 01:03:00