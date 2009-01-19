using System;

namespace Utilities.Extensions
{
    public static class EventHandlerExtensions
    {
        public static void Raise(this EventHandler eventHandler, object sender, EventArgs eventArgs)
        {
            if (eventHandler.IsNotNull())
                eventHandler(sender, eventArgs);
        }

    }
}