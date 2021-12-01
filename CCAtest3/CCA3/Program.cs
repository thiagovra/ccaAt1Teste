using System;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        int lengthOfArray = sortedArray.Length;
        //Array sem elementos
        if (lengthOfArray == 0) {
            return 0;
        }
        
        //Menor valor maior que o minimo permitido
        if (sortedArray[0] >= lessThan) { 
            return 0; 
        }

        
        if (sortedArray[lengthOfArray - 1] < lessThan)
        {
            return lengthOfArray;
        }

        int index = Array.BinarySearch(sortedArray, lessThan);

        if (index < 0){
            return ~index;
        }

        return index;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}