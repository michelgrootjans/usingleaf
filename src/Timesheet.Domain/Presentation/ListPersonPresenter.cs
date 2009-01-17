using System;
using System.Collections.Generic;
using Timesheet.BL;
using Utilities.Presentation;

namespace Timesheet.Domain.Presentation
{
    public class ListPersonPresenter : Presenter<IListPersonView>, IDisposable
    {
        private readonly IPersonService service;

        public ListPersonPresenter(IPersonService service)
        {
            this.service = service;
        }

        protected override void WireUpView()
        {
            View.GiveMeAllPersons += GetAllUsers;
        }

        private void GetAllUsers(object sender, EventArgs e)
        {
            try
            {
                View.Persons = service.GetAllPersons();
            }
            catch(Exception exc)
            {
                View.Persons = new List<Person>();
            }
        }

        public void Dispose()
        {
            View.GiveMeAllPersons -= GetAllUsers;
        }
    }
}