using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Extensions;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using TAC.ETEA.PageObjects.Blocks;


namespace TAC.ETEA.PageObjects.Pages
{
    public class OwnerMgmtPage: SPWebPage
    {
        public OwnerMgmtPage(Session session, TimeSpan timeout)
            : base(session, timeout)
        {}

        public OwnerMgmtPage(Session session)
            : base(session)
        { }

        public IClickable<OwnerMgmtPage> IndividualTab
        {
            get { return GetTab("individual"); }
        }

        public IClickable<OwnerMgmtPage> CompanyTab
        {
            get { return GetTab("company"); }
        }

        public IClickable<OwnerMgmtPage> GovernmentTab
        {
            get { return GetTab("govt"); }
        }

        public ITextField<OwnerMgmtPage> GovernmentNameTextField
        {
            get
            {
                return new TextField<OwnerMgmtPage>(this, By.CssSelector("input[id$=PlaceHolderMain_ownerMgmtUC_governmentnameen]"));
            }
        }

        public IClickable<OwnerMgmtPage> SearchGovernmentButton
        {
            get
            {
                return new Clickable<OwnerMgmtPage>(this, By.CssSelector("[id$=ownerMgmtUC_btngovernmentsearch]"));
            }
        }

        public IClickable<OwnerMgmtPage> ResetGovernmentButton
        {
            get
            {
                return new Clickable<OwnerMgmtPage>(this, By.CssSelector("[id$=ownerMgmtUC_btnGovReset]"));
            }
        }

        public IClickable<OwnerMgmtPage> AddGovernmentButton
        {
            get
            {
                return new Clickable<OwnerMgmtPage>(this, By.CssSelector("[id$=ownerMgmtUC_addnewgovernment]"));
            }
        }

        protected IClickable<OwnerMgmtPage> GetTab(string tabId)
        {
            var cssSelector = String.Format("li[data-tab='#{0}'", tabId);

            return new Clickable<OwnerMgmtPage>(this, By.CssSelector(cssSelector));
        }

        public GovernmentOwnerDetails GovernmentOwnerDetails
        {
            get
            {
                return new GovernmentOwnerDetails(this, By.CssSelector("[id$=radgovPopupowner]"));
            }
        }
    }
}
