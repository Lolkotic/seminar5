/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int getMaxMinusMin(int [] incomingArray)
{   
    int min = incomingArray[0];
    int max = incomingArray[0];
    int res = 0;

    for (int i = 0; i < incomingArray.Length; i++)
    {
         if (min > incomingArray[i])
         min = incomingArray[i];
    }       
    Console.WriteLine($"Минимальное значение это {min}");
        

    for (int i = 0; i < incomingArray.Length; i++)
    {
         if (max < incomingArray[i])
         max = incomingArray[i];       
    }
    Console.WriteLine($"Максимальное значение это {max}");


    res=max-min;
    return res;
}

int[] currentArray = getRandomArray(15,100,999);
printArray(currentArray);

double MaxMinusMin = getMaxMinusMin(currentArray);

Console.WriteLine($"Разница между максимальным и минимальным элементом  =  {MaxMinusMin}");

