using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timesheet.BL;
using Timesheet.Domain.Presentation;

namespace Timesheet.UI
{
    public partial class ListPersonView : Form, IListPersonView
    {
        public event EventHandler GiveMeAllPersons;
        public event EventHandler ShowSelectedPerson;

        public ListPersonView()
        {
            InitializeComponent();
        }

        public IEnumerable<Person> Persons
        {
            set { personList.DataSource = value; }
        }

        public Person GetSelectedPerson()
        {
            //TODO: there must be a better way to get the selected row
            return personList.SelectedRows[0].DataBoundItem as Person;
        }

        private void btnGetAllPeople_Click(object sender, EventArgs e)
        {
            if (GiveMeAllPersons != null)
                GiveMeAllPersons(this, EventArgs.Empty);
        }

        private void personList_DoubleClick(object sender, EventArgs e)
        {
            if (ShowSelectedPerson != null)
                ShowSelectedPerson(this, EventArgs.Empty);
        }
    }
}