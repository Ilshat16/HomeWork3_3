//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом

//Методы
void IsPalindrom(int number)
{
    string num = "" + number;
    int length = num.Length;
    string result = $"Число {number} палиндром";
    for (int i = 0; i < length / 2; i++)
    {
        if (num[i] != num[length - 1 - i]) 
        {
            result = $"Число {number} не палиндром";
            break;
        }
    }
    Console.WriteLine(result);
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
IsPalindrom(number);