using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace TAC.ETEA.PageObjects.Pages
{
    public class CounterMainPage: SPWebPage
    {
        public CounterMainPage(Session session)
            : base(session)
        {}

        public CounterMainPage(Session session, TimeSpan timeout)
            : base(session, timeout)
        {}        

        public IClickable<SearchCustomerPage> SearchCustomerButton
        {
            get { return new Clickable<SearchCustomerPage>(this, By.CssSelector("div[id=_homeslider]>div:not(.bx-clone) a[title='Customers']")); }
        }

        public IClickable<ManualMergePage> ManualMergeButton
        {
            get { return new Clickable<ManualMergePage>(this, By.CssSelector("div[id=_homeslider]>div:not(.bx-clone) a[title='Manual Merge']")); }
        }


        public IClickable<OwnerMgmtPage> OwnerMgmtButton
        {
            get { return new Clickable<OwnerMgmtPage>(this, By.CssSelector("a[title='Owners']")); }
        }

        public IClickable<CounterMainPage> NextNutton
        {
            get
            {
                return new Clickable<CounterMainPage>(this, By.ClassName("bx-next"));
            }
        }

        public IClickable<CounterMainPage> PrevNutton
        {
            get
            {
                return new Clickable<CounterMainPage>(this, By.ClassName("bx-prev"));
            }
        }
    }
}
