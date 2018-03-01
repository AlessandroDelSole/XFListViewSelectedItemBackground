using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XFListViewSelectedItemBackground
{
    public class PhoneBook
    {
        public ObservableCollection<Person> People { get; set; }

        public PhoneBook()
        {
            this.People = new ObservableCollection<Person>();

            this.People.Add(new Person { Name = "Alessandro", Age = 40 });
            this.People.Add(new Person { Name = "Anthony", Age = 39 });
            this.People.Add(new Person { Name = "Robert", Age = 44 });
        }
    }
}
