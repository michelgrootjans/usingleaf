using System;
using System.Windows.Forms;
using Timesheet.Domain.Presentation;
using Utilities.Presentation;

namespace Timesheet.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationStartup.Run();
            
            var listPersonView = new ListPersonView();
            GetPresenter.For<IListPersonView>(listPersonView);

            Application.Run(listPersonView);
        }
    }
}