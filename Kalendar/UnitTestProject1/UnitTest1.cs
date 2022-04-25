using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLibrary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Event> list = new List<Event>();
            EventList eventList = new EventList("Название недели", list);
            Assert.AreEqual(eventList.GetWeekend(), "Название недели");
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<EventList> eventList = new List<EventList>();
            Application application = new Application(eventList);
            Assert.AreEqual(application.GetName(),"Имя");
        }

    }
}
