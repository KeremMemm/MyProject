namespace BankApplicationForUniser.Extensions
{
    public static class StringExtensions
    {
        public static int  ToInt(this string data)
        {
            return Convert.ToInt32(data);
        }

        public static bool IsNull(this string data)
        {
            return string.IsNullOrEmpty(data);
        }
    }
}
