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
    public class SPListViewPage: WebBlock
    {
        public SPListViewPage(Session session):base(session)
        {

        }

        public IClickable<SPListNewItemPage> NewItemLink
        {
            get 
            {
                return new Clickable<SPListNewItemPage>(this, By.Id("idHomePageNewItem"));
            }
        }
    }
}
