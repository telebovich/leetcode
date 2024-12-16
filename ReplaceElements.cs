namespace ReplaceElements
{
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            if (arr.Length == 0)
                return [];

            if (arr.Length == 1)
                return [-1];
            
            int index = arr.Length - 1;
            int max = arr[index];
            arr[index] = -1;
            var temp = -1;
            index--;

            while (index >= 0)
            {
                if (arr[index] > -1 && max < arr[index + 1])
                    max = arr[index + 1];
                if (arr[index] > max)
                    temp = arr[index];
                arr[index] = max;
                max = temp;
                index--;
            }

            return arr;
        }
    }
}
