using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Extensions;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

namespace TAC.ETEA.PageObjects.Pages
{
    public abstract class SPWebPage: WebPage
    {
        public SPWebPage(Session session, TimeSpan timeout): base(Initialize(session), timeout)
        { 
        }

        public SPWebPage(Session session): base(Initialize(session))
        {
        }

        protected static Session Initialize(Session session)
        {
            session.Pause(3000);
            return session;
        }
    }
}
