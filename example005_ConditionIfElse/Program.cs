Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "юлиана")
{
    Console.WriteLine("Ура, это же моя любимая жена!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
