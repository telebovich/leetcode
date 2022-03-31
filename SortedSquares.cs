namespace SortedSquares
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
                result[i] = nums[i] * nums[i];
            
            result = Sort(result);
            
            return result;
        }

        private int[] Sort(int[] nums)
        {
            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] > nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i - 1];
                        nums[i - 1] = temp;
                        
                        swapped = true;
                    }
                }
            }
            while (swapped);
            
            return nums;
        }

    }
}