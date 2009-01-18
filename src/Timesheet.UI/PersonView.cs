using System;
using System.Windows.Forms;
using Timesheet.BL;
using Timesheet.Domain.Presentation;
using Utilities.Extensions;

namespace Timesheet.UI
{
    public partial class PersonView : Form, IViewPersonView
    {
        public event EventHandler SavePerson;
        public Person Person { get; set; }

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

            //Vervang door databinding...
            txtLastName.Text = Person.LastName;
            txtFirstName.Text = Person.FirstName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(SavePerson.IsNotNull())
                SavePerson(this, EventArgs.Empty);
        }
    }
}