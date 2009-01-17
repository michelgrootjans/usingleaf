using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timesheet.BL;
using Timesheet.Domain.Presentation;
using Utilities.Presentation;

namespace Timesheet.UI
{
    public partial class ListPersonView : Form, IListPersonView
    {
        public event EventHandler GiveMeAllPersons;

        public ListPersonView()
        {
            InitializeComponent();
            GetPresenter.For<IListPersonView>(this);
        }

        public IEnumerable<Person> Persons
        {
            set { personList.DataSource = value; }
        }

        private void btnGetAllPeople_Click(object sender, EventArgs e)
        {
            if (GiveMeAllPersons != null)
            {
                GiveMeAllPersons(this, EventArgs.Empty);
            }
        }
    }
}