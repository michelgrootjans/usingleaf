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
                          f.ForRequestedType<IPersonService>()
                           .TheDefaultIsConcreteType<PersonService>();
                          f.ForRequestedType<IPresenter<IListPersonView>>()
                              .TheDefaultIsConcreteType<ListPersonPresenter>();
                      }
                );
        }
    }
}