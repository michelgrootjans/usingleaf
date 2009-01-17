using System;
using Timesheet.BL;
using Utilities.Presentation;

namespace Timesheet.Domain.Presentation
{
    public interface IViewPersonView : IView
    {
        event EventHandler GetPerson;

        void SetPerson(Person person);
        Person Person { get; }
    }
}