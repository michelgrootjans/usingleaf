using System.Collections.Generic;
using Timesheet.BL;

namespace Timesheet.Domain.Presentation
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPersons();
    }
}