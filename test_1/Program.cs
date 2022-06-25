Console.Clear();
Console.WriteLine("Введите свое имя:");
String Username = Console.ReadLine();

if(Username.ToLower() == "маша")
{
    Console.WriteLine("Ура это же, МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(Username);
}
