using System;
using System.Collections.Generic;
using Timesheet.BL;

namespace Timesheet.Domain
{
    public interface IListPersonView : IView
    {
        event EventHandler GiveMeAllPersons;

        void SetPersons(IEnumerable<Person> persons);
    }
}