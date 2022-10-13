Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Привет, сладкая!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}