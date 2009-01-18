using System.Collections.Generic;
using Leaf;
using Leaf.BL;
using Timesheet.BL;
using Timesheet.Domain.Presentation;

namespace Timesheet.Domain.Services
{
    public class PersonService : IPersonService
    {
        public IEnumerable<Person> GetAllPersons()
        {
            var collection = new PersonCollection(CloudType.Separate);
            collection.Load();
            return collection;
        }

        public void Save(Person person)
        {
            //Is er geen betere manier om een entity te saven?
            var collection = new PersonCollection(CloudType.Separate);
            collection.Load(person.GetPrimaryKey());
            collection.Duplicate(person);
            collection.Save();
        }
    }
}