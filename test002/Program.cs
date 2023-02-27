// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


static void Task_32()
{
int [] arr = new int[8];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = random.Next(10,11);
Console.WriteLine($"{arr[i]}\t");
}
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
arr[i] *= -1;
Console.WriteLine($"{arr[i]}\t");
}
}


