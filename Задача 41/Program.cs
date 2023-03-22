//Задача 1: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь

int Counting()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("введите число: ");
        word = Console.ReadLine()!;

        if (word == "") return count;
        else if (int.Parse(word) > 0) count ++;
        
        


    }
}

int count = Counting();
Console.WriteLine($"больше нуля: {count}");