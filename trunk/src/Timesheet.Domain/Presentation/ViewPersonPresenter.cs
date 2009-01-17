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
            View.GetPerson += GetPerson;
        }

        private void GetPerson(object sender, EventArgs e)
        {
        }

        public override void Dispose()
        {
            View.GetPerson -= GetPerson;
        }
    }
}