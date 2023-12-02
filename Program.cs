using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> arrList = arr.ToList();

    for (int i = 0; i < arr.Length; i++)
    {
        //Check if it's a zero AND if there's any numbers left in the list.
        if (arr[i] == 0 && arrList.Any(x => x > 0))
        {
            arrList.Remove(arr[i]);
            arrList.Add(0);
        }
    }

    return arrList.ToArray();
  }
}
