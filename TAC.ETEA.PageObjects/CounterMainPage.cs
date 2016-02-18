using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace TAC.ETEA.PageObjects
{
    public class CounterMainPage: WebBlock
    {
        public CounterMainPage(Session session): base(session)
        {

        }

        public IClickable<SearchCustomerPage> SearchCustomerButton
        {
            get { return new Clickable<SearchCustomerPage>(this, By.CssSelector("a[title='Customers']")); }
        }
    }
}
