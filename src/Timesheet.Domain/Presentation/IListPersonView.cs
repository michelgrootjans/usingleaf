using System;
using System.Collections.Generic;
using Timesheet.BL;
using Utilities.Presentation;

namespace Timesheet.Domain.Presentation
{
    public interface IListPersonView : IView
    {
        event EventHandler GiveMeAllPersons;
        event EventHandler ShowSelectedPerson;

        IEnumerable<Person> Persons { set; }
        Person GetSelectedPerson();
    }
}