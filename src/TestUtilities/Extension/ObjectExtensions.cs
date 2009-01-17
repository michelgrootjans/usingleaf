using NUnit.Framework;

namespace TestUtilities.Extension
{
    public static class ObjectExtensions
    {
        public static void ShouldNotBeNull(this object subject)
        {
            Assert.IsNotNull(subject);
        }

        public static void ShouldBeOfType<expected>(this object actual)
        {
            Assert.IsInstanceOfType(typeof(expected), actual);
        }

        public static void ShouldBeSameAs(this object expected, object actual)
        {
            Assert.AreSame(expected, actual);
        }

        public static void ShouldBeEqualTo(this object expected, object actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}