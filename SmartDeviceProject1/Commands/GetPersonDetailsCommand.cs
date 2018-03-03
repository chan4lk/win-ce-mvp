using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SmartDeviceProject1.Models;

namespace SmartDeviceProject1.Commands
{
    public class GetPersonDetailsCommand : ICommand<Person>
    {
        private Person person;

        public void Execute()
        {
            person = new Person();
            person.FirstName = "Chandima";
            person.Age = 24;            
        }



        #region ICommand<Person> Members

        public Person Result
        {
            get
            {
                return person;
            }
        }

        #endregion
    }
}
