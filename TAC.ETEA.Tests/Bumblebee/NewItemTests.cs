﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TAC.ETEA.PageObjects.Pages;
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

namespace TAC.ETEA.Tests.Bumblebee
{
    [TestFixture]
    public class NewItemTests
    {
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

        //[Test]
        public void CanAddNewItem_Bumblebee()
        {
            var newItemTitle = Utility.RandomString(8);

            Session
                .NavigateTo<SPListViewPage>("http://Administrator:pass\u0040word1@intranet.wingtip.com/Lists/TestList/AllItems.aspx")
                .NewItemLink
                .Click<SPListNewItemPage>()
                .TitleField.EnterText(newItemTitle)
                .SaveRibbonButton.Click<SPListViewPage>()
                .VerifyPresenceOf<SPListViewPage>("new item link", By.Id("idHomePageNewItem"));
        }
    }
}
