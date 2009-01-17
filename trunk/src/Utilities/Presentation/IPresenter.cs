namespace Utilities.Presentation
{
    public interface IPresenter<T> where T : IView
    {
        T View { get; set; }
    }
}