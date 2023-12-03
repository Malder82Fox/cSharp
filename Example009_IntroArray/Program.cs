// create function in our code 
int Max(int arg1, int arg2, int arg3) // !!! attention !!! There is no need to put a ";" at the end of a line when declaring a function.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// index#      0  1  2  3  4  5  6  7  8
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
//array[0] = 12; // we create new digital for our array on index# "0"

// started our function
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
); 

Console.WriteLine(result);
