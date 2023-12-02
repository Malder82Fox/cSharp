// program that takes as input integer N, and the output shows all integers numbers in the range from -N to N.
// Examples 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4

Console.Clear();

Console.Write("Enter a positive integer - ");
string strFirstNum = Console.ReadLine();
int.TryParse(strFirstNum, out int FirstNum); // convert from type "string" to type "int"
int reversedNum = -FirstNum;

Console.WriteLine($"range of numbers from {FirstNum} to {reversedNum}");

int arraySize = FirstNum - reversedNum + 1; // set the size for the array
int[] resultArray = new int[arraySize]; // create the array itself (empty) with size "arraySize"

for(int i = 0; i != arraySize; i++)
{
    resultArray[i] = reversedNum + i;
}

Console.WriteLine(string.Join(" ", resultArray));
// 'Console.WriteLine($"Your array: {resultArray}");' you can not display array use this code !!!!!
// Displaing array use 'string.Join'
