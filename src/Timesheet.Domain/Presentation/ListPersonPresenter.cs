using System;
using System.Collections.Generic;
using Timesheet.BL;
using Utilities.Containers;
using Utilities.Presentation;

namespace Timesheet.Domain.Presentation
{
    public class ListPersonPresenter : Presenter<IListPersonView>
    {
        private readonly IPersonService service;

        public ListPersonPresenter(IPersonService service)
        {
            this.service = service;
        }

        protected override void WireUpView()
        {
            View.GiveMeAllPersons += GetAllUsers;
            View.ShowSelectedPerson += ShowPerson;
        }

        private void GetAllUsers(object sender, EventArgs e)
        {
            try
            {
                View.Persons = service.GetAllPersons();
            }
            catch
            {
                View.Persons = new List<Person>();
            }
        }

        private void ShowPerson(object sender, EventArgs e)
        {
            var personView = Container.GetImplementationOf<IViewPersonView>();
            personView.SetPerson(View.GetSelectedPerson());
            personView.Show();
        }

        public override void Dispose()
        {
            View.GiveMeAllPersons -= GetAllUsers;
            View.ShowSelectedPerson -= ShowPerson;
        }
    }
}