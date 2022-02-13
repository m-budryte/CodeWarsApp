using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return new List<int>();
        }
        
        var numbersList = numbers;

        numbers.RemoveAt(numbers.IndexOf(numbers.Min()));
        
        return numbersList;
    }
}