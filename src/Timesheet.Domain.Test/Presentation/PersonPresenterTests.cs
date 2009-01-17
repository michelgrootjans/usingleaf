using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NUnit.Framework;
using Rhino.Mocks;
using TestUtilities;
using Timesheet.BL;
using Timesheet.Domain.Presentation;
using Utilities.Presentation;

namespace Timesheet.Domain.Test.Presentation
{
    [TestFixture]
    public class when_ListPersonPresenter_is_told_to_get_all_person : ArrangeActAssert<IPresenter<IListPersonView>>
    {
        private IPersonService service;
        private IListPersonView view;
        private IEnumerable<Person> people;

        public override void Arrange()
        {
            service = Dependency<IPersonService>();
            view = Dependency<IListPersonView>();
            people = Dependency<IEnumerable<Person>>();

            service.Stub(s => s.GetAllPersons()).Return(people);
        }

        public override IPresenter<IListPersonView> CreateSUT()
        {
            return new ListPersonPresenter(service) {View = view};
        }

        public override void Act()
        {
            view.Raise(v => v.GiveMeAllPersons += null, view, EventArgs.Empty);
        }

        [Test]
        public void should_get_the_users_from_the_service()
        {
            service.AssertWasCalled(s => s.GetAllPersons());
        }

        [Test]
        public void should_set_the_users_in_the_view()
        {
            view.AssertWasCalled(v => v.Persons = people);
        }
    }

    [TestFixture]
    public class when_ListPersonPresenter_is_told_to_get_all_person_and_service_throws_an_exception :
        ArrangeActAssert<IPresenter<IListPersonView>>
    {
        private IPersonService service;
        private IListPersonView view;
        private IEnumerable<Person> people;

        public override void Arrange()
        {
            service = Dependency<IPersonService>();
            view = Dependency<IListPersonView>();
            people = Dependency<IEnumerable<Person>>();

            service.Stub(s => s.GetAllPersons()).Throw(new Exception());
        }

        public override IPresenter<IListPersonView> CreateSUT()
        {
            return new ListPersonPresenter(service) {View = view};
        }

        public override void Act()
        {
            view.Raise(v => v.GiveMeAllPersons += null, view, EventArgs.Empty);
        }

        [Test]
        public void Should_return_an_empty_list()
        {
            view.AssertWasCalled(v => v.Persons = Arg<IEnumerable<Person>>.Matches(HasNoElements()));
        }

        private Expression<Predicate<IEnumerable<Person>>> HasNoElements()
        {
            return l => l.ToList().Count == 0;
        }
    }
}