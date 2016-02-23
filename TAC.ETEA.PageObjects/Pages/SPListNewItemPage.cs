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
    public class SPListNewItemPage : SPWebPage
    {
        public SPListNewItemPage(Session session)
            :base(session)
        {}

        public SPListNewItemPage(Session session, TimeSpan timeout)
            : base(session, timeout)
        {}

        public ITextField<SPListNewItemPage> TitleField
        {
            get { return new TextField<SPListNewItemPage>(this, By.CssSelector("input[id^=Title]")); }
        }

        public IClickable<SPListViewPage> SaveRibbonButton
        {
            get { return new Clickable<SPListViewPage>(this, By.CssSelector("input[id*='toolBarTbl_'][id*='SaveItem']")); }
        }
    }
}
