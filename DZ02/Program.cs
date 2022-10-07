/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double rangeBetweenTwoPoints(double coordinateAx, double coordinateAy, double coordinateAz, double coordinateBx, double coordinateBy, double coordinateBz)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(coordinateBx - coordinateAx, 2) + Math.Pow(coordinateBy - coordinateAy, 2) + Math.Pow(coordinateBz - coordinateAz, 2));
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
double pointAz = 0;
double pointBx = 0;
double pointBy = 0;
double pointBz = 0;
Console.WriteLine("Введите координаты для двух точек. ");
pointAx = getCoordinateFromUser("Введите координату точки A для X: ");
pointAy = getCoordinateFromUser("Введите координату точки A для Y: ");
pointAz = getCoordinateFromUser("Введите координату точки A для Z: ");
pointBx = getCoordinateFromUser("Введите координату точки B для X: ");
pointBy = getCoordinateFromUser("Введите координату точки B для Y: ");
pointBz = getCoordinateFromUser("Введите координату точки B для Z: ");
double findRange = rangeBetweenTwoPoints(pointAx, pointAy, pointAz, pointBx, pointBy, pointBz);
Console.WriteLine(findRange);
