//a program that takes as input
//three-digit number and removes the second digit of it
//numbers.
//456 -> 46

int num = 456;
int last = num % 10;
int first = num / 100;
//Console.WriteLine(first);
//Console.WriteLine(last);
int result = first * 10 + last;
Console.WriteLine(result);

