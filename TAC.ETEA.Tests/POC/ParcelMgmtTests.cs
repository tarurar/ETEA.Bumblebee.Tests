using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TAC.ETEA.PageObjects;
using TAC.ETEA.PageObjects.Pages;
using TAC.ETEA.PageObjects.Blocks;

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

namespace TAC.ETEA.Tests.POC
{
    [TestFixture]
    public class ParcelMgmtTests: ETEATest
    {
        [Test, TestCaseCode("EN_TC_Manual Merge-117")]
        public void CanFindFindParcelOutofGIS()
        {
            Session
                .NavigateTo<CounterMainPage>(GetMainPageUrl())
                .NextNutton.Click<CounterMainPage>()
                .Pause(3000)
                .ManualMergeButton.Click<ManualMergePage>()
                .City.Options.WithText("Ajman").Single().Click()
                .Sector.Options.WithText("City Center Sector").Single().Click()
                .District.Options.WithText("Rashideya 1").Single().Click()
                .PlotNo.EnterText("0008")
                .VerifyButton.Click<ManualMergePage>()
                .Pause(3000)
                .ValidationMessage
                .VerifyThat(x => Assert.IsTrue(x.Text.Contains("This Parcel doesn't exist in GIS")));
        }

    }
}
