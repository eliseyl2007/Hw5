// int[] CreatArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine("]");
// }

// // int EvenNum(int[] arr)
// // {
// //     int count = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     if(arr[i] % 2 == 0)
// //     count++;
// // }

// int [] array = CreatArrayRndInt(4, 100, 1000);
// PrintArray(array);

// int[] numbers = new int[4, 100, 1000];
// int count = 0;
// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// {
//     count++;
// }


// Console.WriteLine($"Количество четных числе = {count}");
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}