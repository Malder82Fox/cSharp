// the code asking username and displaying Hello "UserName"
Console.Write("What your name: ");
// WritLine - выводит запрос на следующей линии, после описания запроса
// если использовать просто Write - запрос и описание запроса будут в одну линию
string username = Console.ReadLine();
Console.WriteLine("Hello, ");
Console.WriteLine(username);
