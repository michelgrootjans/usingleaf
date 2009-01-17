using System.Collections.Generic;
using NUnit.Framework;
using TestUtilities;
using TestUtilities.Extension;
using Timesheet.BL;
using Timesheet.Domain.Presentation;
using Timesheet.Domain.Services;

namespace Timesheet.Domain.Test.Services
{
    [TestFixture]
    public class when_PersonService_is_told_to_get_all_persons : ArrangeActAssert<IPersonService>
    {
        private IEnumerable<Person> persons;

        public override IPersonService CreateSUT()
        {
            return new PersonService();
        }

        public override void Act()
        {
            persons = sut.GetAllPersons();
        }

        [Test]
        public void should_get_all_persons_from_the_generated_code()
        {
            //untestable
        }

        [Test]
        public void should_return_a_personcollection()
        {
            persons.ShouldNotBeNull();
        }
    }

}