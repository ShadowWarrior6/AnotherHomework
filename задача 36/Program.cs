//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, 
//стоящих на нечётных позициях.

Console.WriteLine("дайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine()!);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("вот массив");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i<numbers.Length;i+=2)
    sum = sum+numbers[i];

    Console.WriteLine($"всего {numbers.Length} чисел,  вот сумма нечётных = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i=0; i<numbers.Length;i++)
    {
        numbers[i]=new Random().Next(1,10);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("[");
    for (int i = 0; i<numbers.Length;i++)
        {
            Console.Write(numbers[i]+" ");


        }
    Console.Write("]");
    Console.WriteLine();
}

