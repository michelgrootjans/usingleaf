using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestUtilities.Extension
{
    public static class IEnumerableExtensions
    {
        public static void ShouldContain<T>(this IEnumerable<T> subject, T target)
        {
            var list = new List<T>(subject);
            Assert.Contains(target, list);
        }

        public static void ShouldContain<T>(this IEnumerable<T> subject, Predicate<T> predicate)
        {
            var list = new List<T>(subject);
            Assert.IsTrue(list.Exists(predicate));
        }
    }
}