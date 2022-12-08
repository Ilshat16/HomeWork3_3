//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве

//Методы
double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanceXY = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double distance = Math.Sqrt(Math.Pow(distanceXY, 2) + Math.Pow((z2 - z1), 2));
    return distance;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Дано
int x1 = EnterData("Введите координату Х первой точки: ");
int y1 = EnterData("Введите координату Y первой точки: ");
int z1 = EnterData("Введите координату Z первой точки: ");
int x2 = EnterData("Введите координату Х второй точки: ");
int y2 = EnterData("Введите координату Y второй точки: ");
int z2 = EnterData("Введите координату Z второй точки: ");
//Выполнение
double distance = FindDistance(x1, y1, z1, x2, y2, z2);
//Вывод
Console.WriteLine($"Расстояние между точками равно: {distance}");
