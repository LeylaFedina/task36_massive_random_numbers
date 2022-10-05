/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

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
void printArray(int[] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray[i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int getSumOfEvenCountNumbers(int[] incommingArray)
{
    int result = 0;
    for (int i = 1; i < incommingArray.Length; i = i + 2)
    {
       
       result = result + incommingArray[i];
    }
    return result;
}

int[] currentArray = getRandomArray(15, -99, 99);
printArray(currentArray);
int SumOfEvenCountNumbers = getSumOfEvenCountNumbers(currentArray);
Console.WriteLine($"сумма чисел на четных позициях равна {SumOfEvenCountNumbers}");
