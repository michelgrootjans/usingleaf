namespace Utilities.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object subject)
        {
            return null == subject;
        }

        public static bool IsNotNull(this object subject)
        {
            return null != subject;
        }
    }
}