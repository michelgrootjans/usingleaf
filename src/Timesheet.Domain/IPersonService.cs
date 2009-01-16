using System.Collections.Generic;
using Timesheet.BL;

namespace Timesheet.Domain
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPersons();
    }
}