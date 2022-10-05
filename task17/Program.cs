/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int getQuarterFromCoordinate(int coordinateX, int coordinateY) // метод находит четверть
{
    int result = 0;
    if (coordinateX > 0 && coordinateY > 0)
    {
        result = 1;
    }
    else if (coordinateX < 0 && coordinateY > 0)
    {
        result = 2;
    }
    else if (coordinateX < 0 && coordinateY < 0)
    {
        result = 3;
    }
    else if (coordinateX > 0 && coordinateY < 0)
    {
        result = 4;
    }
    return result;
}
int getCoordinateFromUser(string userInformation) /* метод обрабатывает данные от пользователя и просит внести изменения если они не типа int
*/
{
    int result = 0; // изначальная переменная равна 0
    while (result == 0) // пока переменная равна нулю работает цикл
    {
        Console.Write(userInformation); // Пишем пользователю сообщение (в данном случае "Х: " и "Y: ")
        string userLine = Console.ReadLine();// В переменную кладем данные, которые ввел пользователь
        int.TryParse(userLine, out result);/* int.TryParse метод который на вход получает строковые данные (string), а на выход пытается выдать
        данные типа int (в переменной result), если она не может это сделать то в переменную записывается 0*/
        if (result == 0 && userLine != "0")//если result все еще равен 0 и userLine не равен 0
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");// то выводим пользователю сообщение
        }
        else
        {
            break; // иначе прерываем цикл
        }
    }
    return result;//возвращаем result
}
int userCoordinateX = 0; //исходные значения переменной
int userCoordinateY = 0; //исходные значения переменной
Console.WriteLine("Введите координаты: "); // сообщение пользователю
userCoordinateX = getCoordinateFromUser("X: ");//кладем в переменную метод с сообщением "X: ", который обрабатывает данные пользователя
userCoordinateY = getCoordinateFromUser("Y: ");//кладем в переменную метод с сообщением "Y: ", который обрабатывает данные пользователя
int quarter = getQuarterFromCoordinate(userCoordinateX, userCoordinateY);/*кладем в переменную метод определения четверти с аргументами в,
которых хранятся обработанные данные, которые ввел пользователь*/
if (quarter > 0) // если в методе нет данных равных 0
{
    Console.WriteLine($"Точка с координатами [{userCoordinateX}:{userCoordinateY}] находится в {quarter} четверти");/*выводим пользователю
    сообщение с четвертью и его точками*/
}
else
{
    Console.WriteLine($"Одна из координат является нулевой, нельзя орпеделить в какой четверти точка [{userCoordinateX}:{userCoordinateY}]");
    //если в данных пользователя есть 0, то вывводим другое сообщение 
}
