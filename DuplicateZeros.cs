namespace DuplicateZeros
{
    public class Solution
    {
        public int[] DuplicateZeros(int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    counter += 1;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == 0)
                {
                    int temp = arr[i];
                    int veryTemp = 0;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        veryTemp = arr[j];
                        arr[j] = temp;
                        temp = veryTemp;
                    }
                    
                    arr[i] = 0;
                    i++;
                }
            }

            return arr;
        }
    }
}