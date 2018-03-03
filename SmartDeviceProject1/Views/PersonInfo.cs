using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.Views;
using SmartDeviceProject1.Presenters;
using SmartDeviceProject1.Models;

namespace SmartDeviceProject1
{
    public partial class PersonInfo : Form, IPersonView
    {
        private IPersonPresenter presenter;

        public SmartDeviceProject1.Models.Person Model
        {
            get;
            set;
        }

        public PersonInfo()
        {
            InitializeComponent();
            this.Model = new Person();
            this.presenter = new PersonPresenter();
            this.presenter.Initialize(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.presenter.LoadPersonDetails();
        }

        #region IPersonView Members

        

        public void BindModel()
        {
            textBox1.Text = this.Model.FirstName;
            textBox2.Text = this.Model.Age.ToString();
        }

        #endregion
    }
}