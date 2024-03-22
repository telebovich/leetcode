namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int temp = -1,
                index = 0,
                elementToBeReplaced = nums.Length - 1,
                amountOfReplaces = 0;
            
            while (index <= elementToBeReplaced)
            {
                while (nums[elementToBeReplaced] == val)
                {
                    nums[elementToBeReplaced] = -1;
                    amountOfReplaces++;

                    if (elementToBeReplaced > 0)
                        elementToBeReplaced--;
                }

                if (nums[index] == val)
                {
                    nums[index] = -1;
                    amountOfReplaces++;

                    temp = nums[index];
                    nums[index] = nums[elementToBeReplaced];
                    nums[elementToBeReplaced] = temp;

                    if (elementToBeReplaced > 0)
                        elementToBeReplaced--;
                }

                index++;
            }

            var elementsLeft = nums.Length - amountOfReplaces;
            
            return elementsLeft;
        }
    }
}