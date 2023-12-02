// Задача 2:Задайте массив заполненный случайными трёхзначными   числами.   
//Напишите   программу, которая  покажет  количество  чётных  чисел  в массиве

Console.Clear();
void InputArray(int[] arr)  
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(100,1000);  
}

int IsCheck(int[] Arr)
{
    int count = 0;
    Console.Write("Even: ");
    foreach (int el in Arr){
        if (el % 2 == 0){
        count++;
        Console.Write($"{el}, ");
        }
    }
    return count;
}

Console.Write("Enter number of array elem: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"Array: [{string.Join(",", array)}]");
Console.WriteLine($"Number of Even: {IsCheck(array)}");