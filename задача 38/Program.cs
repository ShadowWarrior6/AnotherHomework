﻿ //Задайте массив вещественных чисел. 
 //Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("введите размер массива");
int size =  Convert.ToInt32(Console.ReadLine()!);
double [] numbers =new double[size ];
FillArrayRandomNumbers(numbers);
Console.WriteLine("вот массив");
PrintArray(numbers);
double min =Int32.MaxValue;
double max = Int32.MinValue;

for (int i=0; i<numbers.Length;i++)
{
    if (numbers[i]>max)
    {
        max=numbers[i];
    }

    if(numbers[i]<min)
    {
        min=numbers[i];
    }


}
Console.WriteLine($"вот максимальное значение {max} вот минмум {min}");
Console.WriteLine($"разница между максимальным и минимальным {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i=0; i<numbers.Length;i++)
    {
        numbers[i]= Convert.ToDouble(new Random().Next(100,1000));
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[");
    for (int i=0; i<numbers.Length;i++)
    {
        Console.Write(numbers[i]+" ");
    }

Console.Write("]");
Console.WriteLine();

}

