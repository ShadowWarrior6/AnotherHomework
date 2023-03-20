int size=Convert.ToInt32(Console.ReadLine()!);
int[]numbers=new int [size];
FillArrayRanfomNums(numbers);
PrintArray(numbers);
int count =0;

for (int i =0; i<numbers.Length; i++)
 if (numbers[i]%2==0)
 count++;

 Console.WriteLine($"всего {numbers.Length} чисел {count} вот чётные ");
 
 void FillArrayRanfomNums(int[]numbers)
 {
    for (int i=0; i<numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);

    }
 }

 void PrintArray(int[] numbers)
 {
    Console.Write(" . ");
    for (int i =0;i<numbers.Length;i++)
    {
        Console.WriteLine(numbers[i]+" ");
    }
    Console.Write(" . ");
    Console.WriteLine();
 }
