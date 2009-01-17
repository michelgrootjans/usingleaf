using Utilities.Containers;

namespace Utilities.Presentation
{
    public class GetPresenter
    {
        public static IPresenter<View> For<View>(View view) where View : IView
        {
            var presenter = Container.GetImplementationOf<IPresenter<View>>();
            presenter.View = view;
            return presenter;
        }
    }
}