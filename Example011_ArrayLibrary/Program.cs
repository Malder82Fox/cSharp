﻿// create new array and full and print this array use method
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -2; // if you see on display -2 it is fount your element

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }        
        index++;
    }
    return position;
}

int[] array = new int[10]; //create new array with 10 elements

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);  //return index# on element digital 4
Console.WriteLine(pos);
