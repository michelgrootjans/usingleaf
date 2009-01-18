using System;
using NUnit.Framework;
using Rhino.Mocks;
using TestUtilities;
using Timesheet.BL;
using Timesheet.Domain.Presentation;
using Utilities.Presentation;

namespace Timesheet.Domain.Test.Presentation
{
    [TestFixture]
    public class when_ViewPersonPresenter_is_told_to_save_a_person : ArrangeActAssert<IPresenter<IViewPersonView>>
    {
        private IViewPersonView view;
        private IPersonService service;
        private Person person;

        public override void Arrange()
        {
            person = new Person(null);
            view = Dependency<IViewPersonView>();
            service = Dependency<IPersonService>();

            view.Person = person;
        }

        public override IPresenter<IViewPersonView> CreateSUT()
        {
            return new ViewPersonPresenter(service){View = view};
        }

        public override void Act()
        {
            view.Raise(v => v.SavePerson += null, view, EventArgs.Empty);
        }

        [Test]
        public void should_tell_the_service_to_save_the_person()
        {
            service.AssertWasCalled(s => s.Save(person));
        }
    }
}