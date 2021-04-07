using Core.Helpers;

namespace Core.Services
{
    public static class BoundryService
    {
        public static int LeftSideInRange(int leftBoundry, int rightBoundry, int start, int[] items)
        {
            var count = 0;
            if (start < leftBoundry)
            {
                foreach (int item in items)
                {
                    if ((start + item).Between(leftBoundry, rightBoundry)) count++;
                }
            }
            return count;
        }

        public static int RightSideInRange(int leftBoundry, int rightBoundry, int start, int[] items)
        {
            var count = 0;
            if (start > rightBoundry)
            {
                foreach (int item in items)
                {
                    if ((start + item).Between(leftBoundry, rightBoundry)) count++;
                }
            }
            return count;
        }
    }
}
