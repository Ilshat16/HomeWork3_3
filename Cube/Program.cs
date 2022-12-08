//Напишите программу, которая принимает на вход число N
//и выдает таблицу кубов чисел от 1 до N

//Методы
void CalculateCube(int number)
{
    for (int i = 1; i < number; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result}, ");
    }
    Console.WriteLine(Math.Pow(number, 3)); //последнее число выводим отдельно, чтобы в конце списка небыло запятой
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Дано
int number = EnterData("Введите число: ");
//Выполнение
CalculateCube(number);