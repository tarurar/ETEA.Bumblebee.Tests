using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
using Bumblebee.Implementation;
using Bumblebee.Extensions;
using Bumblebee.Interfaces;
using Bumblebee.Exceptions;

using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace TAC.ETEA.Tests
{
    [TestFixture]
    public class ETEATest
    {
        private static readonly string userName = "tacme4";
        private static readonly string password = "\u0040bcd123";
        private static readonly string mainPageUrl = "wingtipserver";

        protected Session Session { get; private set; }
        [SetUp]
        public void SetUp()
        {
            Session = new Session<Chrome>();
        }

        [TearDown]
        public void TearDown()
        {
            Session.End();
        }

        public static string GetMainPageUrl()
        {
            return String.Format("http://{0}:{1}@{2}", userName, password, mainPageUrl);
        }
    }
}
