// Задача 29.
// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

static void FillArray(int[] arrayToFill)
{
    Random rand = new Random();
    for (int i = 0; i < arrayToFill.Length; i++) 
    { 
        arrayToFill[i] = rand.Next(0, 100); 
    }
}

static void PrintArray(int[] arrayForPrint) 
{ 
    for (int i = 0; i < arrayForPrint.Length; i++) 
    { 
        System.Console.Write(arrayForPrint[i] + " "); 
    } 
} 

// --------------------------------------------------------- 

int[] array = new int[8]; 
FillArray(array); 
PrintArray(array);