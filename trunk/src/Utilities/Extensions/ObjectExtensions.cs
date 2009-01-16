namespace Utilities.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object subject)
        {
            return null == subject;
        }
    }
}