using System.Collections.Generic;
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
    }
}