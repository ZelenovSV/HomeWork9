//Задача 64: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Task64()
{
    Console.WriteLine("Task 64");
    Console.WriteLine(NumbersRec(1,5));
}

//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Task66()
{
    Console.WriteLine("Task 66");
    Console.WriteLine(SumNumbers(1,5));
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

void Task68()
{
    Console.WriteLine("Task 68");
    Console.Write($"Функция Акермана = {FunctionAkkerman(2,3)}");
    Console.WriteLine();
}

Main();

void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("Enter command");
        string command = Console.ReadLine();

        switch (command)
        {
            case "Task 64":
                Task64();
                break;
            case "Task 66":
                Task66();
                break;
            case "Task 68":
                Task68();
                break; 
            case "exit":
                isWork = false;
                break;
        }
    }
}

string NumbersRec(int a, int b)
{
    if (a < b + 1) return $"{a} " + NumbersRec(a+1, b);
    else return String.Empty;    
}

int SumNumbers( int a, int b)
{
    if (a < b + 1) return a + SumNumbers(a+1, b);
    else return 0 ;      
}

int FunctionAkkerman( int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m , n - 1)); 
}
