/*
 Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
 и находит расстояние между ними в 2D пространстве. 
 A (3,6); B (2,1) -> 5,09 
 A (7,-5); B (1,-1) -> 7,21
*/

double rangeBetweenTwoPoints(double coordinateAx, double coordinateAy, double coordinateBx, double coordinateBy)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(coordinateBx - coordinateAx, 2) + Math.Pow(coordinateBy - coordinateAy, 2));
    //Math.Sqrt(); - находит квадратный корень
    //Math.Pow(<что возводим>,<в какую степень>); - возводит число в степень
    return result;
}
double getCoordinateFromUser(string userInformation)
{
    double result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Ошибка ввода! Ожидается числовое значение, вы ввели: [{userLine}].");
        }
    }
    return result;
}
double pointAx = 0;
double pointAy = 0;
double pointBx = 0;
double pointBy = 0;
Console.WriteLine("Введите координаты для двух точек. ");
pointAx = getCoordinateFromUser("Введите координату точки A для X: ");
pointAy = getCoordinateFromUser("Введите координату точки A для Y: ");
pointBx = getCoordinateFromUser("Введите координату точки B для X: ");
pointBy = getCoordinateFromUser("Введите координату точки B для Y: ");
double findRange = rangeBetweenTwoPoints(pointAx, pointAy, pointBx, pointBy);
Console.WriteLine(findRange);
