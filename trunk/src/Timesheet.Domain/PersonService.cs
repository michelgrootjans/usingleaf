using System.Collections.Generic;
using Leaf.BL;
using Timesheet.BL;

namespace Timesheet.Domain
{
    public class PersonService : IPersonService
    {
        public IEnumerable<Person> GetAllPersons()
        {
            var collection = new PersonCollection(CloudType.Separate);
            collection.Load();
            return collection;
        }
    }
}