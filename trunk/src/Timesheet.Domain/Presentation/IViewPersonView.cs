using System;
using Timesheet.BL;
using Utilities.Presentation;

namespace Timesheet.Domain.Presentation
{
    public interface IViewPersonView : IView
    {
        event EventHandler SavePerson;

        void SetPerson(Person person);
        Person Person { get; set; }
    }
}