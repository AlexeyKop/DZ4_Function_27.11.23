//Задача 1: Напишите программу, которая бесконечно запрашивает  целые  числа  с  консоли.  
//Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма    цифр    которого    четная

void SumEven (int m)  // проверка суммы цифр числа на четность
{
    int sum = 0;
    while (m > 0)
    {
        sum += m % 10;
        m = m / 10;
    }
    if (sum % 2 == 0)
           Console.Write("Programm finished. Summ of your digit even");
       else
            Console.Write("Enter next number");
}

Console.Clear();
Console.WriteLine("Enter number: ");
string s = Console.ReadLine()!;
if (s != "q"){
        int n = int.Parse(s);
        SumEven (n);
}
       
else{
        Console.Write("Programm finished");
}
//CheckSymbol(s);

        
        
    




