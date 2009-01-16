using System;

namespace Timesheet.Domain
{
    public class ListPersonPresenter : IPresenter<IListPersonView>, IDisposable
    {
        private readonly IListPersonView view;
        private readonly IPersonService service;

        public ListPersonPresenter(IListPersonView view, IPersonService service)
        {
            this.view = view;
            this.service = service;

            view.GiveMeAllPersons += GetAllUsers;
        }

        private void GetAllUsers(object sender, EventArgs e)
        {
            view.SetPersons(service.GetAllPersons());
        }

        public void Dispose()
        {
            view.GiveMeAllPersons -= GetAllUsers;
        }
    }
}