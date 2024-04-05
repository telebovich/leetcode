namespace ValidMountainArray
{
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            int mountainDirection = 0;
            int peak = 0;

            if (arr.Length < 3)
            {
                return false;
            }

            if (arr[1] > arr[0])
            {
                mountainDirection = 1;
                peak = arr[1];
            }
            else
            {
                return false;
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1] && arr[i] < peak)
                {
                    mountainDirection = -1;
                }

                if (arr[i] >= arr[i - 1] && mountainDirection < 0)
                {
                    return false;
                }

                if (arr[i] <= arr[i - 1] && mountainDirection > 0)
                {
                    return false;
                }

                if (arr[i] > arr[i - 1] && arr[i] > peak)
                {
                    peak = arr[i];
                }
            }

            if (mountainDirection >= 0)
            {
                return false;
            }

            return true;
        }
    }
}
