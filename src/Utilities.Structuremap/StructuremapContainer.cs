using System;
using StructureMap;

namespace Utilities.Structuremap
{
    public class StructuremapContainer : Containers.IContainer
    {
        public void Register<T>(T implementation)
        {
            throw new InvalidOperationException(
                "You can't register objects this way in structuremap. Try registering them directly by using 'ObjectFactory.Initialize(x => ...);'");
        }

        public T GetImplementationOf<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}