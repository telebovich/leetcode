namespace RemoveDuplicates
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int pointerFrom = 1, pointerTo = 1;

            while (pointerFrom < nums.Length)
            {
                if (nums[pointerFrom] != nums[pointerFrom - 1])
                {
                    nums[pointerTo] = nums[pointerFrom];

                    pointerTo++;
                }

                pointerFrom++;
            }

            return pointerTo;
        }
    }
}
