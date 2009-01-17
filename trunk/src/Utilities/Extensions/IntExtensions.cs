namespace Utilities.Extensions
{
    public static class IntExtensions
    {
        public static int ToInt(this string subject)
        {
            int value;
            int.TryParse(subject, out value);
            return value;
        }
    }
}