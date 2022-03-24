namespace FindNumberswithEvenNumberofDigits
{
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            int result = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                int digits = 0;
                int multiplied = 1;

                while (nums[i] >= multiplied)
                {
                    digits += 1;

                    multiplied *= 10;
                }

                if (digits % 2 == 0)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}