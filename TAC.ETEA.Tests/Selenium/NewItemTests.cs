using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;

namespace TAC.ETEA.Tests.Selenium
{
    [TestFixture]
    public class NewItemTests
    {
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [Test]
        public void CanAddNewItem_Selenium()
        {
            var newItemTitle = RandomString(8);

            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));

                driver.Navigate().GoToUrl("http://Administrator:pass\u0040word1@intranet.wingtip.com/Lists/TestList/AllItems.aspx");
                var newItemLink = driver.FindElementById("idHomePageNewItem");
                newItemLink.Click();

                var titleField = driver.FindElementByCssSelector("input[id^=Title]");
                titleField.Clear();
                titleField.SendKeys(newItemTitle);

                var saveButton = driver.FindElementByCssSelector("input[id*='toolBarTbl_'][id*='SaveItem']");
                saveButton.Click();

                Assert.AreEqual(true, driver.FindElementById("idHomePageNewItem").Displayed);

                driver.Quit();
            }
        }
    }
}
