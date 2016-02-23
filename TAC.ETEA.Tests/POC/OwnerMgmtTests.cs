using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class OwnerMgmtTests: ETEATest
    {
        [Test, TestCaseCode("EN_TC_3.2.4 Owner profile management-5")]
        public void CanEnterGovernmentForSearch()
        {
            var govtName = Utility.RandomString(10);

            Session
                .NavigateTo<CounterMainPage>(GetMainPageUrl())
                .OwnerMgmtButton.Click<OwnerMgmtPage>()
                .GovernmentTab.Click<OwnerMgmtPage>()
                .GovernmentNameTextField.EnterText(govtName)
                .SearchGovernmentButton.Click<OwnerMgmtPage>()
                .Pause(3000)
                .VerifyPresenceOf<OwnerMgmtPage>("Add New button", By.CssSelector("[id$=ownerMgmtUC_addnewgovernment]"));
        }

        [Test, TestCaseCode("EN_TC_3.2.4 Owner profile management-11")]
        public void CanOpenAddNewGovernmentDialog()
        {
            var govtName = Utility.RandomString(10);

            Session
                .NavigateTo<CounterMainPage>(GetMainPageUrl())
                .OwnerMgmtButton.Click<OwnerMgmtPage>()
                .GovernmentTab.Click<OwnerMgmtPage>()
                .GovernmentNameTextField.EnterText(govtName)
                .SearchGovernmentButton.Click<OwnerMgmtPage>()
                .Pause(3000)
                .AddGovernmentButton.Click<OwnerMgmtPage>()
                .GovernmentOwnerDetails
                .VerifyPresenceOf<GovernmentOwnerDetails>("owner name in arabic", By.CssSelector("[id$=txtGovernmentNameAr]"))
                .VerifyPresenceOf<GovernmentOwnerDetails>("owner name in english", By.CssSelector("[id$=txtGovernmentNameEn]"))
                .VerifyPresenceOf<GovernmentOwnerDetails>("fax no", By.CssSelector("[id$=txtGovernmentFaxNo]"))
                .VerifyPresenceOf<GovernmentOwnerDetails>("emirates", By.CssSelector("[id$=drpdwngovemirates]"))
                .VerifyPresenceOf<GovernmentOwnerDetails>("email", By.CssSelector("[id$=txtGovernmentEmail]"))
                .VerifyPresenceOf<GovernmentOwnerDetails>("is fee exempted checkbox", By.CssSelector("[id$=chkGIsOwnerExempted]"))
                .VerifyPresenceOf<GovernmentOwnerDetails>("phone no", By.CssSelector("[id$=txtGovernmentPhoneNo]"));
        }
    }
}
