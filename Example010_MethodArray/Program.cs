// 
int[] array = {13, 24, 73, 64, 4, 46, 37, 28, 19};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // ставим на случай если в массиве будет несколько элементов со значением find найдет первый и прекратит цикл.
    }
    index++;
}
