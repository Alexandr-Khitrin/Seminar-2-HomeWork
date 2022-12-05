Console.Write("Введите значение: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
        case 1:
        Console.WriteLine("Понедельник - будний день!");
        break;
        case 2:
        Console.WriteLine("Вторник - будний день!");
        break;
        case 3:
        Console.WriteLine("Среда - будний день!");
        break;
        case 4:
        Console.WriteLine("Четверг - будний день!");
        break;
        case 5:
        Console.WriteLine("Пятница - будний день!");
        break;
        case 6:
        Console.WriteLine("Суббота - выходной день!");
        break;
        case 7:
        Console.WriteLine("Воскресенье - выходной день!");
        break;
    default:
        Console.WriteLine("В НЕДЕЛЕ ТОЛЬКО 7 ДНЕЙ!!!");
        break;   
}
