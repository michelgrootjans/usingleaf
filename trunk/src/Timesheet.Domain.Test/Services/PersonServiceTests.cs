using System.Collections.Generic;
using System.Linq;
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

    [TestFixture]
    public class when_PersonService_is_told_to_save_a_person : ArrangeActAssert<IPersonService>
    {
        private Person person;
        private string name;

        public override void Arrange()
        {
            name = "new First Name";
            var service = new PersonService();
            person = service.GetAllPersons().ToList()[0];
            person.FirstName = name;
        }

        public override IPersonService CreateSUT()
        {
            return new PersonService();
        }

        public override void Act()
        {
            sut.Save(person);
        }

        [Test]
        public void should_save_the_person_to_the_database()
        {
            sut.GetAllPersons().ShouldContain(p => p.FirstName.Equals(name));
        }
    }

}