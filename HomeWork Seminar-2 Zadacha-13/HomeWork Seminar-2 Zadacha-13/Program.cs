Console.Write("Введите значение: ");
int number = int.Parse(Console.ReadLine());

string third_number  = number.ToString();

if(number >=100)
{
    Console.WriteLine(third_number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нету");
}
