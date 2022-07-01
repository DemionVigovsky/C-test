Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "сара")
{
    Console.WriteLine("Ура, это же моя Сарочка!");
}
else
{
    Console.Write("А, это ты ");
    Console.WriteLine(username);
}