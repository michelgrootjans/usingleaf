using System;

namespace Utilities.Containers
{
    public class UnsatisfiedDependencyException<T> : Exception
    {
        public UnsatisfiedDependencyException() : base(string.Format("Couldn't find an implementaion of '{0}'", typeof(T)))
        {
        }
    }
}