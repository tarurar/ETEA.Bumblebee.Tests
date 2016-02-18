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
    public class SPListNewItemPage: WebBlock
    {
        public SPListNewItemPage(Session session):base(session)
        {
            
        }

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
