using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SmartDeviceProject1.Models;
using SmartDeviceProject1.Views;
using SmartDeviceProject1.Commands;

namespace SmartDeviceProject1.Presenters
{
    public class PersonPresenter : IPersonPresenter
    {
        #region IPresenter Members

        public IPersonView View
        {
            get;
            set;
        }

        public PersonPresenter()
        {

        }

        public void Initialize(IPersonView view)
        {
            this.View = view;
        }


        #endregion

        #region IPersonPresenter Members

        public void LoadPersonDetails()
        {
            ICommand<Person> command = new GetPersonDetailsCommand();
            command.Execute();
            var person = command.Result;
            this.View.Model.Age = person.Age;
            this.View.Model.FirstName = person.FirstName;
            this.View.BindModel();
        }

        #endregion

       
    }
}
