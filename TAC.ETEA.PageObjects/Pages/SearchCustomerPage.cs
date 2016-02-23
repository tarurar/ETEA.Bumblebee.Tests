using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using Bumblebee.Extensions;
using OpenQA.Selenium;

namespace TAC.ETEA.PageObjects.Pages
{
    public class SearchCustomerPage : SPWebPage
    {
        public SearchCustomerPage(Session session): base(session)
        {
        }

        public IClickable<SearchCustomerPage> IndividualTab
        {
            get
            {
                return new Clickable<SearchCustomerPage>(this, By.CssSelector("._tabItem[data-tab='#individual']"));
            }
        }

        public IClickable<SearchCustomerPage> CompanyTab
        {
            get
            {
                return new Clickable<SearchCustomerPage>(this, By.CssSelector("._tabItem[data-tab='#company']"));
            }
        }


        public ITextField<SearchCustomerPage> CompanyLicenseNo
        {
            get
            {
                return new TextField<SearchCustomerPage>(this, By.CssSelector("#company input[id$=txtLicenseNumber]"));
            }
        }

        public IClickable<SearchCustomerPage> SearchButton
        {
            get
            {
                return new Clickable<SearchCustomerPage>(this, By.CssSelector("input[id$=btnCompanySearch]"));
            }
        }

    }
}
