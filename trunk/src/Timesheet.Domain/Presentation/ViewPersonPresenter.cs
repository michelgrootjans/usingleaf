using System;
using Utilities.Presentation;

namespace Timesheet.Domain.Presentation
{
    public class ViewPersonPresenter : Presenter<IViewPersonView>
    {
        private readonly IPersonService service;

        public ViewPersonPresenter(IPersonService service)
        {
            this.service = service;
        }

        protected override void WireUpView()
        {
            View.SavePerson += SavePerson;
        }

        private void SavePerson(object sender, EventArgs e)
        {
            service.Save(View.Person);
        }

        public override void Dispose()
        {
            View.SavePerson -= SavePerson;
        }
    }
}