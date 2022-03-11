namespace MaxConsecutiveOnes
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes = 0, currentConsecutiveOnes = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentConsecutiveOnes += 1;
                }
                else
                {
                    currentConsecutiveOnes = 0;
                }

                if (currentConsecutiveOnes > maxConsecutiveOnes)
                {
                    maxConsecutiveOnes = currentConsecutiveOnes;
                }
            }
            return maxConsecutiveOnes;
        }
    }
}