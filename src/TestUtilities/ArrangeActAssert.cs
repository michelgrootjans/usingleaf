using NUnit.Framework;
using Rhino.Mocks;
using Utilities.Containers;

namespace TestUtilities
{
    [TestFixture]
    public class ArrangeActAssert
    {
        [SetUp]
        public void SetUp()
        {            
            Container.Initialize(new DictionaryContainer());
            Arrange();
            SetupSUT();
            Act();    
        }

        [TearDown]
        public void TearDown()
        {
            Container.Initialize(null);
            OnTearDown();
        }

        public virtual void Arrange() { }
        protected virtual void SetupSUT() { }
        public virtual void Act() { }
        public virtual void OnTearDown() { }

        protected S RegisterDependencyInContainer<S>() where S : class
        {
            S s = MockRepository.GenerateStub<S>();
            Container.Register(s);
            return s;
        }

        protected S Dependency<S>() where S : class
        {
            return MockRepository.GenerateStub<S>();
        }
    }

    public class ArrangeActAssert<T> : ArrangeActAssert
    {
        protected T sut { get; private set; }

        protected override void SetupSUT()
        {
            sut = CreateSUT();
        }

        public virtual T CreateSUT()
        {
            return default(T);
        }
    }
}