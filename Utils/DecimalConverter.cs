namespace rina.Utils
{
    public static class DecimalConverter
    {
        public static decimal ConvertForDatabase(decimal data)
        {
            return data * (decimal)Math.Pow(10, 13);
        }

        public static decimal ConvertFromDatabase(decimal data)
        {
            return data / (decimal)Math.Pow(10, 13);
        }
    }
}
