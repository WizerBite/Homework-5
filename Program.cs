/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void f_arr(int[] arr, int min, int max) // запись массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
}

void write_arr(int[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void task1()
{
    Console.Write("Введите размерность массива: ");

    int SIZE = int.Parse(Console.ReadLine());
    int[] arr = new int[SIZE];
    int count = 0;

    f_arr(arr, 100, 1001);
    write_arr(arr);

    for (int i = 0; i < SIZE; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }

    Console.WriteLine($"Колличество четных чисел в массиве: {count}");
}

void task2()
{
    Console.Write("Введите размерность массива: ");

    int SIZE = int.Parse(Console.ReadLine());
    int[] arr = new int[SIZE];
    int sum = 0;

    f_arr(arr, 0, 200);
    write_arr(arr);

    for (int i = 0; i < SIZE; i+=2)
    {
        sum += arr[i];
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях массива: {sum}");
}

void task3()
{
    Console.Write("Введите размерность массива: ");

    int SIZE = int.Parse(Console.ReadLine());
    double[] arr = new double[SIZE];

    for (int i = 0; i < arr.Length; i++)
    {
        int a = new Random().Next(0, 100);
        int b = new Random().Next(0, 100);
        arr[i] = a + b * 0.01;
        Console.Write($"{Math.Round(arr[i],2)}\t");
    }
    Console.WriteLine($"\nРазница между первым и последним элементом массива: {Math.Abs(arr[0] - arr[SIZE - 1])}");
}



while (true)
{ 
    Console.Write("Введите номер задачи: ");
    int num = int.Parse(Console.ReadLine());
    switch(num)
    {
        case 1:
            {
                task1();
                break;
            }
        case 2:
            {
                task2();
                break;
            }
        case 3:
            {
                task3();
                break;
            }
    }    
}
