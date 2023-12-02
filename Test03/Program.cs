//Задача 3:Напишите программу, которая перевернёт одномерный   массив   
//(первый   элемент   станет последним,  второй  –  предпоследним  и  т.д.)

Console.Clear();

void InputArray(int [] arr) // метод заполнен массива
{
    for (int i = 0; i < arr.Length; i++)
    arr[i] = new Random().Next(1, 101); 
}

void ReversArray(int [] arrRev1, int [] arrRev2) // передаем 2 одинаковых массива 
                                                // и во 2-й массив записываем 1-й наоборот
{    
    int j = arrRev2.Length-1;
    foreach (int el in arrRev1){
        arrRev2[j] = el; j--;
    }
}

Console.Write("Enter number of array: ");
int n = int.Parse(Console.ReadLine()!);
int [] arr1 = new int [n];
int [] arr2 = new int [n];
InputArray(arr1);
InputArray(arr2);
Console.WriteLine($"First Array: [{string.Join(", ", arr1)}]");
ReversArray(arr1, arr2);
Console.WriteLine($"Revers Array: [{string.Join(", ", arr2)}]");