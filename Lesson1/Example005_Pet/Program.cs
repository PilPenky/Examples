Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "невена")
{
    Console.WriteLine("Привет Любимая :)");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}