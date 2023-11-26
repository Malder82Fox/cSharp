// this code showing how work if and else
Console.Write("What your name?: ");
string username = Console.ReadLine();

if(username.ToLower() == "alex") // .ToLower() метод, создает новую строку в
// которой все символы преобразованы в нижний регистр, не изменяя оригинальную сроку 
{
    Console.WriteLine("Ooops, it is Alex !");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
