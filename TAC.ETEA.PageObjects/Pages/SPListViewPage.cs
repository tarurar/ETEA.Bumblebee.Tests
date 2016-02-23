using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Extensions;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;


namespace TAC.ETEA.PageObjects.Pages
{
    public class SPListViewPage: SPWebPage
    {
        public SPListViewPage(Session session)
            : base(session)
        {}

        public SPListViewPage(Session session, TimeSpan timeout)
            : base(session, timeout)
        {}

        public IClickable<SPListNewItemPage> NewItemLink
        {
            get 
            {
                return new Clickable<SPListNewItemPage>(this, By.Id("idHomePageNewItem"));
            }
        }
    }
}
