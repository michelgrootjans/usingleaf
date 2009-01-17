using System;

namespace Utilities.Presentation
{
    public interface IPresenter<T> : IDisposable
        where T : IView
    {
        T View { get; set; }
    }
}