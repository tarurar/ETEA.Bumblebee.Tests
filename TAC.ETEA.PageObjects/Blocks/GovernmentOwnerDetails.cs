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
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

using TAC.ETEA.PageObjects.Pages;

namespace TAC.ETEA.PageObjects.Blocks
{
    public class GovernmentOwnerDetails: WebBlock
    {
        public GovernmentOwnerDetails(IBlock parent, By by)
            : base(parent, by)
        {}

        public GovernmentOwnerDetails(IBlock parent, By by, TimeSpan timeout)
            : base(parent, by, timeout)
        {}

        public ITextField<GovernmentOwnerDetails> OnwerNameAr
        {
            get
            {
                return new TextField<GovernmentOwnerDetails>(this, By.CssSelector("[id$=txtGovernmentNameAr]"));
            }
        }

        public ITextField<GovernmentOwnerDetails> OnwerNameEn
        {
            get
            {
                return new TextField<GovernmentOwnerDetails>(this, By.CssSelector("[id$=txtGovernmentNameEn]"));
            }
        }

        public ITextField<GovernmentOwnerDetails> PhoneNo
        {
            get
            {
                return new TextField<GovernmentOwnerDetails>(this, By.CssSelector("[id$=txtGovernmentPhoneNo]"));
            }
        }

        public ISelectBox<GovernmentOwnerDetails> Emirates
        {
            get
            {
                return new SelectBox<GovernmentOwnerDetails>(this, By.CssSelector("[id$=drpdwngovemirates]"));
            }
        }

        public ITextField<GovernmentOwnerDetails> FaxNo
        {
            get
            {
                return new TextField<GovernmentOwnerDetails>(this, By.CssSelector("[id$=txtGovernmentFaxNo]"));
            }
        }

        public ITextField<GovernmentOwnerDetails> Email
        {
            get
            {
                return new TextField<GovernmentOwnerDetails>(this, By.CssSelector("[id$=txtGovernmentEmail]"));
            }
        }

        public ICheckbox<GovernmentOwnerDetails> IsFeeExempted
        {
            get
            {
                return new Checkbox<GovernmentOwnerDetails>(this, By.CssSelector("[id$=chkGIsOwnerExempted]"));
            }
        }

        public IClickable<OwnerMgmtPage> SubmitButton
        {
            get
            {
                return new Clickable<OwnerMgmtPage>(this, By.CssSelector("[id$=radgovPopupowner_C_btnaddgovernmentowner]"));
            }
        }
    }
}
