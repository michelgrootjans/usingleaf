using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timesheet.BL;
using Timesheet.Domain;

namespace Timesheet.UI
{
    public partial class Form1 : Form, IListPersonView
    {
        public event EventHandler GiveMeAllPersons;

        public Form1()
        {
            InitializeComponent();
            new ListPersonPresenter(this, Utilities.Containers.Container.GetImplementationOf<IPersonService>());
        }

        public void SetPersons(IEnumerable<Person> persons)
        {
        }
    }
}