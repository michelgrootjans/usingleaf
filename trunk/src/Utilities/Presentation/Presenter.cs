using System;
using Utilities.Extensions;

namespace Utilities.Presentation
{
    public abstract class Presenter<T> : IPresenter<T> 
        where T : IView
    {
        private T view;

        public T View
        {
            get { return view; }
            set
            {
                if (view.IsNotNull())
                    throw new InvalidOperationException(
                        string.Format("The view for this instance of '{0}' has already been set.", GetType()));
                view = value;
                WireUpView();
            }
        }

        protected abstract void WireUpView();
        public abstract void Dispose();
    }
}