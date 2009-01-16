//using Timesheet.Domain.Test.Presentation;
//using Utilities.Containers;

//namespace Timesheet.Domain
//{
//    public class PresenterFactory
//    {
//        public static IPresenter<View> GetPresenterFor<View>(View view)
//            where View : IView
//        {
//            return new ListPersonPresenter(view as IListPersonView, Container.GetImplementationOf<IPersonService>());
//        }
//    }
//}