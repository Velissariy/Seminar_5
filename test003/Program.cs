// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

//static void Task_33
//{
    int[] arr = {6, 7, 19, 345, 3};
    int number = Prompt("INput number");
    int index = 0;
     if (FoundNumberOfArray(arr, number))
     {
        System.Console.WriteLine("Element founded");
     }
     else
     {
       Console.WriteLine("Element not founded");
     }

//}


static bool FoundNumberOfArray( int [], int userNumber)
{
  for (index = 0; index < arr.Length; index++)
  {
    if (arr[index] == userNumber)
    {
        return true;
    }
  }
  return false;

}

// int [] myArray = {6, 7, 19, 345, 3};
// int res = Array.Find(myArray,i=>i==99);

// if (res==0)
// {
//     System.Console.WriteLine("False");
// }
// else
// {
//     System.Console.WriteLine("True");
// }

// int[] array = {6, 7, 19, 345, -3};
// int trueNumb = 4;

// void NumbMembershipСheck(int[] array, int trueNumb)
// {
//     int i = 0;
//     foreach (var numb in array)
//     {
//         if(numb == trueNumb)
//         {
//             i++;
//         }
//     }

//     if(i > 0)
//         Console.WriteLine("yes");
//     else if(i == 0)
//         Console.WriteLine("no");
// }

// NumbMembershipСheck(array, trueNumb);