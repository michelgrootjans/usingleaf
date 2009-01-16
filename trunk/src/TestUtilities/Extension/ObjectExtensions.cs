using NUnit.Framework;

namespace TestUtilities.Extension
{
    public static class ObjectExtensions
    {
        public static void ShouldNotBeNull(this object subject)
        {
            Assert.IsNotNull(subject);
        }
    }
}