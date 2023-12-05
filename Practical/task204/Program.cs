//program that prints third from end
//digit of a given number or reports that there is no third digit
//456 => 6
//7812 => 8
//91 => There is no third digit

Console.Clear();

Console.Write("Enter number - ");
string strNum = Console.ReadLine();
int.TryParse(strNum, out int Num);
int absNum = Math.Abs(Num); // Get the absolute value of a number to handle negative numbers

int count = 0;
while (absNum > 0)
{
    absNum = absNum / 10; // can use "absNum /= 10"
    count++;
}

int[] Array = new int[count]; //create new array with size == Number on our digital
for (int i = count - 1; i >= 0; i--)
    {
        Array[i] = Num % 10; // get last digital in number
        Num /= 10; // delet last digital in number (Num = Num / 10)
    }
if (count < 3)
{
    Console.WriteLine("There is no third digit");
}
else
{
    int Result = Array[count - 3];
    Console.WriteLine($"The third digit from the end of the number `{strNum}` is `{Result}`");
}


