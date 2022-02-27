//Определить сколько чисел больше 0 введено с клавиатуры

int [] arr = new int[10];

void FullArr(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        string? input = Console.ReadLine();
        int.TryParse(input, out int number);
        arr[i] = number;
    }
}

void ArrPrint(int[] arr)
{

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

int GreaterZero(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        count++;
    }
    return count;
}


FullArr(arr);
ArrPrint(arr);
int count = GreaterZero(arr);
Console.Write($"Чисел больше нуля: {count}");