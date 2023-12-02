public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
      int[] newArray = new int[arr.Length];

      int newIndex = 0;
      
      //No need for Linq or Lists<>, just loop through the array
      //and assign the same values at new indices.
      for (int i = 0; i < arr.Length; i++)
      {
          if (arr[i] != 0)
          {
              newArray[newIndex] = arr[i];
              newIndex++;
          }          
      }
      return newArray;  
    }
}
