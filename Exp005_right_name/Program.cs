// Начало
// ● Ввести имя пользователя
// ● ЕСЛИ имя пользователя совпадает с “Маша” то…
// поприветствовать по особенному
// ● ИНАЧЕ поприветствовать по обычному
// ● Конец
// Всё ли нормально или нет?

Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура!!! Это же МАША!!! ");
}
else
{
    Console.Write("Привет");
    Console.WriteLine(username);
    
}
