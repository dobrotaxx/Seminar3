/*
Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int QuarterOfCoordinate(int quarter) //метод берет значение и проверяет его соответствие какой-либо четверти
{
    if (quarter == 1)
    {
        Console.WriteLine("Диапазон возможных координат точек в этой четверти: x > 0, y > 0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine("Диапазон возможных координат точек в этой четверти: x < 0, y > 0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("Диапазон возможных координат точек в этой четверти: x < 0, y < 0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine("Диапазон возможных координат точек в этой четверти: x > 0, y < 0");
    }
    return quarter;
}
int getQuarterFromUser(string userInformation)//метод обрабатывает введеные пользователем данные
{
    int result = 0;
    while (result <= 0 || result >= 5)//цикл работает пока result меньше или равен 0 или больше или равен 5
    {
        Console.WriteLine(userInformation);//сообщение пользователю
        string userLine = Console.ReadLine();// строковая переменная берет данные от пользователя
        int.TryParse(userLine, out result);// метод переводит строковые данные от пользователя и выдает как int
        if (result <= 0 || result >= 5 && userLine != "0")//если result все еще меньше или равен 0 или больше или равен 5, то
        {
            Console.WriteLine($"Введите существующий номер четверти, вы ввели {userLine}");/* пользователь получит это сообщение и 
            цикл возобновится*/
        }
    }
    return result;
}

int userQuarter = 0;
userQuarter = getQuarterFromUser("Введите номер четверти: ");
int coordinatesInQuarter = QuarterOfCoordinate(userQuarter);
