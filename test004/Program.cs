// Задача 35: Задайте одномерный массив из 33 
// случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//static void Task_35()
{{
    int[] arr = new int[123];
    Random random = new Random();
    int count = 0;
    }

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = random.Next(0, 500);
   if (arr[i] > 10 && arr[i] < 100)
   {
    count++;
   }

}

 foreach (var item in arr)
 {
    System.Console.Write($"{item}\t");
 }
 System.Console.Write();
 Console.WriteLine($"Количество элементов в диапазоне ще 10 до 99 - |{count} ");

}