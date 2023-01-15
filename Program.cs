// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int [] GetArrayRandom (int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min,max+1);
    }
    return arr;
}

void showArray(int[]array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length -1)
        {
          Console.Write($"{array[i]},");  
        }
        else 
        {
           Console.Write($"{array[i]}]"); 
        }
    }
}
int min = getUserData("Введите минимальное число");
int max = getUserData("Введите максимальное число"); 
int [] array = GetArrayRandom(8, min, max);
showArray(array);
