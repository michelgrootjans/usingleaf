using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timesheet.BL;
using Timesheet.Domain.Presentation;
using Utilities.Extensions;

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
            set
            {
                personList.DataSource = value;
                //of hoe databinding ook weer gaat...
            }
        }

        public Person GetSelectedPerson()
        {
            //is dit hoe je de person moet terugvinden?
            return personList.SelectedRows[0].DataBoundItem as Person;
        }

        private void ListPersonView_Load(object sender, EventArgs e)
        {
            if (GiveMeAllPersons.IsNotNull())
                GiveMeAllPersons(this, EventArgs.Empty);
        }

        private void personList_DoubleClick(object sender, EventArgs e)
        {
            if (ShowSelectedPerson.IsNotNull())
                ShowSelectedPerson(this, EventArgs.Empty);
        }
    }
}