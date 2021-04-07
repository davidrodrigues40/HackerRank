namespace Core.Services
{
    public static class RecordService
    {
        public static (int max, int min) RecordsBroken(int[] input)
        {
            var countMin = 0;
            var countMax = 0;
            var min = input[0];
            var max = input[0];

            foreach (int item in input)
            {
                if (item < min)
                {
                    min = item;
                    countMin++;
                }

                if (item > max)
                {
                    max = item;
                    countMax++;
                }
            }

            return (countMax, countMin);
        }

        public static int MaxRecordBroken(int[] input)
        {
            var count = 0;
            var max = input[0];

            foreach (int item in input)
            {

                if (item > max)
                {
                    max = item;
                    count++;
                }
            }

            return count;
        }

        public static int MinRecordBroken(int[] input)
        {
            var count = 0;
            var min = input[0];

            foreach (int item in input)
            {
                if (item < min)
                {
                    min = item;
                    count++;
                }
            }

            return count;
        }
    }
}
