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
    public class ManualMergePage: SPWebPage
    {
        public ManualMergePage(Session session)
            : base(session)
        {}

        public ManualMergePage(Session session, TimeSpan timeout)
            : base(session, timeout)
        {}
   
        public ISelectBox<ManualMergePage> City
        {
            get
            {
                return new SelectBox<ManualMergePage>(this, By.CssSelector("[id$=ddlParcelCity]"));
            }
        }

        public ISelectBox<ManualMergePage> Sector
        {
            get
            {
                return new SelectBox<ManualMergePage>(this, By.CssSelector("[id$=ddlParcelSector]"));
            }
        }

        public ISelectBox<ManualMergePage> District
        {
            get
            {
                return new SelectBox<ManualMergePage>(this, By.CssSelector("[id$=ddlParcelDistrict]"));
            }
        }

        public ITextField<ManualMergePage> PlotNo
        {
            get
            {
                return new TextField<ManualMergePage>(this, By.CssSelector("[id$=txtParcelPlot]"));
            }
        }

        public IClickable<ManualMergePage> VerifyButton
        {
            get
            {
                return new Clickable<ManualMergePage>(this, By.CssSelector("[id$=btnParcelVerify]"));
            }
        }

        public IWebElement ValidationMessage
        {
            get
            {
                return FindElement(By.CssSelector("[id$=lblValidationmsg]"));
            }
        }
    }
}
