Console.Write("Введите значение: ");
int number = int.Parse(Console.ReadLine());
int two_number = number / 10 % 10;
Console.WriteLine($"Вторая цифра числа {number} - {two_number}");