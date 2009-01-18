using System;
using System.Windows.Forms;
using Timesheet.BL;
using Timesheet.Domain.Presentation;

namespace Timesheet.UI
{
    public partial class PersonView : Form, IViewPersonView
    {
        public event EventHandler GetPerson;
        public Person Person { get; private set; }

        public PersonView()
        {
            InitializeComponent();
        }

        public void SetPerson(Person person)
        {
            Person = person;
            ShowPerson();
        }

        private void ShowPerson()
        {
            Text = Person.Name;
            txtLastName.Text = Person.LastName;
            txtFirstName.Text = Person.FirstName;
        }
    }
}