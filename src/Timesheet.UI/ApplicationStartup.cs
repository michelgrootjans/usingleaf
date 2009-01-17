using StructureMap;
using Timesheet.Domain.Presentation;
using Timesheet.Domain.Services;
using Utilities.Presentation;
using Utilities.Structuremap;
using Container=Utilities.Containers.Container;

namespace Timesheet.UI
{
    public static class ApplicationStartup
    {
        public static void Run()
        {
            Container.Initialize(new StructuremapContainer());

            ObjectFactory.Initialize
                ( f =>
                      {
                          InitializePerson(f);
                          InitializeSomethingElse(f);
                      }
                );
        }

        private static void InitializePerson(IInitializationExpression f)
        {
            f.ForRequestedType<IListPersonView>()
                .TheDefaultIsConcreteType<ListPersonView>();
            f.ForRequestedType<IPresenter<IListPersonView>>()
                .TheDefaultIsConcreteType<ListPersonPresenter>();

            f.ForRequestedType<IViewPersonView>()
                .TheDefaultIsConcreteType<PersonView>();
            f.ForRequestedType<IPresenter<IViewPersonView>>()
                .TheDefaultIsConcreteType<ViewPersonPresenter>();

            f.ForRequestedType<IPersonService>()
                .TheDefaultIsConcreteType<PersonService>();
        }

        private static void InitializeSomethingElse(IInitializationExpression f)
        {
            
        }
    }
}