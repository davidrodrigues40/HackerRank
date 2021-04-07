namespace Core.Services
{
    public static class RoundingService
    {
        public static int Round(int value, int modValue, int minMod, int minValue)
        {
            var mod = value % modValue;
            if (value < minValue || mod <= minMod)
                return value;

            return value + (modValue - mod);
        }
    }
}
