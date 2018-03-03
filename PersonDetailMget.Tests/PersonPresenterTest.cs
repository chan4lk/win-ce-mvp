using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartDeviceProject1.Presenters;
using Moq;
using SmartDeviceProject1.Views;
using SmartDeviceProject1.Models;

namespace PersonDetailMget.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class PersonPresenterTest
    {
        public PersonPresenterTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;
        
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void LoadPersons()
        {
            IPersonPresenter presenter = new PersonPresenter();
            var mock = new Mock<IPersonView>();
            var person = new Person();            
            mock.Setup(p => p.Model).Returns(person);
            presenter.Initialize(mock.Object);
            presenter.LoadPersonDetails();
            Assert.AreEqual("Chandima", person.FirstName);
            Assert.AreEqual(24, person.Age);
        }
    }
}
