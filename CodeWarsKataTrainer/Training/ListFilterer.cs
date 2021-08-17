using System;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems){
        if (listOfItems is null)
        {
            throw new ArgumentNullException(nameof(listOfItems));
        }

        if (!listOfItems.Any())
        {
            throw new ArgumentException(nameof(listOfItems), "Input list is empty");
        }

        var result = listOfItems.Where(x => x is int).Select(x => {return (int)x;}).ToList<int>();
        result.ForEach(x => Console.WriteLine(x));

        return result;
    }
}