Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "sasha")
{
    Console.WriteLine("Господи! Какое счастье! Это же Саша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}